/*=====================================================================

  File:      FsiDataParameter.cs
  
  Summary:   Represents a parameter to a query.

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

namespace Microsoft.Samples.ReportingServices.FsiDataExtension
{
    public sealed class FsiDataParameter : IDataParameter
    {
        private string m_paramName;
        private object m_value;

        public FsiDataParameter()
        {
        }

        public FsiDataParameter(string parameterName, object value)
        {
            this.m_paramName = parameterName;
            this.m_value = value;
            // Setting the value also infers the type
        }

        string IDataParameter.ParameterName
        {
            get
            {
                return this.m_paramName;
            }
            set
            {
                this.m_paramName = value;
            }
        }

        object IDataParameter.Value
        {
            get
            {
                return this.m_value;
            }
            set
            {
                this.m_value = value;
            }
        }
    }
}
