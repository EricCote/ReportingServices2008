'=====================================================================
'
'  File:      FsiDataReader.vb
'  
'  Summary:   Represents a DataReader.
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
Imports System.Collections
Imports Microsoft.ReportingServices.DataProcessing
Imports System.IO
Imports System.Globalization
Imports System.Security
Imports System.Security.Principal



<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly")> Public Class FsiDataReader
    Implements IDataReader 'ToDo: Add Implements Clauses for implementation methods of these interface(s)

    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")> Private m_connection As FsiConnection

    Friend m_dir As DirectoryInfo
    Friend m_fsi() As FileSystemInfo
    Friend m_currentRow As Integer
    Friend m_ie As IEnumerator

    Friend m_names As String() = {"Name", "Size", "Type", "CreationDate"}
    Friend m_types As Type() = {GetType(String), GetType(Long), GetType(String), GetType(DateTime)}
    Friend m_cols(3) As Object
    Friend m_fieldCount As Integer = 4

    ' maximum size in bytes
    Friend m_sizes As Int32() = {1024, 8, 9, 8}

    '
    '* Because the user should not be able to directly create a 
    '* DataReader object, the constructors are
    '* marked as internal.
    '
    Friend Sub New()
    End Sub

    Friend Sub New(ByVal cmdText As String)
    End Sub

    Friend Sub New(ByVal cmdText As String, ByVal connection As FsiConnection)
        m_connection = connection
    End Sub

    '***
    '* METHODS / PROPERTIES FROM IDataReader.
    '***
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> _
    Public Function Read() As Boolean Implements IDataReader.Read
        If Not (m_ie Is Nothing) Then
            Dim notEOF As Boolean = m_ie.MoveNext()
            If notEOF = True Then
                m_currentRow += 1
                If TypeOf m_fsi(m_currentRow) Is FileInfo Then
                    Dim f As FileInfo = CType(m_fsi(m_currentRow), FileInfo)
                    m_cols(0) = f.Name
                    m_cols(1) = f.Length.ToString(System.Globalization.CultureInfo.InvariantCulture)
                    m_cols(2) = "File"
                    m_cols(3) = f.CreationTime.ToString(System.Globalization.CultureInfo.InvariantCulture)
                Else
                    Dim d As DirectoryInfo = CType(m_fsi(m_currentRow), DirectoryInfo)
                    m_cols(0) = d.Name
                    m_cols(1) = "0"
                    m_cols(2) = "Directory"
                    m_cols(3) = d.CreationTime.ToString(System.Globalization.CultureInfo.InvariantCulture)
                End If
            End If
            Return notEOF
        End If

        Return False
    End Function

    '***
    '* METHODS / PROPERTIES FROM IDataRecord.
    '***

    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> _
    Public ReadOnly Property FieldCount() As Integer Implements IDataReader.FieldCount
        ' Return the count of the number of columns, which in
        ' this case is the size of the column metadata
        ' array.
        Get
            Return m_fieldCount
        End Get
    End Property

    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> _
    Public Function GetName(ByVal fieldIndex As Integer) As String Implements IDataReader.GetName
        Return m_names(fieldIndex)
    End Function

    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> _
    Public Function GetFieldType(ByVal fieldIndex As Integer) As Type Implements IDataReader.GetFieldType
        ' Return the actual Type class for the data type.
        Return m_types(fieldIndex)
    End Function

    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> _
    Public Function GetValue(ByVal fieldIndex As Integer) As [Object] Implements IDataReader.GetValue
        Return m_cols(fieldIndex)
    End Function

    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")> _
    Public Function GetOrdinal(ByVal fieldName As String) As Integer Implements IDataReader.GetOrdinal
        ' Look for the ordinal of the column with the same name and return it.
        ' Returns -1 if not found
        Return Array.IndexOf(m_names, fieldName)
    End Function

    '
    '* Implementation specific methods.
    '
    Friend Sub GetDirectory(ByVal cmdText As String)
        ValidateCommandText(cmdText)

        m_dir = New DirectoryInfo(cmdText)
        m_fsi = m_dir.GetFileSystemInfos()

        m_currentRow = -1
        m_ie = m_fsi.GetEnumerator()
    End Sub

    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly")> Public Sub Dispose() Implements IDisposable.Dispose
    End Sub

    ' The following method loosely enforces the format of the 
    ' * command text. This data processing extension does not 
    ' * support local paths, i.e. c:\.
    ' 
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:DoNotPassLiteralsAsLocalizedParameters", MessageId:="System.InvalidOperationException.#ctor(System.String)")> Private Shared Sub ValidateCommandText(ByVal dir As String)
        ' Check format of command text.
        Dim isValidCmd As Boolean = dir.StartsWith("\")
        If Not isValidCmd Then
            Throw New InvalidOperationException("The current CommandText does not conform to a valid UNC file share.")
        End If
    End Sub
End Class