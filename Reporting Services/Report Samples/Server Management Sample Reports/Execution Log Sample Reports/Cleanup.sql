--
-- Script to cleanup data in the Reporting Services Execution Log subsystem
--
-- (c) 2003 Microsoft Corproation, All Rights Reserved
--
-- Dave Wickert, BI Practices Team
-- Sept 11, 2003
--

SET NOCOUNT ON

/* 
 Change this constant for the earliest data
 Everything earlier will be deleted 
 */
DECLARE @EarliestTimeStart datetime
SET @EarliestTimeStart = '2004-01-01 00:00:00'
                         -- ** Always use ODBC cannonical form **
                         -- i.e. yyyy-mm-dd hh:mi:ss(24h) 

/* Additional variables used for the audit trail */
DECLARE @rc INT
DECLARE @event NVARCHAR(4000)

/* Delete parameter data first . . . */
DELETE dbo.ExecutionParameters
FROM dbo.ExecutionParameters p INNER JOIN
	dbo.ExecutionLogs l ON l.ExecutionLogID = p.ExecutionLogID
WHERE l.TimeStart < @EarliestTimeStart
SET @rc = @@ROWCOUNT
SET @event = N'Deleted ' + CONVERT(NVARCHAR(20),@rc) + N' rows from the ExecutionParameters table.'
INSERT INTO dbo.RunLogs (Event) VALUES (@event)

/* Now we can delete requested Execution Log data itself */
DELETE FROM dbo.ExecutionLogs
WHERE TimeStart < @EarliestTimeStart
SET @rc = @@ROWCOUNT
SET @event = N'Deleted ' + CONVERT(NVARCHAR(20),@rc) + N' rows from the ExecutionLogs table.'
INSERT INTO dbo.RunLogs (Event) VALUES (@event)

/* Cleanup each of the data-driven dimension tables */

-- The FormatTypes table
DELETE dbo.FormatTypes 
FROM dbo.FormatTypes f
WHERE f.FormatType <> 1
      AND NOT EXISTS (SELECT FormatType FROM dbo.ExecutionLogs l WHERE l.FormatType = f.FormatType)
SET @rc = @@ROWCOUNT
SET @event = N'Deleted ' + CONVERT(NVARCHAR(20),@rc) + N' rows from the FormatTypes table.'
INSERT INTO dbo.RunLogs (Event) VALUES (@event)

-- The Machines table
DELETE dbo.Machines
FROM dbo.Machines m
WHERE NOT EXISTS (SELECT MachineKey FROM dbo.ExecutionLogs l WHERE l.MachineKey = m.MachineKey)
SET @rc = @@ROWCOUNT
SET @event = N'Deleted ' + CONVERT(NVARCHAR(20),@rc) + N' rows from the Machines table.'
INSERT INTO dbo.RunLogs (Event) VALUES (@event)

-- The Reports table
DELETE dbo.Reports
FROM dbo.Reports r
WHERE r.ReportKey <> 1
      AND NOT EXISTS (SELECT ReportKey FROM dbo.ExecutionLogs l WHERE l.ReportKey = r.ReportKey)
SET @rc = @@ROWCOUNT
SET @event = N'Deleted ' + CONVERT(NVARCHAR(20),@rc) + N' rows from the Reports table.'
INSERT INTO dbo.RunLogs (Event) VALUES (@event)

-- The StatusCodes table
DELETE dbo.StatusCodes
FROM dbo.StatusCodes c
WHERE c.StatusCode <> 1
      AND NOT EXISTS (SELECT StatusCode FROM dbo.ExecutionLogs l WHERE l.StatusCode = c.StatusCode)
SET @rc = @@ROWCOUNT
SET @event = N'Deleted ' + CONVERT(NVARCHAR(20),@rc) + N' rows from the StatusCodes table.'
INSERT INTO dbo.RunLogs (Event) VALUES (@event)

-- The Users table
DELETE dbo.Users
FROM dbo.Users u
WHERE u.UserKey <> 1
      AND NOT EXISTS (SELECT UserKey FROM dbo.ExecutionLogs l WHERE l.UserKey = u.UserKey)
SET @rc = @@ROWCOUNT
SET @event = N'Deleted ' + CONVERT(NVARCHAR(20),@rc) + N' rows from the Users table.'
INSERT INTO dbo.RunLogs (Event) VALUES (@event)

GO

