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
            this.SCMain = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.CmdAdvSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SCMain)).BeginInit();
            this.SCMain.Panel1.SuspendLayout();
            this.SCMain.SuspendLayout();
            this.SuspendLayout();
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
            this.MS.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MS.Size = new System.Drawing.Size(642, 24);
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
            // SCMain
            // 
            this.SCMain.BackColor = System.Drawing.SystemColors.Window;
            this.SCMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SCMain.Location = new System.Drawing.Point(0, 24);
            this.SCMain.Name = "SCMain";
            // 
            // SCMain.Panel1
            // 
            this.SCMain.Panel1.Controls.Add(this.textBox1);
            this.SCMain.Panel1.Controls.Add(this.CmdAdvSearch);
            this.SCMain.Panel1.Controls.Add(this.comboBox2);
            this.SCMain.Panel1.Controls.Add(this.comboBox1);
            this.SCMain.Panel1.Controls.Add(this.panel1);
            this.SCMain.Size = new System.Drawing.Size(642, 411);
            this.SCMain.SplitterDistance = 230;
            this.SCMain.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(3, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 352);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 25);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(115, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(113, 25);
            this.comboBox2.TabIndex = 2;
            // 
            // CmdAdvSearch
            // 
            this.CmdAdvSearch.BackColor = System.Drawing.SystemColors.Window;
            this.CmdAdvSearch.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAdvSearch.Location = new System.Drawing.Point(162, 29);
            this.CmdAdvSearch.Name = "CmdAdvSearch";
            this.CmdAdvSearch.Size = new System.Drawing.Size(66, 25);
            this.CmdAdvSearch.TabIndex = 3;
            this.CmdAdvSearch.Text = "Options";
            this.CmdAdvSearch.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(3, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 25);
            this.textBox1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 435);
            this.Controls.Add(this.SCMain);
            this.Controls.Add(this.MS);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.SCMain.Panel1.ResumeLayout(false);
            this.SCMain.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SCMain)).EndInit();
            this.SCMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MS;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deadlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
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
        private System.Windows.Forms.SplitContainer SCMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CmdAdvSearch;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

