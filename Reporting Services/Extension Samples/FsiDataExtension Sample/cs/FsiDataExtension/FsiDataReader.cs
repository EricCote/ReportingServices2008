/*=====================================================================

  File:      FsiDataReader.cs
  
  Summary:   Represents a DataReader.

------------------------------------------------------------------------
  This file is part of Microsoft SQL Server Code Samples.
  
  Copyright (C) Microsoft Corporation.  All rights reserved.

 This source code is intended only as a supplement to Microsoft
 Development Tools and/or on-line documentation.  See these other
 materials for detailed information regarding Microsoft code samples.

 THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
 KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
 IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
 PARTICULAR PURPOSE.
======================================================================== */

using System;
using System.Collections;
using Microsoft.ReportingServices.DataProcessing;
using System.IO;
using System.Globalization;
using System.Security;
using System.Security.Principal;

namespace Microsoft.Samples.ReportingServices.FsiDataExtension
{
    public sealed class FsiDataReader : IDataReader
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private FsiConnection m_connection;

        internal DirectoryInfo m_dir;
        internal FileSystemInfo[] m_fsi;
        internal int m_currentRow;
        internal IEnumerator m_ie;
        internal String[] m_names = { "Name", "Size", "Type", "CreationDate" };
        internal Type[] m_types = { typeof(String), typeof(long), typeof(String), typeof(DateTime) };
        internal object[] m_cols = new object[4];
        internal int m_fieldCount = 4;

        // maximum size in bytes
        internal Int32[] m_sizes = { 1024, 8, 9, 8 };

        /*
        * Because the user should not be able to directly create a 
        * DataReader object, the constructors are
        * marked as internal.
        */
        internal FsiDataReader()
        {
            // TODO: Implement default constructor
        }

        internal FsiDataReader(string cmdText)
        {
            // TODO: Implement command text only construtor
        }

        internal FsiDataReader(string cmdText, FsiConnection connection)
        {
            m_connection = connection;
        }

        /****
        * METHODS / PROPERTIES FROM IDataReader.
        ****/

        bool IDataReader.Read()
        {
            if (m_ie != null)
            {
                bool notEOF = m_ie.MoveNext();
                if (notEOF == true)
                {
                    m_currentRow++;
                    if (m_fsi[m_currentRow] is FileInfo)
                    {
                        FileInfo f = (FileInfo)m_fsi[m_currentRow];
                        m_cols[0] = f.Name;
                        m_cols[1] = f.Length.ToString(
                            System.Globalization.CultureInfo.InvariantCulture);
                        m_cols[2] = "File";
                        m_cols[3] = f.CreationTime.ToString();
                    }
                    else
                    {
                        DirectoryInfo d = (DirectoryInfo)m_fsi[m_currentRow];
                        m_cols[0] = d.Name;
                        m_cols[1] = "0";
                        m_cols[2] = "Directory";
                        m_cols[3] = d.CreationTime.ToString();
                    }
                }

                return notEOF;
            }

            return false;
        }

        string IDataReader.GetName(int fieldIndex)
        {
            return m_names[fieldIndex];
        }

        Type IDataReader.GetFieldType(int fieldIndex)
        {
            // Return the actual Type class for the data type.
            return m_types[fieldIndex];
        }

        object IDataReader.GetValue(int fieldIndex)
        {
            return m_cols[fieldIndex];
        }

        int IDataReader.GetOrdinal(string fieldName)
        {
            // Look for the ordinal of the column with the same name and return it.
            // Returns -1 if not found
            return Array.IndexOf(m_names, fieldName);
        }

        int IDataReader.FieldCount
        {
            // Return the count of the number of columns, which in
            // this case is the size of the column metadata
            // array.
            get { return m_fieldCount; }
        }

        void IDisposable.Dispose()
        {
        }

        /*
        * Implementation specific methods.
        */
        internal void GetDirectory(string cmdText)
        {
            ValidateCommandText(cmdText);

            m_dir = new DirectoryInfo(cmdText);
            m_fsi = m_dir.GetFileSystemInfos();

            m_currentRow = -1;
            m_ie = m_fsi.GetEnumerator();
        }

        /* The following method loosely enforces the format of the 
        * command text. This data processing extension does not 
        * support local paths, i.e. c:\.
        */
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:DoNotPassLiteralsAsLocalizedParameters", MessageId = "System.InvalidOperationException.#ctor(System.String)"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1801:AvoidUnusedParameters")]
        private void ValidateCommandText(string dir)
        {
            // Check format of command text.
            bool isValidCmd = dir.StartsWith("\\");
            if (!isValidCmd)
            {
                throw new InvalidOperationException(
                "The current CommandText does not conform to a valid UNC file share.");
            }
        }
    }
}
