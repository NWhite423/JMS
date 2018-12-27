namespace JobCreationTool
{
    partial class LandingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingForm));
            this.label1 = new System.Windows.Forms.Label();
            this.LblJobNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtJobName = new System.Windows.Forms.TextBox();
            this.CbUseJobNumber = new System.Windows.Forms.CheckBox();
            this.CmdCreate = new System.Windows.Forms.Button();
            this.CBList = new System.Windows.Forms.CheckedListBox();
            this.CmdCheckAll = new System.Windows.Forms.Button();
            this.CmdUncheckAll = new System.Windows.Forms.Button();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.FdBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.cmdRemove = new System.Windows.Forms.Button();
            this.LblAddress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAddressLine1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAddressLine2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CBTasks = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CmdAddRep = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.CBEmployees = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.DateTimeDue = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.TVContacts = new System.Windows.Forms.TreeView();
            this.CmdDeleteRep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job Number:";
            // 
            // LblJobNumber
            // 
            this.LblJobNumber.AutoSize = true;
            this.LblJobNumber.Location = new System.Drawing.Point(12, 29);
            this.LblJobNumber.Name = "LblJobNumber";
            this.LblJobNumber.Size = new System.Drawing.Size(118, 20);
            this.LblJobNumber.TabIndex = 4;
            this.LblJobNumber.Text = "XXXX-XX-XXX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Job Name:";
            // 
            // TxtJobName
            // 
            this.TxtJobName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtJobName.Location = new System.Drawing.Point(12, 102);
            this.TxtJobName.Name = "TxtJobName";
            this.TxtJobName.Size = new System.Drawing.Size(600, 26);
            this.TxtJobName.TabIndex = 1;
            // 
            // CbUseJobNumber
            // 
            this.CbUseJobNumber.AutoSize = true;
            this.CbUseJobNumber.Checked = true;
            this.CbUseJobNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbUseJobNumber.Location = new System.Drawing.Point(16, 52);
            this.CbUseJobNumber.Name = "CbUseJobNumber";
            this.CbUseJobNumber.Size = new System.Drawing.Size(147, 24);
            this.CbUseJobNumber.TabIndex = 7;
            this.CbUseJobNumber.TabStop = false;
            this.CbUseJobNumber.Text = "Use Job Number";
            this.CbUseJobNumber.UseVisualStyleBackColor = true;
            // 
            // CmdCreate
            // 
            this.CmdCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdCreate.Location = new System.Drawing.Point(12, 747);
            this.CmdCreate.Name = "CmdCreate";
            this.CmdCreate.Size = new System.Drawing.Size(600, 26);
            this.CmdCreate.TabIndex = 10;
            this.CmdCreate.Text = "Create Job";
            this.CmdCreate.UseVisualStyleBackColor = true;
            this.CmdCreate.Click += new System.EventHandler(this.CmdCreate_Click);
            // 
            // CBList
            // 
            this.CBList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBList.FormattingEnabled = true;
            this.CBList.Location = new System.Drawing.Point(12, 628);
            this.CBList.Name = "CBList";
            this.CBList.Size = new System.Drawing.Size(600, 109);
            this.CBList.TabIndex = 5;
            this.CBList.SelectedIndexChanged += new System.EventHandler(this.CBList_SelectedIndexChanged);
            // 
            // CmdCheckAll
            // 
            this.CmdCheckAll.Location = new System.Drawing.Point(12, 596);
            this.CmdCheckAll.Name = "CmdCheckAll";
            this.CmdCheckAll.Size = new System.Drawing.Size(75, 26);
            this.CmdCheckAll.TabIndex = 9;
            this.CmdCheckAll.Text = "✓ ALL";
            this.CmdCheckAll.UseVisualStyleBackColor = true;
            this.CmdCheckAll.Click += new System.EventHandler(this.CmdCheckAll_Click);
            // 
            // CmdUncheckAll
            // 
            this.CmdUncheckAll.Location = new System.Drawing.Point(93, 596);
            this.CmdUncheckAll.Name = "CmdUncheckAll";
            this.CmdUncheckAll.Size = new System.Drawing.Size(75, 26);
            this.CmdUncheckAll.TabIndex = 3;
            this.CmdUncheckAll.TabStop = false;
            this.CmdUncheckAll.Text = "☐ ALL";
            this.CmdUncheckAll.UseVisualStyleBackColor = true;
            this.CmdUncheckAll.Click += new System.EventHandler(this.CmdUncheckAll_Click);
            // 
            // CmdAdd
            // 
            this.CmdAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdAdd.Location = new System.Drawing.Point(584, 596);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.Size = new System.Drawing.Size(26, 26);
            this.CmdAdd.TabIndex = 12;
            this.CmdAdd.TabStop = false;
            this.CmdAdd.Text = "+";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // cmdRemove
            // 
            this.cmdRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRemove.Enabled = false;
            this.cmdRemove.Location = new System.Drawing.Point(552, 596);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(26, 26);
            this.cmdRemove.TabIndex = 13;
            this.cmdRemove.TabStop = false;
            this.cmdRemove.Text = "-";
            this.cmdRemove.UseVisualStyleBackColor = true;
            this.cmdRemove.Click += new System.EventHandler(this.Button1_Click);
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(12, 131);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(68, 20);
            this.LblAddress.TabIndex = 14;
            this.LblAddress.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Line 1:";
            // 
            // TxtAddressLine1
            // 
            this.TxtAddressLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAddressLine1.Location = new System.Drawing.Point(74, 154);
            this.TxtAddressLine1.Name = "TxtAddressLine1";
            this.TxtAddressLine1.Size = new System.Drawing.Size(538, 26);
            this.TxtAddressLine1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Line 2:";
            // 
            // TxtAddressLine2
            // 
            this.TxtAddressLine2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAddressLine2.Location = new System.Drawing.Point(74, 186);
            this.TxtAddressLine2.Name = "TxtAddressLine2";
            this.TxtAddressLine2.Size = new System.Drawing.Size(538, 26);
            this.TxtAddressLine2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tasks";
            // 
            // CBTasks
            // 
            this.CBTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBTasks.FormattingEnabled = true;
            this.CBTasks.Items.AddRange(new object[] {
            "Boundary",
            "Topographic",
            "Pre-Construction",
            "Construction",
            "As-Built",
            "ALTA",
            "Elevation Certificate"});
            this.CBTasks.Location = new System.Drawing.Point(12, 461);
            this.CBTasks.Name = "CBTasks";
            this.CBTasks.Size = new System.Drawing.Size(289, 109);
            this.CBTasks.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 573);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Sub-Folders";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Point of Contact(s)";
            // 
            // CmdAddRep
            // 
            this.CmdAddRep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdAddRep.Location = new System.Drawing.Point(537, 285);
            this.CmdAddRep.Name = "CmdAddRep";
            this.CmdAddRep.Size = new System.Drawing.Size(75, 26);
            this.CmdAddRep.TabIndex = 6;
            this.CmdAddRep.Text = "Add";
            this.CmdAddRep.UseVisualStyleBackColor = true;
            this.CmdAddRep.Click += new System.EventHandler(this.CmdAddRep_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Price:";
            // 
            // CBEmployees
            // 
            this.CBEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBEmployees.FormattingEnabled = true;
            this.CBEmployees.Location = new System.Drawing.Point(321, 461);
            this.CBEmployees.Name = "CBEmployees";
            this.CBEmployees.Size = new System.Drawing.Size(289, 109);
            this.CBEmployees.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(317, 438);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Employees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Due Date:";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(66, 218);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(123, 26);
            this.TxtPrice.TabIndex = 4;
            // 
            // DateTimeDue
            // 
            this.DateTimeDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeDue.Location = new System.Drawing.Point(502, 218);
            this.DateTimeDue.Name = "DateTimeDue";
            this.DateTimeDue.Size = new System.Drawing.Size(110, 26);
            this.DateTimeDue.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(443, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Default now + 1 month";
            // 
            // TVContacts
            // 
            this.TVContacts.Location = new System.Drawing.Point(12, 311);
            this.TVContacts.Name = "TVContacts";
            this.TVContacts.Size = new System.Drawing.Size(600, 124);
            this.TVContacts.TabIndex = 34;
            // 
            // CmdDeleteRep
            // 
            this.CmdDeleteRep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdDeleteRep.Enabled = false;
            this.CmdDeleteRep.Location = new System.Drawing.Point(456, 285);
            this.CmdDeleteRep.Name = "CmdDeleteRep";
            this.CmdDeleteRep.Size = new System.Drawing.Size(75, 26);
            this.CmdDeleteRep.TabIndex = 35;
            this.CmdDeleteRep.Text = "Delete";
            this.CmdDeleteRep.UseVisualStyleBackColor = true;
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(624, 781);
            this.Controls.Add(this.CmdDeleteRep);
            this.Controls.Add(this.TVContacts);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DateTimeDue);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CBEmployees);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CmdAddRep);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CBTasks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtAddressLine2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtAddressLine1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.cmdRemove);
            this.Controls.Add(this.CmdAdd);
            this.Controls.Add(this.CmdUncheckAll);
            this.Controls.Add(this.CmdCheckAll);
            this.Controls.Add(this.CBList);
            this.Controls.Add(this.CmdCreate);
            this.Controls.Add(this.CbUseJobNumber);
            this.Controls.Add(this.TxtJobName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblJobNumber);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 670);
            this.Name = "LandingForm";
            this.Text = "Job Creation Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LandingForm_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog FdBrowser;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TxtAddressLine1;
        public System.Windows.Forms.TextBox TxtAddressLine2;
        public System.Windows.Forms.CheckedListBox CBTasks;
        public System.Windows.Forms.TextBox TxtJobName;
        public System.Windows.Forms.CheckedListBox CBList;
        public System.Windows.Forms.Label LblJobNumber;
        public System.Windows.Forms.CheckBox CbUseJobNumber;
        public System.Windows.Forms.Button CmdCreate;
        public System.Windows.Forms.Button CmdCheckAll;
        public System.Windows.Forms.Button CmdUncheckAll;
        public System.Windows.Forms.Button CmdAdd;
        public System.Windows.Forms.Button cmdRemove;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button CmdAddRep;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.CheckedListBox CBEmployees;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtPrice;
        public System.Windows.Forms.DateTimePicker DateTimeDue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TreeView TVContacts;
        public System.Windows.Forms.Button CmdDeleteRep;
    }
}

