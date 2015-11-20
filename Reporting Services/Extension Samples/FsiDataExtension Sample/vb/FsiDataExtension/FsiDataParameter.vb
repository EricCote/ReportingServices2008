'=====================================================================
'
'  File:      FsiDataParameter.vb
'  
'  Summary:   Represents a parameter to a query.
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

Public Class FsiDataParameter
    Implements IDataParameter 'ToDo: Add Implements Clauses for implementation methods of these interface(s)
    Private m_paramName As String
    Private m_value As Object


    Public Sub New()
    End Sub


    Public Sub New(ByVal parameterName As String, ByVal value As Object)
        m_paramName = parameterName
        Me.Value = value
    End Sub ' Setting the value also infers the type.


    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> _
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> _
    Public Property ParameterName() As String Implements IDataParameter.ParameterName
        Get
            Return m_paramName
        End Get
        Set(ByVal value As String)
            m_paramName = value
        End Set
    End Property

    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> _
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> _
    Public Property Value() As Object Implements IDataParameter.Value
        Get
            Return m_value
        End Get
        Set(ByVal value As Object)
            m_value = value
        End Set
    End Property
End Class 'FsiDataParameter