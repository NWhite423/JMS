﻿namespace JMS.UC
{
    partial class JobInformation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.eMailManager1 = new MDG_UC.EMailManager();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(945, 2);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // eMailManager1
            // 
            this.eMailManager1.BackColor = System.Drawing.SystemColors.Window;
            this.eMailManager1.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.eMailManager1.Location = new System.Drawing.Point(3, 35);
            this.eMailManager1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eMailManager1.Name = "eMailManager1";
            this.eMailManager1.Size = new System.Drawing.Size(380, 450);
            this.eMailManager1.TabIndex = 1;
            // 
            // JobInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.eMailManager1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "JobInformation";
            this.Size = new System.Drawing.Size(951, 750);
            this.Load += new System.EventHandler(this.JobInformation_Load);
            this.SizeChanged += new System.EventHandler(this.JobInformation_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MDG_UC.EMailManager eMailManager1;
    }
}