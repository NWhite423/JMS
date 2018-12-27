namespace JMS
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtWorkDir = new System.Windows.Forms.TextBox();
            this.CmdWorkDirBrowse = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Work Directory\r\nThe default directory where all job files and shared program file" +
    "s.";
            // 
            // TxtWorkDir
            // 
            this.TxtWorkDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtWorkDir.Location = new System.Drawing.Point(12, 68);
            this.TxtWorkDir.Name = "TxtWorkDir";
            this.TxtWorkDir.Size = new System.Drawing.Size(329, 23);
            this.TxtWorkDir.TabIndex = 1;
            this.TxtWorkDir.TextChanged += new System.EventHandler(this.TxtWorkDir_TextChanged);
            // 
            // CmdWorkDirBrowse
            // 
            this.CmdWorkDirBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdWorkDirBrowse.Location = new System.Drawing.Point(347, 68);
            this.CmdWorkDirBrowse.Name = "CmdWorkDirBrowse";
            this.CmdWorkDirBrowse.Size = new System.Drawing.Size(75, 23);
            this.CmdWorkDirBrowse.TabIndex = 2;
            this.CmdWorkDirBrowse.Text = "Browse";
            this.CmdWorkDirBrowse.UseVisualStyleBackColor = true;
            this.CmdWorkDirBrowse.Click += new System.EventHandler(this.CmdWorkDirBrowse_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdSave.Enabled = false;
            this.CmdSave.Location = new System.Drawing.Point(347, 598);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(75, 23);
            this.CmdSave.TabIndex = 3;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(9, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 56);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username\r\nEnter the name that you would like to show up on the logs, e-mails, and" +
    " other record-keeeping documents.";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUserName.Location = new System.Drawing.Point(12, 153);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(410, 23);
            this.TxtUserName.TabIndex = 5;
            this.TxtUserName.TextChanged += new System.EventHandler(this.TxtUserName_TextChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 633);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdWorkDirBrowse);
            this.Controls.Add(this.TxtWorkDir);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtWorkDir;
        private System.Windows.Forms.Button CmdWorkDirBrowse;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUserName;
    }
}