namespace MDG_UC
{
    partial class JobListItem
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
            this.LblName = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.CmdOpen = new System.Windows.Forms.Button();
            this.CmdView = new System.Windows.Forms.Button();
            this.CmdRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblName.BackColor = System.Drawing.Color.Transparent;
            this.LblName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(3, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(236, 28);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "label1";
            // 
            // LblAddress
            // 
            this.LblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAddress.Location = new System.Drawing.Point(3, 28);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(236, 17);
            this.LblAddress.TabIndex = 1;
            this.LblAddress.Text = "label2";
            // 
            // CmdOpen
            // 
            this.CmdOpen.BackColor = System.Drawing.Color.Transparent;
            this.CmdOpen.Location = new System.Drawing.Point(3, 48);
            this.CmdOpen.Name = "CmdOpen";
            this.CmdOpen.Size = new System.Drawing.Size(75, 25);
            this.CmdOpen.TabIndex = 2;
            this.CmdOpen.Text = "Open";
            this.CmdOpen.UseVisualStyleBackColor = false;
            this.CmdOpen.Click += new System.EventHandler(this.CmdOpen_Click);
            // 
            // CmdView
            // 
            this.CmdView.BackColor = System.Drawing.Color.Transparent;
            this.CmdView.Location = new System.Drawing.Point(84, 48);
            this.CmdView.Name = "CmdView";
            this.CmdView.Size = new System.Drawing.Size(75, 25);
            this.CmdView.TabIndex = 3;
            this.CmdView.Text = "View";
            this.CmdView.UseVisualStyleBackColor = false;
            // 
            // CmdRemove
            // 
            this.CmdRemove.BackColor = System.Drawing.Color.Transparent;
            this.CmdRemove.Location = new System.Drawing.Point(165, 48);
            this.CmdRemove.Name = "CmdRemove";
            this.CmdRemove.Size = new System.Drawing.Size(75, 25);
            this.CmdRemove.TabIndex = 4;
            this.CmdRemove.Text = "Remove";
            this.CmdRemove.UseVisualStyleBackColor = false;
            // 
            // JobListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CmdRemove);
            this.Controls.Add(this.CmdView);
            this.Controls.Add(this.CmdOpen);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.LblName);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(243, 76);
            this.Name = "JobListItem";
            this.Size = new System.Drawing.Size(243, 76);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Button CmdOpen;
        private System.Windows.Forms.Button CmdView;
        private System.Windows.Forms.Button CmdRemove;
    }
}
