namespace MDG_UC
{
    partial class EMailManager
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
            this.DragDropEmail = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridEmails = new System.Windows.Forms.DataGridView();
            this.CmdRemove = new System.Windows.Forms.Button();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.DragDropEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEmails)).BeginInit();
            this.SuspendLayout();
            // 
            // DragDropEmail
            // 
            this.DragDropEmail.AllowDrop = true;
            this.DragDropEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DragDropEmail.BackColor = System.Drawing.Color.Transparent;
            this.DragDropEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DragDropEmail.Controls.Add(this.label1);
            this.DragDropEmail.Location = new System.Drawing.Point(3, 204);
            this.DragDropEmail.Name = "DragDropEmail";
            this.DragDropEmail.Size = new System.Drawing.Size(239, 110);
            this.DragDropEmail.TabIndex = 1;
            this.DragDropEmail.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel1_DragDrop);
            this.DragDropEmail.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel1_DragEnter);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drag Emails Here";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataGridEmails
            // 
            this.DataGridEmails.AllowUserToAddRows = false;
            this.DataGridEmails.AllowUserToDeleteRows = false;
            this.DataGridEmails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridEmails.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataGridEmails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridEmails.Location = new System.Drawing.Point(3, 31);
            this.DataGridEmails.MultiSelect = false;
            this.DataGridEmails.Name = "DataGridEmails";
            this.DataGridEmails.ReadOnly = true;
            this.DataGridEmails.RowHeadersVisible = false;
            this.DataGridEmails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridEmails.RowTemplate.ReadOnly = true;
            this.DataGridEmails.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridEmails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridEmails.ShowCellErrors = false;
            this.DataGridEmails.ShowEditingIcon = false;
            this.DataGridEmails.ShowRowErrors = false;
            this.DataGridEmails.Size = new System.Drawing.Size(239, 139);
            this.DataGridEmails.TabIndex = 2;
            this.DataGridEmails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridEmails_CellDoubleClick);
            this.DataGridEmails.SelectionChanged += new System.EventHandler(this.DataGridEmails_SelectionChanged);
            // 
            // CmdRemove
            // 
            this.CmdRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdRemove.BackColor = System.Drawing.Color.Transparent;
            this.CmdRemove.Location = new System.Drawing.Point(167, 176);
            this.CmdRemove.Name = "CmdRemove";
            this.CmdRemove.Size = new System.Drawing.Size(75, 23);
            this.CmdRemove.TabIndex = 3;
            this.CmdRemove.Text = "Remove";
            this.CmdRemove.UseVisualStyleBackColor = false;
            this.CmdRemove.Visible = false;
            this.CmdRemove.Click += new System.EventHandler(this.CmdRemove_Click);
            // 
            // CmdAdd
            // 
            this.CmdAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdAdd.BackColor = System.Drawing.Color.Transparent;
            this.CmdAdd.Location = new System.Drawing.Point(3, 176);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.Size = new System.Drawing.Size(75, 23);
            this.CmdAdd.TabIndex = 4;
            this.CmdAdd.Text = "Add";
            this.CmdAdd.UseVisualStyleBackColor = false;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.Location = new System.Drawing.Point(3, 5);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(239, 25);
            this.TxtSearch.TabIndex = 5;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            this.TxtSearch.Enter += new System.EventHandler(this.TxtSearch_Enter);
            this.TxtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearch_KeyPress);
            // 
            // EMailManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.CmdAdd);
            this.Controls.Add(this.CmdRemove);
            this.Controls.Add(this.DataGridEmails);
            this.Controls.Add(this.DragDropEmail);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EMailManager";
            this.Size = new System.Drawing.Size(245, 317);
            this.Load += new System.EventHandler(this.EMailManager_Load);
            this.DragDropEmail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEmails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel DragDropEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridEmails;
        private System.Windows.Forms.Button CmdRemove;
        private System.Windows.Forms.Button CmdAdd;
        private System.Windows.Forms.TextBox TxtSearch;
    }
}
