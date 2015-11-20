#region "Copyright Microsoft Corporation. All rights reserved."
/*=============================================================================
  Summary:  Demonstrates an implementation of a Form that can
            be used to render a report via the Reporting Services
            Web service using asychronous Web service calls.
      
---------------------------------------------------------------------
  This file is part of Microsoft SQL Server Code Samples.
  
 This source code is intended only as a supplement to Microsoft
 Development Tools and/or on-line documentation.  See these other
 materials for detailed information regarding Microsoft code samples.

 THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
 KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
 IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
 PARTICULAR PURPOSE.
==============================================================================*/
#endregion
#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using rsService = Microsoft.SqlServer.ReportingServices.ReportService2005;
using rsExecService = Microsoft.SqlServer.ReportingServices.ReportExecutionService;
using Microsoft.Samples.ReportingServices.AsynchronousRender.Properties;
using System.Globalization;

#endregion

namespace Microsoft.Samples.ReportingServices.AsynchronousRender
{
    partial class AsynchRender : Form
    {
		private rsService.ReportingService2005 rs;
        private rsExecService.ReportExecutionService rsExec;

        private DateTime start;
        TreeNode rootTreeNode;
        string reportName;
        string renderFileName = string.Empty;

		private string MHTML = String.Format(CultureInfo.InvariantCulture,
					Properties.Resources.WebPageFormat);

        public AsynchRender()
        {
            InitializeComponent();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
        private void CreateProxy()
        {
            try
            {
                rs = new rsService.ReportingService2005();

                rs.Url = serverTextBox.Text + "ReportService2005.asmx";
                rs.Credentials = System.Net.CredentialCache.DefaultCredentials;

                rsExec = new rsExecService.ReportExecutionService();
                rsExec.Url = serverTextBox.Text + "ReportExecution2005.asmx";
                rsExec.Credentials = System.Net.CredentialCache.DefaultCredentials;
                rsExec.RenderCompleted += new rsExecService.RenderCompletedEventHandler(this.RenderCompletedHandler);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(CultureInfo.InvariantCulture, ex.Message));
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions")]
        private void renderButton_Click(object sender, EventArgs e)
        {
            if (catalogTreeView.SelectedNode == null ||
				catalogTreeView.SelectedNode.ImageIndex == 0 ||
				catalogTreeView.SelectedNode.ImageIndex == 3)
            {
                MessageBox.Show(string.Format(CultureInfo.InvariantCulture,
                    Properties.Resources.SelectReport));
            }
            else
            {
                if (catalogTreeView.SelectedNode.ImageIndex != 0)
                {
                    // If the report uses parameters for which there is no default
                    // value, then the report cannot be rendered and saved by this
                    // application
                    bool hasDefaultValue = ParametersHaveDefaultValue((string)catalogTreeView.SelectedNode.Tag);

                    if (!hasDefaultValue)
                    {
                        MessageBox.Show(
                            Resources.RenderingNotSupported,
                            Resources.genericErrorMessageBoxTitle,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                    }
                    else
                    {
                        RenderReport();
                    }
                }
            }
        }

        private bool ParametersHaveDefaultValue(string path)
        {
            bool haveDefaultValue = true;
            bool forRendering = false;
            string historyID = null;
            rsService.ParameterValue[] values = null;
            rsService.DataSourceCredentials[] credentials = null;
            rsService.ReportParameter[] parameters = null;

            parameters = rs.GetReportParameters(path, historyID, forRendering, values, credentials);

            foreach (rsService.ReportParameter parameter in parameters)
            {
                if (parameter.DefaultValues == null)
                {
                    haveDefaultValue = false;
                    break;
                }
            }

            return haveDefaultValue;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1804:RemoveUnusedLocals", MessageId = "SessionId"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
        private void RenderReport()
        {
            // Render arguments
            string reportPath = (string)catalogTreeView.SelectedNode.Tag;
            reportName = catalogTreeView.SelectedNode.Text;
			string format = "MHTML";
            string devInfo = null;
			string historyID = null;
			rsExecService.ExecutionHeader execHeader = new rsExecService.ExecutionHeader();
			rsExec.ExecutionHeaderValue = execHeader;

			try
			{
				rsExec.LoadReport(reportPath, historyID);

				String SessionId = rsExec.ExecutionHeaderValue.ExecutionID;
				
				saveReportDialog = new SaveFileDialog();
				saveReportDialog.Filter = MHTML;
				saveReportDialog.FileName = reportName;

				DialogResult dr = saveReportDialog.ShowDialog();

				if (dr == DialogResult.OK)
				{
					renderFileName = saveReportDialog.FileName;

					start = DateTime.Now;
					statusTimer.Start();

					rsExec.RenderAsync(format, devInfo);

					rsExec.GetExecutionInfo();

				}
				else
				{
					statusTimer.Stop();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format(CultureInfo.InvariantCulture, ex.Message));
			}
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
        private void RenderCompletedHandler(object sender, rsExecService.RenderCompletedEventArgs arg)
        {
            statusTimer.Stop();
            
            try
            {	
                SaveReport(arg.Result, renderFileName);
            }
            catch (Exception)
            {
				MessageBox.Show(String.Format(CultureInfo.InvariantCulture,
                    Properties.Resources.genericErrorMessage));
            }
        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        private void SaveReport(byte[] results, string location)
        {
            // Create a file stream and write the report to it
            FileStream stream = File.OpenWrite(location);
            stream.Write(results, 0, results.Length);
            stream.Close();
        }

        private void statusTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now.Subtract(start);
            TimeSpan formattedShortTime = new TimeSpan(elapsedTime.Hours, elapsedTime.Minutes, elapsedTime.Seconds);


			statusTextBox.Text = String.Format(CultureInfo.InvariantCulture, Properties.Resources.renderingReportText
				+ " ({0})", + formattedShortTime);
        }

        // Method to add child nodes to a selected node
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:DoNotPassLiteralsAsLocalizedParameters", MessageId = "System.Windows.Forms.TreeNode.set_Text(System.String)"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
        private void AddChildNodes(TreeNode currentNode)
        {
            // If the node is not a folder, don't call ListChildren
            if (currentNode.ImageIndex != 0)
            {
                return;
            }

            // List the children of the current report server folder item
            try
            {
                rsService.CatalogItem[] items = rs.ListChildren(currentNode.Tag.ToString(), false);
                // For each item, add node to the current node
                foreach (rsService.CatalogItem ci in items)
                {
                    rsService.ItemTypeEnum type = ci.Type;
                    TreeNode newNode = new TreeNode();
                    newNode.Text = ci.Name;
                    newNode.Tag = (object)ci.Path;
                    newNode.ImageIndex = GetItemTypeIndex(type);
                    newNode.SelectedImageIndex = newNode.ImageIndex;

                    currentNode.Nodes.Add(newNode);
                    AddChildNodes(newNode);
                }
            }
            catch (Exception)
            {
                rootTreeNode.Text = "Connection error";
            }
        }

        // Method to retrive images for the different node types
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        private int GetItemTypeIndex(rsService.ItemTypeEnum type)
        {
            int index = 2;
            switch (type)
            {
				case rsService.ItemTypeEnum.Folder:
                    index = 0;
                    break;
				case rsService.ItemTypeEnum.DataSource:
                    index = 3;
                    break;
				case rsService.ItemTypeEnum.LinkedReport:
                    index = 1;
                    break;
				case rsService.ItemTypeEnum.Report:
                    index = 1;
                    break;
				case rsService.ItemTypeEnum.Resource:
                    index = 2;
                    break;
                default:
                    break;
            }

            return index;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:DoNotPassLiteralsAsLocalizedParameters", MessageId = "System.Windows.Forms.TreeNode.set_Text(System.String)"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:DoNotPassLiteralsAsLocalizedParameters", MessageId = "System.Windows.Forms.Control.set_Text(System.String)")]
        private void connectButton_Click(object sender, EventArgs e)
        {
            catalogTreeView.Nodes.Clear();
            Cursor.Current = Cursors.WaitCursor;
            CreateProxy();
            rootTreeNode = new TreeNode();
            rootTreeNode.Text = "Home";
            rootTreeNode.Tag = (object)"/";
            rootTreeNode.ImageIndex = 0;
            rootTreeNode.SelectedImageIndex = 0;
            catalogTreeView.Nodes.Add(rootTreeNode);
            AddChildNodes(rootTreeNode);
            renderButton.Enabled = true;
            Cursor.Current = Cursors.Default;
            connectButton.Text = "Refresh";
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:DoNotPassLiteralsAsLocalizedParameters", MessageId = "System.Windows.Forms.Control.set_Text(System.String)")]
        private void AsynchRender_Load(object sender, EventArgs e)
        {
            serverTextBox.Text = "http://localhost/ReportServer/";
        }
    }
}