/*=====================================================================

    File:      FsiConnection.cs
        
    Summary:   Represents a connection and an extension.

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
using Microsoft.ReportingServices.DataProcessing;
using Microsoft.ReportingServices.Interfaces;
using System.Security.Permissions;
using System.Security.Principal;

namespace Microsoft.Samples.ReportingServices.FsiDataExtension
{
    public sealed class FsiConnection : IDbConnectionExtension
    {
        private string m_conn;
        private System.Data.ConnectionState m_state
            = System.Data.ConnectionState.Closed;
        private string m_locName = "File Share Information";
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private string m_impersonate;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private string m_username;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private string m_password;

        private bool m_connectionOpened = false;
        private WindowsIdentity m_connectionUser = null;
        private bool m_integratedSecurity = false;

        public FsiConnection()
        {
            // This extension does not use a connection string
        }

        // Have a constructor that takes a connection string.
        public FsiConnection(string conn)
        {
            // This extension does not use a connection string
        }

        string IDbConnection.ConnectionString
        {
            get
            {
                // Always return exactly what the user set.
                // Security-sensitive information may be removed.
                return m_conn;
            }
            set
            {
                m_conn = value;
            }
        }

        int IDbConnection.ConnectionTimeout
        {
            get
            {
                // Returns the connection time-out value set in the connection
                // string. Zero indicates an indefinite time-out period.
                return 0;
            }
        }

        public System.Data.ConnectionState State
        {
            get
            {
                return m_state;
            }
        }

        IDbTransaction IDbConnection.BeginTransaction()
        {
            throw new NotSupportedException();
        }

        void IDbConnection.Open()
        {
            /*
            * Open the database connection and set the ConnectionState
            * property. If the underlying connection to the server is 
            * expensive to obtain, the implementation should provide
            * implicit pooling of that connection.
            * 
            * If the provider also supports automatic enlistment in 
            * distributed transactions, it should enlist during Open().
            */
            if (!m_connectionOpened)
            {
                if (m_integratedSecurity)
                {
                    m_connectionUser = WindowsIdentity.GetCurrent();
                }
                else
                {
                    m_connectionUser = null;
                }

                m_connectionOpened = true;
            }
        }

        void IDbConnection.Close()
        {
            /*
            * Close the database connection and set the ConnectionState
            * property. If the underlying connection to the server is
            * being pooled, Close() will release it back to the pool.
            */
            if (m_connectionUser != null)
            {
                m_connectionUser.Dispose();
            }
            m_connectionOpened = false;
        }

        IDbCommand IDbConnection.CreateCommand()
        {
            // Return a new instance of a command object.
            return new FsiCommand(this);
        }

        string IExtension.LocalizedName
        {
            get
            {
                // Always return exactly what the user set.
                // Security-sensitive information may be removed.
                return m_locName;
            }
        }

        void IExtension.SetConfiguration(string configuration)
        {
            // Used to retrieve configuration data from the config file
        }

        /****
        * REQUIRED METHODS / PROPERTIES FROM IDbConnectionExtension.
        ****/
        /*
        * For data sources that require credentials, these properties
        * add support for storing secure credentials while designing
        * reports with Report Designer. The Data Source dialog will
        * include support for the Integrated checkbox as well as
        * text boxes for username and password.
        */
        bool IDbConnectionExtension.IntegratedSecurity
        {
            get
            {
                return m_integratedSecurity;
            }
            set
            {
                m_integratedSecurity = value;
            }
        }

        string IDbConnectionExtension.UserName
        {
            set
            {
                m_username = value;
            }
        }

        string IDbConnectionExtension.Password
        {
            set
            {
                m_password = value;
            }
        }

        string IDbConnectionExtension.Impersonate
        {
            set
            {
                m_impersonate = value;
            }
        }

        void IDisposable.Dispose()
        {
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes")]
        internal WindowsIdentity ConnectionUser
        {
            get
            {
                // m_connectionUser is valid only during open connection
                if (!m_connectionOpened)
                {
                    throw new Exception(Properties.Resources.ConnectionNotOpen);
                }
                return m_connectionUser;
            }
        }
    }
}
