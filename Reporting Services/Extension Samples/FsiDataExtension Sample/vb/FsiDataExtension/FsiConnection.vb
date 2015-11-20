 '=====================================================================
'
'    File:      FsiConnection.vb
'        
'    Summary:   Represents a connection and an extension.
'
'    ------------------------------------------------------------------------
'    This file is part of Microsoft SQL Server Code Samples.
'        
'    Copyright (C) Microsoft Corporation.  All rights reserved.
'
'    This source code is intended only as a supplement to Microsoft
'    Development Tools and/or on-line documentation.  See these other
'    materials for detailed information regarding Microsoft code samples.
'
'    THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
'    KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
'    IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
'    PARTICULAR PURPOSE.
'======================================================================== 
Imports System
Imports Microsoft.ReportingServices.DataProcessing
Imports Microsoft.ReportingServices.Interfaces
Imports System.Security.Permissions
Imports System.Security.Principal


NotInheritable Public Class FsiConnection
    Implements IDbConnectionExtension
    Private m_conn As String
    Private m_state As System.Data.ConnectionState = System.Data.ConnectionState.Closed
    Private m_locName As String = "File Share Information"
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")> Private m_impersonate As String
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")> Private m_username As String
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")> Private m_password As String

    Private m_connectionOpened As Boolean = False
    Private m_connectionUser As WindowsIdentity = Nothing
    Private m_integratedSecurity As Boolean = False


    Public Sub New()

    End Sub

    ' This extension does not use a connection string

    ' Have a constructor that takes a connection string.
    Public Sub New(ByVal conn As String)

    End Sub
    ' This extension does not use a connection string

    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> Property ConnectionString() As String Implements IDbConnection.ConnectionString
        Get
            ' Always return exactly what the user set.
            ' Security-sensitive information may be removed.
            Return m_conn
        End Get
        Set(ByVal value As String)
            m_conn = value
        End Set
    End Property


    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> ReadOnly Property ConnectionTimeout() As Integer Implements IDbConnection.ConnectionTimeout
        Get
            ' Returns the connection time-out value set in the connection
            ' string. Zero indicates an indefinite time-out period.
            Return 0
        End Get
    End Property


    Public ReadOnly Property State() As System.Data.ConnectionState
        Get
            Return m_state
        End Get
    End Property


    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> Function BeginTransaction() As IDbTransaction Implements IDbConnection.BeginTransaction
        Throw New NotSupportedException()

    End Function


    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> Sub Open() Implements IDbConnection.Open
        '
        '            * Open the database connection and set the ConnectionState
        '            * property. If the underlying connection to the server is 
        '            * expensive to obtain, the implementation should provide
        '            * implicit pooling of that connection.
        '            * 
        '            * If the provider also supports automatic enlistment in 
        '            * distributed transactions, it should enlist during Open().
        '            
        If Not m_connectionOpened Then
            If m_integratedSecurity Then
                m_connectionUser = WindowsIdentity.GetCurrent()
            Else
                m_connectionUser = Nothing
            End If

            m_connectionOpened = True
        End If

    End Sub


    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> Sub Close() Implements IDbConnection.Close
        '
        '   Close the database connection and set the ConnectionState
        ' property. If the underlying connection to the server is
        ' being pooled, Close() will release it back to the pool.
        '            
        If Not (m_connectionUser Is Nothing) Then
            m_connectionUser.Dispose()
        End If
        m_connectionOpened = False

    End Sub


    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> Function CreateCommand() As IDbCommand Implements IDbConnection.CreateCommand
        ' Return a new instance of a command object.
        Return New FsiCommand(Me)

    End Function


    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> ReadOnly Property LocalizedName() As String Implements IExtension.LocalizedName
        Get
            ' Always return exactly what the user set.
            ' Security-sensitive information may be removed.
            Return m_locName
        End Get
    End Property


    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> Sub SetConfiguration(ByVal configuration As String) Implements IExtension.SetConfiguration

    End Sub
    ' Used to retrieve configuration data from the config file

    '***
    ' * REQUIRED METHODS / PROPERTIES FROM IDbConnectionExtension.
    '***
    '
    '* For data sources that require credentials, these properties
    '* add support for storing secure credentials while designing
    '* reports with Report Designer. The Data Source dialog will
    '* include support for the Integrated checkbox as well as
    '* text boxes for username and password.
    '

    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> Property IntegratedSecurity() As Boolean Implements IDbConnectionExtension.IntegratedSecurity
        Get
            Return m_integratedSecurity
        End Get
        Set(ByVal value As Boolean)
            m_integratedSecurity = value
        End Set
    End Property


    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1044:PropertiesShouldNotBeWriteOnly")> WriteOnly Property UserName() As String Implements IDbConnectionExtension.UserName
        Set(ByVal value As String)
            m_username = value
        End Set
    End Property


    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1044:PropertiesShouldNotBeWriteOnly")> WriteOnly Property Password() As String Implements IDbConnectionExtension.Password
        Set(ByVal value As String)
            m_password = value
        End Set
    End Property


    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1044:PropertiesShouldNotBeWriteOnly")> WriteOnly Property Impersonate() As String Implements IDbConnectionExtension.Impersonate
        Set(ByVal value As String)
            m_impersonate = value
        End Set
    End Property


    Sub Dispose() Implements IDisposable.Dispose

    End Sub


    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:DoNotPassLiteralsAsLocalizedParameters", MessageId:="System.Exception.#ctor(System.String)")> Friend ReadOnly Property ConnectionUser() As WindowsIdentity
        Get
            ' m_connectionUser is valid only during open connection
            If Not m_connectionOpened Then
                Throw New Exception("Connection Not Open")
            End If
            Return m_connectionUser
        End Get
    End Property
End Class