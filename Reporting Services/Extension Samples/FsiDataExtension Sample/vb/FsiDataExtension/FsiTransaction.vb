'=====================================================================
'
'  File:      FsiTransaction.vb
'  
'  Summary:   Represents a transaction at a data source.
'
'------------------------------------------------------------------------
'  This file is part of the Microsoft SQL Server Code Samples.
'  Copyright (C) 2003 Microsoft Corporation.  All rights reserved.
'
'  This source code is intended only as a supplement to Microsoft
'  Development Tools and/or on-line documentation.  See these other
'  materials for detailed information regarding Microsoft code samples.
'
'  THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
'  KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
'  IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
'  PARTICULAR PURPOSE.
'======================================================================== 
Option Strict On
Option Explicit On

Imports System
Imports Microsoft.ReportingServices.DataProcessing

<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly")> Public Class FsiTransaction
    Implements IDbTransaction
    'ToDo: Add Implements Clauses for implementation methods of these interface(s)

    Dim mm_connection As IDbConnection

    ''' <summary>
    ''' Implement Commit here. Although the template does
    ''' not provide an implementation, it should never be 
    ''' a no-op because data corruption could result.
    ''' </summary>
    ''' <remarks></remarks>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> _
    Public Sub Commit() Implements IDbTransaction.Commit
    End Sub

    ''' <summary>
    ''' Implement Rollback here. Although the template does
    ''' not provide an implementation, it should never be
    ''' a no-op because data corruption could result.
    ''' </summary>
    ''' <remarks></remarks>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> _
    Public Sub Rollback() Implements IDbTransaction.Rollback
    End Sub

    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly")> Public Sub Dispose() Implements IDisposable.Dispose
        mm_connection.Dispose()
    End Sub
End Class