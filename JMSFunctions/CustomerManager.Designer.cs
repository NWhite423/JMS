namespace JMS
{
    partial class CustomerManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerManager));
            this.TVCustomers = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAddress1 = new System.Windows.Forms.TextBox();
            this.TxtAddress2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.CmdCreatePOI = new System.Windows.Forms.Button();
            this.CmdCreateCompany = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdModify = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TVCustomers
            // 
            this.TVCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TVCustomers.Location = new System.Drawing.Point(3, 35);
            this.TVCustomers.Name = "TVCustomers";
            this.TVCustomers.ShowNodeToolTips = true;
            this.TVCustomers.Size = new System.Drawing.Size(258, 285);
            this.TVCustomers.TabIndex = 0;
            this.TVCustomers.DoubleClick += new System.EventHandler(this.TVCustomers_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // TxtName
            // 
            this.TxtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtName.Location = new System.Drawing.Point(322, 6);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(422, 23);
            this.TxtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address:";
            // 
            // TxtAddress1
            // 
            this.TxtAddress1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAddress1.Location = new System.Drawing.Point(337, 35);
            this.TxtAddress1.Name = "TxtAddress1";
            this.TxtAddress1.Size = new System.Drawing.Size(407, 23);
            this.TxtAddress1.TabIndex = 4;
            // 
            // TxtAddress2
            // 
            this.TxtAddress2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAddress2.Location = new System.Drawing.Point(337, 64);
            this.TxtAddress2.Name = "TxtAddress2";
            this.TxtAddress2.Size = new System.Drawing.Size(407, 23);
            this.TxtAddress2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone:";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(326, 93);
            this.TxtPhone.Mask = "(999) 000-0000";
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(111, 23);
            this.TxtPhone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "E-Mail:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEmail.Location = new System.Drawing.Point(500, 93);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(244, 23);
            this.TxtEmail.TabIndex = 9;
            // 
            // CmdCreatePOI
            // 
            this.CmdCreatePOI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdCreatePOI.Location = new System.Drawing.Point(574, 122);
            this.CmdCreatePOI.Name = "CmdCreatePOI";
            this.CmdCreatePOI.Size = new System.Drawing.Size(170, 28);
            this.CmdCreatePOI.TabIndex = 10;
            this.CmdCreatePOI.Text = "Create as POC";
            this.CmdCreatePOI.UseVisualStyleBackColor = true;
            this.CmdCreatePOI.Click += new System.EventHandler(this.CmdCreatePOI_Click);
            // 
            // CmdCreateCompany
            // 
            this.CmdCreateCompany.Location = new System.Drawing.Point(270, 122);
            this.CmdCreateCompany.Name = "CmdCreateCompany";
            this.CmdCreateCompany.Size = new System.Drawing.Size(170, 28);
            this.CmdCreateCompany.TabIndex = 11;
            this.CmdCreateCompany.Text = "Create as Company";
            this.CmdCreateCompany.UseVisualStyleBackColor = true;
            this.CmdCreateCompany.Click += new System.EventHandler(this.CmdCreateCompany_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdDelete.Location = new System.Drawing.Point(3, 326);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(112, 28);
            this.CmdDelete.TabIndex = 13;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdSave.Location = new System.Drawing.Point(654, 326);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(90, 28);
            this.CmdSave.TabIndex = 14;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdCancel.Location = new System.Drawing.Point(270, 326);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(90, 28);
            this.CmdCancel.TabIndex = 15;
            this.CmdCancel.Text = "Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdModify
            // 
            this.CmdModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdModify.Location = new System.Drawing.Point(149, 326);
            this.CmdModify.Name = "CmdModify";
            this.CmdModify.Size = new System.Drawing.Size(112, 28);
            this.CmdModify.TabIndex = 16;
            this.CmdModify.Text = "Modify";
            this.CmdModify.UseVisualStyleBackColor = true;
            this.CmdModify.Click += new System.EventHandler(this.TVCustomers_DoubleClick);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(3, 12);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(258, 23);
            this.TxtSearch.TabIndex = 17;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(267, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(477, 167);
            this.label5.TabIndex = 18;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // CustomerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 363);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.CmdModify);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdCreateCompany);
            this.Controls.Add(this.CmdCreatePOI);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAddress2);
            this.Controls.Add(this.TxtAddress1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TVCustomers);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerManager";
            this.Text = "CustomerManagers";
            this.Load += new System.EventHandler(this.CustomerManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TVCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAddress1;
        private System.Windows.Forms.TextBox TxtAddress2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox TxtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button CmdCreatePOI;
        private System.Windows.Forms.Button CmdCreateCompany;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.Button CmdModify;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label5;
    }
}