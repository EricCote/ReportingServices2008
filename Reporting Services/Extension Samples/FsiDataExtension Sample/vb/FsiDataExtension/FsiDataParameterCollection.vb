'=====================================================================
'
'  File:      FsiDataParameterCollection.vb
'  
'  Summary:   Represents a collection of parameters.
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
Imports System.Collections
Imports System.Globalization

'
'* Because IDataParameterCollection is primarily an IList,
'* the sample can use an existing class for most of the implementation.
'* In this sample, we use ArrayList. 
'

<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1010:CollectionsShouldImplementGenericInterface")> _
<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1039:ListsAreStronglyTyped")> _
<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1035:ICollectionImplementationsHaveStronglyTypedMembers")> _
Public Class FsiDataParameterCollection
    Inherits ArrayList
    Implements IDataParameterCollection

    Default Public Overloads Property Item(ByVal index As String) As Object
        Get
            Return Me(IndexOf(index))
        End Get
        Set(ByVal Value As Object)
            Me(IndexOf(index)) = Value
        End Set
    End Property

    Public Overloads Overrides Function Add(ByVal value As Object) As Integer
        Return Add(CType(value, IDataParameter))
    End Function

    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:ValidateArgumentsOfPublicMethods")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:DoNotPassLiteralsAsLocalizedParameters", MessageId:="System.ArgumentException.#ctor(System.String)")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> _
    Public Overloads Function Add(ByVal parameter As IDataParameter) As Integer Implements IDataParameterCollection.Add
        If Not (CType(parameter, FsiDataParameter).ParameterName Is Nothing) Then
            Return MyBase.Add(parameter)
        Else
            Throw New ArgumentException("parameter must be named")
        End If
    End Function
End Class
