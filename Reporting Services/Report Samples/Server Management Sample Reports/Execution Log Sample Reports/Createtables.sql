/****************************************************************************
  This file is part of the Microsoft SQL Server Code Samples.
  Copyright (C) Microsoft Corporation.  All rights reserved.

  This source code is intended only as a supplement to Microsoft
  Development Tools and/or on-line documentation.  See these other
  materials for detailed information regarding Microsoft code samples.

  THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
  KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
  IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
  PARTICULAR PURPOSE.
*****************************************************************************/

--
-- Script to create the Reporting Services Execution Log subsystem
--
SET NOCOUNT ON
GO

--------------------------------------------------------------------------------------------------
--
-- Drop any existing tables (order is important -- base tables first, then foreign key tables)

PRINT 'Dropping tables...'

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[ExecutionParameters]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[ExecutionParameters]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[ExecutionLogs]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[ExecutionLogs]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[Reports]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[Reports]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[ReportTypes]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[ReportTypes]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[Users]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[Users]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[Machines]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[Machines]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[RequestTypes]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[RequestTypes]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[SourceTypes]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[SourceTypes]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[FormatTypes]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[FormatTypes]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[StatusCodes]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[StatusCodes]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[RunLogs]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[RunLogs]
GO

--------------------------------------------------------------------------------------------------
--
-- Reference ReportTypes

PRINT 'Creating ReportTypes...'
CREATE TABLE [dbo].[ReportTypes] (
	[ReportType] [int] NOT NULL PRIMARY KEY ,
	[Name] [nvarchar] (20) NOT NULL
) ON [PRIMARY]
GO

-- well-known values -- only expected values
INSERT INTO [dbo].[ReportTypes] ([ReportType], [Name]) VALUES (1, N'Folder')
INSERT INTO [dbo].[ReportTypes] ([ReportType], [Name]) VALUES (2, N'Report')
INSERT INTO [dbo].[ReportTypes] ([ReportType], [Name]) VALUES (3, N'Resource')
INSERT INTO [dbo].[ReportTypes] ([ReportType], [Name]) VALUES (4, N'Linked Report')
INSERT INTO [dbo].[ReportTypes] ([ReportType], [Name]) VALUES (5, N'Data Source')
GO


--------------------------------------------------------------------------------------------------
--
-- Table: Reports
--
-- Notes: An 'unknown' report is created to handle missing and NULL catalog references as data
--        streams from ExecutionLog table.

PRINT 'Creating Reports...'
CREATE TABLE [dbo].[Reports] (
	[ReportKey] [int] NOT NULL IDENTITY (100, 1) PRIMARY KEY ,
	[ReportID] [uniqueidentifier] NOT NULL ,
	[Path] [nvarchar] (425) NOT NULL ,
	[Name] [nvarchar] (425) NOT NULL ,
	[ReportType] [int] NOT NULL FOREIGN KEY REFERENCES [dbo].[ReportTypes] ([ReportType]) 
) ON [PRIMARY]
GO

-- well-known Reports
SET IDENTITY_INSERT [dbo].[Reports] ON
INSERT INTO [dbo].[Reports] ([ReportKey], [ReportID], [Path], [Name], [ReportType]) VALUES 
	(1, '{00000000-0000-0000-0000-000000000000}', N'', N'Unknown', 1) -- hard-coded as a folder
SET IDENTITY_INSERT [dbo].[Reports] OFF
GO

--------------------------------------------------------------------------------------------------
--
-- Table: Users
--
-- Notes: An 'unknown' user is created to handle missing user references as data
--        streams from ExecutionLog table.

PRINT 'Creating Users...'
CREATE TABLE [dbo].[Users] (
	[UserKey] [int] NOT NULL IDENTITY (100, 1) PRIMARY KEY ,
	[UserName] [nvarchar] (260) NOT NULL 
) ON [PRIMARY]
GO

SET IDENTITY_INSERT [dbo].[Users] ON
INSERT INTO [dbo].[Users] ([UserKey], [UserName]) VALUES 
	(1, N'Unknown') 
SET IDENTITY_INSERT [dbo].[Users] OFF
GO

--------------------------------------------------------------------------------------------------
--
-- Table: Machines (or really server\instance information)
--
-- Notes: Records are created dynamically as records stream across from the ExecutionLog table.

PRINT 'Creating Machines...'
CREATE TABLE [dbo].[Machines] (
	[MachineKey] [int] NOT NULL IDENTITY PRIMARY KEY ,
	[InstanceName] [nvarchar] (38) NOT NULL 
) ON [PRIMARY]
GO

--------------------------------------------------------------------------------------------------
--
-- Table: RequestTypes

PRINT 'Creating RequestTypes...'
CREATE TABLE [dbo].[RequestTypes] (
	[RequestType] [int] NOT NULL PRIMARY KEY ,
	[Name] [nvarchar] (20) NOT NULL
) ON [PRIMARY]
GO

-- well-known values -- only expected values
INSERT INTO [dbo].[RequestTypes] ([RequestType], [Name]) VALUES (0, N'User')
INSERT INTO [dbo].[RequestTypes] ([RequestType], [Name]) VALUES (1, N'System')
GO

--------------------------------------------------------------------------------------------------
--
-- Table: SourceTypes

PRINT 'Creating SourceTypes...'
CREATE TABLE [dbo].[SourceTypes] (
	[SourceType] [tinyint] NOT NULL PRIMARY KEY ,
	[Name] [nvarchar] (20) NOT NULL
) ON [PRIMARY]
GO

-- well-known values -- only expected values
INSERT INTO [dbo].[SourceTypes] ([SourceType], [Name]) VALUES (1, N'Live')
INSERT INTO [dbo].[SourceTypes] ([SourceType], [Name]) VALUES (2, N'Cache')
INSERT INTO [dbo].[SourceTypes] ([SourceType], [Name]) VALUES (3, N'Snapshot')
INSERT INTO [dbo].[SourceTypes] ([SourceType], [Name]) VALUES (4, N'History')
INSERT INTO [dbo].[SourceTypes] ([SourceType], [Name]) VALUES (5, N'Adhoc')
INSERT INTO [dbo].[SourceTypes] ([SourceType], [Name]) VALUES (6, N'Other')
GO

--------------------------------------------------------------------------------------------------
--
-- Table: FormatTypes
--
-- Notes: Records are created dynamically as records stream across from the ExecutionLog table.

PRINT 'Creating FormatTypes...'
CREATE TABLE [dbo].[FormatTypes] (
	[FormatType] [int] NOT NULL IDENTITY (100, 1) PRIMARY KEY,
	[Format] [nvarchar] (26) NULL 
) ON [PRIMARY]
GO

SET IDENTITY_INSERT [dbo].[FormatTypes] ON
INSERT INTO [dbo].[FormatTypes] ([FormatType], [Format]) VALUES (1, N'Unknown')
SET IDENTITY_INSERT [dbo].[FormatTypes] OFF
GO

--------------------------------------------------------------------------------------------------
--
-- Table: StatusCodes
--
-- Notes: An initial record for 'rsSuccess' is created so it is easy to check for well-known values
--        If desired, to keep track of other well-known values, can be inserted by-hand here.
--        Other records are created dynamically (starting with an identity seed of 1) as records
--        stream across from the ExecutionLog table.

PRINT 'Creating StatusCodes...'
CREATE TABLE [dbo].[StatusCodes] (
	[StatusCode] [int] NOT NULL IDENTITY (100, 1) PRIMARY KEY,
	[Status] [nvarchar] (32) NOT NULL 
) ON [PRIMARY]
GO

-- well-known values -- additional ones will be inserted as needed by DTS package
SET IDENTITY_INSERT [dbo].[StatusCodes] ON
INSERT INTO [dbo].[StatusCodes] ([StatusCode], [Status]) VALUES (1, N'rsSuccess')
SET IDENTITY_INSERT [dbo].[StatusCodes] OFF
GO

--------------------------------------------------------------------------------------------------
--
-- Table: ExecutionLogs
--
-- Notes: This is the real 'fact-table' of the system

PRINT 'Creating ExecutionLogs...'
CREATE TABLE [dbo].[ExecutionLogs] (
	[ExecutionLogID] [uniqueidentifier] NOT NULL DEFAULT NEWID() PRIMARY KEY ,

	[ReportKey] [int]           NOT NULL FOREIGN KEY REFERENCES [dbo].[Reports] ([ReportKey]) ,
	[UserKey] [int]             NOT NULL FOREIGN KEY REFERENCES [dbo].[Users] ([UserKey]) ,
	[MachineKey] [int]          NOT NULL FOREIGN KEY REFERENCES [dbo].[Machines] ([MachineKey]) ,
	[RequestType] [int]         NOT NULL FOREIGN KEY REFERENCES [dbo].[RequestTypes] ([RequestType]) ,
	[FormatType] [int]          NOT NULL FOREIGN KEY REFERENCES [dbo].[FormatTypes] ([FormatType]) ,
	[StatusCode] [int]          NOT NULL FOREIGN KEY REFERENCES [dbo].[StatusCodes] ([StatusCode]) ,
	[SourceType] [tinyint]      NOT NULL FOREIGN KEY REFERENCES [dbo].[SourceTypes] ([SourceType]) ,

	[Parameters] [ntext]        NULL ,

	[TimeStart] [datetime]      NOT NULL ,
	[TimeEnd] [datetime]        NOT NULL ,
	[TimeDataRetrieval] [int]   NOT NULL ,
	[TimeProcessing] [int]      NOT NULL ,
	[TimeRendering] [int]       NOT NULL ,
	[ByteCount] [bigint]        NOT NULL ,
	[RowCount] [bigint]         NOT NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


--------------------------------------------------------------------------------------------------
--
-- Table: ExecutionParameters
--
-- Notes: Records are built dynamically as each record streams across from the ExecutionLog table.

PRINT 'Creating ExecutionParameters...'
CREATE TABLE [dbo].[ExecutionParameters] (
	[ExecutionParameterID] [uniqueidentifier] NOT NULL DEFAULT NEWID() PRIMARY KEY ,
	[Name] [nvarchar] (2000) NOT NULL ,
	[Value] [nvarchar] (MAX) NOT NULL ,

	[ExecutionLogID] [uniqueidentifier] NOT NULL FOREIGN KEY REFERENCES [dbo].[ExecutionLogs] ([ExecutionLogID])

) ON [PRIMARY]
GO

--------------------------------------------------------------------------------------------------
--
-- Table: RunLogs

PRINT 'Creating RunLogs...'
CREATE TABLE [dbo].[RunLogs] (
	[Event] [nvarchar] (4000) NOT NULL ,
	[When] datetime NOT NULL DEFAULT getdate() 
) ON [PRIMARY]
GO

--------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------

PRINT 'Script completed.'
GO

