/*=====================================================================

  File:      FsiCommand.cs
  
  Summary:   Represents a command.

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
using System.ComponentModel;
using Microsoft.ReportingServices.DataProcessing;
using System.Security.Principal;

namespace Microsoft.Samples.ReportingServices.FsiDataExtension
{
    public sealed class FsiCommand : IDbCommand
    {
        private FsiConnection m_connection;
        private FsiTransaction m_txn;
        private string m_cmdText;

        private FsiDataParameterCollection parameters
            = new FsiDataParameterCollection();

        public FsiCommand()
        {
            // Implement the default constructor here
        }

        // Implement other constructors here
        public FsiCommand(FsiConnection connection)
        {
            m_connection = connection;
        }

        public FsiCommand(string cmdText)
        {
            m_cmdText = cmdText;
        }

        public FsiCommand(string cmdText, FsiConnection connection)
        {
            m_cmdText = cmdText;
            m_connection = connection;
        }

        public FsiCommand(string cmdText, FsiConnection connection, FsiTransaction txn)
        {
            m_cmdText = cmdText;
            m_connection = connection;
            m_txn = txn;
        }

        /****
        * IMPLEMENT THE REQUIRED PROPERTIES.
        ****/
        string IDbCommand.CommandText
        {
            get
            {
                return m_cmdText;
            }
            set
            {
                m_cmdText = value;
            }
        }

        int IDbCommand.CommandTimeout
        {
            /*
            * The sample does not support a command time-out. 
            */
            get
            {
                return 30;
            }
            set
            {
            }
        }

        CommandType IDbCommand.CommandType
        {
            /*
            * The sample only supports CommandType.Text.
            */
            get { return CommandType.Text; }
            set { if (value != CommandType.Text) throw new NotSupportedException(); }
        }

        //FsiDataParameterCollection IDbCommand.Parameters
        //{
        //    get { return parameters; }
        //}

        IDataParameterCollection IDbCommand.Parameters
        {
            get { return parameters; }
        }

        IDbTransaction IDbCommand.Transaction
        {
            /*
            * Set the transaction. Consider additional steps to ensure that the transaction
            * is compatible with the connection, because the two are usually linked.
            */
            get { return m_txn; }
            set { m_txn = (FsiTransaction)value; }
        }

        /****
        * IMPLEMENT THE REQUIRED METHODS.
        ****/
        void IDbCommand.Cancel()
        {
            // The sample does not support canceling a command
            // once it has been initiated.
            throw new NotSupportedException();
        }

        IDataParameter IDbCommand.CreateParameter()
        {
            return (IDataParameter)(new FsiDataParameter());
        }

        IDataReader IDbCommand.ExecuteReader(CommandBehavior behavior)
        {
            /*
            * ExecuteReader should retrieve results from the data source
            * and return a DataReader that allows the user to process 
            * the results.

            * There is no CommandBehavior option supported by this
            * sample.
            */
            WindowsImpersonationContext impersonationContext = null;
            FsiDataReader reader = null;
            try
            {
                if (m_connection.ConnectionUser != null)
                {
                    impersonationContext = m_connection.ConnectionUser.Impersonate();
                }

                // Execute the command.      
                reader = new FsiDataReader(m_cmdText);
                reader.GetDirectory(m_cmdText);

            }
            finally
            {
                if (impersonationContext != null)
                {
                    impersonationContext.Dispose();
                }
            }

            return reader;
        }

        void IDisposable.Dispose()
        {
            /*
            * Dispose of the object and perform any cleanup.
            */
        }
    }
}

