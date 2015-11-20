 '=====================================================================
'
'  File:      FsiCommand.vb
'  
'  Summary:   Represents a command.
'
'------------------------------------------------------------------------
'  This file is part of Microsoft SQL Server Code Samples.
'  
'  Copyright (C) Microsoft Corporation.  All rights reserved.
'
' This source code is intended only as a supplement to Microsoft
' Development Tools and/or on-line documentation.  See these other
' materials for detailed information regarding Microsoft code samples.
'
' THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
' KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
' IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
' PARTICULAR PURPOSE.
'======================================================================== 


Imports System
Imports System.ComponentModel
Imports Microsoft.ReportingServices.DataProcessing
Imports System.Security.Principal



NotInheritable Public Class FsiCommand
    Implements IDbCommand
    Private m_connection As FsiConnection
    Private m_txn As FsiTransaction
    Private m_cmdText As String
    Private m_parameters As New FsiDataParameterCollection()

    Public Sub New()

    End Sub

    ' Implement the default constructor here

    ' Implement other constructors here
    Public Sub New(ByVal connection As FsiConnection)
        m_connection = connection

    End Sub


    Public Sub New(ByVal cmdText As String)
        m_cmdText = cmdText

    End Sub


    Public Sub New(ByVal cmdText As String, ByVal connection As FsiConnection)
        m_cmdText = cmdText
        m_connection = connection

    End Sub


    Public Sub New(ByVal cmdText As String, ByVal connection As FsiConnection, ByVal txn As FsiTransaction)
        m_cmdText = cmdText
        m_connection = connection
        m_txn = txn

    End Sub

    '***
    '* IMPLEMENT THE REQUIRED PROPERTIES.
    '***
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> _
   <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> _
    Property CommandText() As String Implements IDbCommand.CommandText
        Get
            Return m_cmdText
        End Get
        Set(ByVal value As String)
            m_cmdText = value
        End Set
    End Property

    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> _
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> _
    Property CommandTimeout() As Integer Implements IDbCommand.CommandTimeout
        '
        '* The sample does not support a command time-out. 
        '
        Get
            Return 30
        End Get
        Set(ByVal value As Integer)
        End Set
    End Property

    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> _
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> _
    Property CommandType() As CommandType Implements IDbCommand.CommandType
        '
        '* The sample only supports CommandType.Text.
        '
        Get
            Return CommandType.Text
        End Get
        Set(ByVal value As CommandType)
            If value <> CommandType.Text Then
                Throw New NotSupportedException()
            End If
        End Set
    End Property

    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> _
    Public ReadOnly Property Parameters() As IDataParameterCollection Implements IDbCommand.Parameters
        Get
            Return m_parameters
        End Get
    End Property

    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> _
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> _
    Property Transaction() As IDbTransaction Implements IDbCommand.Transaction
        '
        '* Set the transaction. Consider additional steps to ensure that the transaction
        '* is compatible with the connection, because the two are usually linked.
        '
        Get
            Return m_txn
        End Get
        Set(ByVal value As IDbTransaction)
            m_txn = CType(value, FsiTransaction)
        End Set
    End Property

    '***
    '* IMPLEMENT THE REQUIRED METHODS.
    '***
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> _
    Sub Cancel() Implements IDbCommand.Cancel
        ' The sample does not support canceling a command
        ' once it has been initiated.
        Throw New NotSupportedException()

    End Sub 'IDbCommand.Cancel

    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> _
    Function CreateParameter() As IDataParameter Implements IDbCommand.CreateParameter
        Return CType(New FsiDataParameter(), IDataParameter)

    End Function 'IDbCommand.CreateParameter

    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:DisposeObjectsBeforeLosingScope")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> _
    Function ExecuteReader(ByVal behavior As CommandBehavior) As IDataReader Implements IDbCommand.ExecuteReader
        '
        '* ExecuteReader should retrieve results from the data source
        '* and return a DataReader that allows the user to process 
        '* the results.

        '* There is no CommandBehavior option supported by this
        '* sample.
        '
        Dim impersonationContext As WindowsImpersonationContext = Nothing
        Dim reader As FsiDataReader = Nothing
        Try
            If Not (m_connection.ConnectionUser Is Nothing) Then
                impersonationContext = m_connection.ConnectionUser.Impersonate()
            End If

            ' Execute the command.      
            reader = New FsiDataReader(m_cmdText)
            reader.GetDirectory(m_cmdText)

        Finally
            If Not (impersonationContext Is Nothing) Then
                impersonationContext.Dispose()
            End If
        End Try

        Return reader

    End Function
    
    
    Sub Dispose()  Implements IDisposable.Dispose
    
    End Sub
End Class
