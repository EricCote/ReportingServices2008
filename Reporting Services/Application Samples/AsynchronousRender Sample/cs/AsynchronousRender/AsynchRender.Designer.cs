#region "Copyright © 2004 Microsoft Corporation. All rights reserved."
/*=============================================================================
  File:      AsynchRender.Designer.cs

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
namespace Microsoft.Samples.ReportingServices.AsynchronousRender
{
    partial class AsynchRender
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Mobility", "CA1601:DoNotUseTimersThatPreventPowerStateChanges")]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsynchRender));
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.renderButton = new System.Windows.Forms.Button();
            this.catalogTreeView = new System.Windows.Forms.TreeView();
            this.treeNodeImageList = new System.Windows.Forms.ImageList(this.components);
            this.statusTimer = new System.Windows.Forms.Timer(this.components);
            this.saveReportDialog = new System.Windows.Forms.SaveFileDialog();
            this.connectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // statusTextBox
            // 
            this.statusTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.statusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.statusTextBox, "statusTextBox");
            this.statusTextBox.Name = "statusTextBox";
            // 
            // statusLabel
            // 
            resources.ApplyResources(this.statusLabel, "statusLabel");
            this.statusLabel.Name = "statusLabel";
            // 
            // infoLabel
            // 
            resources.ApplyResources(this.infoLabel, "infoLabel");
            this.infoLabel.Name = "infoLabel";
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.Name = "exitButton";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // renderButton
            // 
            resources.ApplyResources(this.renderButton, "renderButton");
            this.renderButton.Name = "renderButton";
            this.renderButton.Click += new System.EventHandler(this.renderButton_Click);
            // 
            // catalogTreeView
            // 
            resources.ApplyResources(this.catalogTreeView, "catalogTreeView");
            this.catalogTreeView.ImageList = this.treeNodeImageList;
            this.catalogTreeView.Name = "catalogTreeView";
            // 
            // treeNodeImageList
            // 
            this.treeNodeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeNodeImageList.ImageStream")));
            this.treeNodeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.treeNodeImageList.Images.SetKeyName(0, "");
            this.treeNodeImageList.Images.SetKeyName(1, "");
            this.treeNodeImageList.Images.SetKeyName(2, "");
            this.treeNodeImageList.Images.SetKeyName(3, "");
            // 
            // statusTimer
            // 
            this.statusTimer.Interval = 500;
            this.statusTimer.Tick += new System.EventHandler(this.statusTimer_Tick);
            // 
            // connectButton
            // 
            resources.ApplyResources(this.connectButton, "connectButton");
            this.connectButton.Name = "connectButton";
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // serverTextBox
            // 
            resources.ApplyResources(this.serverTextBox, "serverTextBox");
            this.serverTextBox.Name = "serverTextBox";
            // 
            // AsynchRender
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.serverTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.catalogTreeView);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.renderButton);
            this.Name = "AsynchRender";
            this.Load += new System.EventHandler(this.AsynchRender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button renderButton;
        private System.Windows.Forms.Timer statusTimer;
        private System.Windows.Forms.SaveFileDialog saveReportDialog;
        private System.Windows.Forms.TreeView catalogTreeView;
        private System.Windows.Forms.ImageList treeNodeImageList;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serverTextBox;
    }
}