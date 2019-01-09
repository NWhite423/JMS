﻿namespace JMS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LBJobs = new System.Windows.Forms.ListBox();
            this.CmbDirectories = new System.Windows.Forms.ComboBox();
            this.TxtSearchResults = new System.Windows.Forms.TextBox();
            this.CmdFilter = new System.Windows.Forms.Button();
            this.MS = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.makeASuggestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deadlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testEMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showJobInformationV2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.CBMonth = new System.Windows.Forms.ComboBox();
            this.CmdSearchClear = new System.Windows.Forms.Button();
            this.MS.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBJobs
            // 
            this.LBJobs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBJobs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBJobs.FormattingEnabled = true;
            this.LBJobs.ItemHeight = 16;
            this.LBJobs.Location = new System.Drawing.Point(16, 120);
            this.LBJobs.Margin = new System.Windows.Forms.Padding(4);
            this.LBJobs.Name = "LBJobs";
            this.LBJobs.Size = new System.Drawing.Size(317, 274);
            this.LBJobs.Sorted = true;
            this.LBJobs.TabIndex = 0;
            this.LBJobs.SelectedIndexChanged += new System.EventHandler(this.LBJobs_SelectedIndexChanged);
            // 
            // CmbDirectories
            // 
            this.CmbDirectories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDirectories.FormattingEnabled = true;
            this.CmbDirectories.Location = new System.Drawing.Point(16, 36);
            this.CmbDirectories.Margin = new System.Windows.Forms.Padding(4);
            this.CmbDirectories.Name = "CmbDirectories";
            this.CmbDirectories.Size = new System.Drawing.Size(317, 24);
            this.CmbDirectories.TabIndex = 1;
            this.CmbDirectories.SelectedIndexChanged += new System.EventHandler(this.CmbDirectories_SelectedIndexChanged);
            // 
            // TxtSearchResults
            // 
            this.TxtSearchResults.Enabled = false;
            this.TxtSearchResults.Location = new System.Drawing.Point(16, 88);
            this.TxtSearchResults.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSearchResults.Name = "TxtSearchResults";
            this.TxtSearchResults.Size = new System.Drawing.Size(239, 23);
            this.TxtSearchResults.TabIndex = 2;
            // 
            // CmdFilter
            // 
            this.CmdFilter.Location = new System.Drawing.Point(275, 88);
            this.CmdFilter.Margin = new System.Windows.Forms.Padding(4);
            this.CmdFilter.Name = "CmdFilter";
            this.CmdFilter.Size = new System.Drawing.Size(60, 24);
            this.CmdFilter.TabIndex = 3;
            this.CmdFilter.Text = "Filter";
            this.CmdFilter.UseVisualStyleBackColor = true;
            this.CmdFilter.Click += new System.EventHandler(this.CmdFilter_Click);
            // 
            // MS
            // 
            this.MS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.newToolStripMenuItem,
            this.databasesToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.testingToolStripMenuItem});
            this.MS.Location = new System.Drawing.Point(0, 0);
            this.MS.Name = "MS";
            this.MS.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MS.Size = new System.Drawing.Size(734, 24);
            this.MS.TabIndex = 4;
            this.MS.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.refreshJobsToolStripMenuItem,
            this.toolStripSeparator1,
            this.makeASuggestionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // refreshJobsToolStripMenuItem
            // 
            this.refreshJobsToolStripMenuItem.Name = "refreshJobsToolStripMenuItem";
            this.refreshJobsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.refreshJobsToolStripMenuItem.Text = "Refresh Jobs";
            this.refreshJobsToolStripMenuItem.Click += new System.EventHandler(this.RefreshJobsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(171, 6);
            // 
            // makeASuggestionToolStripMenuItem
            // 
            this.makeASuggestionToolStripMenuItem.Name = "makeASuggestionToolStripMenuItem";
            this.makeASuggestionToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.makeASuggestionToolStripMenuItem.Text = "Make a Suggestion";
            this.makeASuggestionToolStripMenuItem.Visible = false;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jobToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "New";
            // 
            // jobToolStripMenuItem
            // 
            this.jobToolStripMenuItem.Name = "jobToolStripMenuItem";
            this.jobToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.jobToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.jobToolStripMenuItem.Text = "Job";
            this.jobToolStripMenuItem.Click += new System.EventHandler(this.JobToolStripMenuItem_Click);
            // 
            // databasesToolStripMenuItem
            // 
            this.databasesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.employeesToolStripMenuItem});
            this.databasesToolStripMenuItem.Name = "databasesToolStripMenuItem";
            this.databasesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.databasesToolStripMenuItem.Text = "Databases";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.CustomersToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.employeesToolStripMenuItem.Text = "Employees";
            this.employeesToolStripMenuItem.Visible = false;
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem,
            this.deadlineToolStripMenuItem,
            this.monthyToolStripMenuItem,
            this.customToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Visible = false;
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.SalesToolStripMenuItem_Click);
            // 
            // deadlineToolStripMenuItem
            // 
            this.deadlineToolStripMenuItem.Name = "deadlineToolStripMenuItem";
            this.deadlineToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.deadlineToolStripMenuItem.Text = "Deadline";
            this.deadlineToolStripMenuItem.Click += new System.EventHandler(this.DeadlineToolStripMenuItem_Click);
            // 
            // monthyToolStripMenuItem
            // 
            this.monthyToolStripMenuItem.Name = "monthyToolStripMenuItem";
            this.monthyToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.monthyToolStripMenuItem.Text = "Monthy";
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.customToolStripMenuItem.Text = "Custom";
            // 
            // testingToolStripMenuItem
            // 
            this.testingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testEMailToolStripMenuItem,
            this.showJobInformationV2ToolStripMenuItem});
            this.testingToolStripMenuItem.Name = "testingToolStripMenuItem";
            this.testingToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.testingToolStripMenuItem.Text = "Testing";
            // 
            // testEMailToolStripMenuItem
            // 
            this.testEMailToolStripMenuItem.Name = "testEMailToolStripMenuItem";
            this.testEMailToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.testEMailToolStripMenuItem.Text = "Test E-Mail";
            this.testEMailToolStripMenuItem.Visible = false;
            this.testEMailToolStripMenuItem.Click += new System.EventHandler(this.TestEMailToolStripMenuItem_Click);
            // 
            // showJobInformationV2ToolStripMenuItem
            // 
            this.showJobInformationV2ToolStripMenuItem.Name = "showJobInformationV2ToolStripMenuItem";
            this.showJobInformationV2ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.showJobInformationV2ToolStripMenuItem.Text = "Show Job Information V2";
            this.showJobInformationV2ToolStripMenuItem.Click += new System.EventHandler(this.ShowJobInformationV2ToolStripMenuItem_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.AutoScroll = true;
            this.MainPanel.Location = new System.Drawing.Point(342, 36);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(380, 365);
            this.MainPanel.TabIndex = 5;
            // 
            // CBMonth
            // 
            this.CBMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMonth.FormattingEnabled = true;
            this.CBMonth.Items.AddRange(new object[] {
            "All",
            "Janurary",
            "Feburary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.CBMonth.Location = new System.Drawing.Point(16, 62);
            this.CBMonth.Margin = new System.Windows.Forms.Padding(4);
            this.CBMonth.Name = "CBMonth";
            this.CBMonth.Size = new System.Drawing.Size(317, 24);
            this.CBMonth.TabIndex = 6;
            this.CBMonth.SelectedIndexChanged += new System.EventHandler(this.CBMonth_SelectedIndexChanged);
            // 
            // CmdSearchClear
            // 
            this.CmdSearchClear.Location = new System.Drawing.Point(255, 88);
            this.CmdSearchClear.Margin = new System.Windows.Forms.Padding(4);
            this.CmdSearchClear.Name = "CmdSearchClear";
            this.CmdSearchClear.Size = new System.Drawing.Size(22, 24);
            this.CmdSearchClear.TabIndex = 7;
            this.CmdSearchClear.Text = "X";
            this.CmdSearchClear.UseVisualStyleBackColor = true;
            this.CmdSearchClear.Click += new System.EventHandler(this.CmdSearchClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 409);
            this.Controls.Add(this.CmdSearchClear);
            this.Controls.Add(this.CBMonth);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.CmdFilter);
            this.Controls.Add(this.TxtSearchResults);
            this.Controls.Add(this.CmbDirectories);
            this.Controls.Add(this.LBJobs);
            this.Controls.Add(this.MS);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MS;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "JMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.MS.ResumeLayout(false);
            this.MS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CmdFilter;
        private System.Windows.Forms.MenuStrip MS;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        public System.Windows.Forms.ListBox LBJobs;
        public System.Windows.Forms.ComboBox CmbDirectories;
        public System.Windows.Forms.TextBox TxtSearchResults;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobToolStripMenuItem;
        public System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deadlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        public System.Windows.Forms.ComboBox CBMonth;
        private System.Windows.Forms.Button CmdSearchClear;
        private System.Windows.Forms.ToolStripMenuItem testingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testEMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeASuggestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshJobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showJobInformationV2ToolStripMenuItem;
    }
}

