namespace JMS
{
    partial class SearchWindow
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.DateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DateTimeDue = new System.Windows.Forms.DateTimePicker();
            this.TxtCustomer = new System.Windows.Forms.TextBox();
            this.CBExactMatch = new System.Windows.Forms.CheckBox();
            this.CmdExecute = new System.Windows.Forms.Button();
            this.RBMatchAny = new System.Windows.Forms.RadioButton();
            this.RBMatchAll = new System.Windows.Forms.RadioButton();
            this.CBWorkers = new System.Windows.Forms.ComboBox();
            this.CBStatusSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBDateDue = new System.Windows.Forms.CheckBox();
            this.CBDateRange = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(87, 20);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(415, 23);
            this.TxtName.TabIndex = 1;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(87, 49);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(415, 23);
            this.TxtAddress.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "From:";
            // 
            // DateTimeFrom
            // 
            this.DateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeFrom.Location = new System.Drawing.Point(183, 83);
            this.DateTimeFrom.Name = "DateTimeFrom";
            this.DateTimeFrom.Size = new System.Drawing.Size(99, 23);
            this.DateTimeFrom.TabIndex = 5;
            // 
            // DateTimeTo
            // 
            this.DateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeTo.Location = new System.Drawing.Point(323, 83);
            this.DateTimeTo.Name = "DateTimeTo";
            this.DateTimeTo.Size = new System.Drawing.Size(99, 23);
            this.DateTimeTo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "To:";
            // 
            // DateTimeDue
            // 
            this.DateTimeDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeDue.Location = new System.Drawing.Point(95, 112);
            this.DateTimeDue.Name = "DateTimeDue";
            this.DateTimeDue.Size = new System.Drawing.Size(99, 23);
            this.DateTimeDue.TabIndex = 9;
            // 
            // TxtCustomer
            // 
            this.TxtCustomer.Location = new System.Drawing.Point(87, 143);
            this.TxtCustomer.Name = "TxtCustomer";
            this.TxtCustomer.Size = new System.Drawing.Size(415, 23);
            this.TxtCustomer.TabIndex = 15;
            // 
            // CBExactMatch
            // 
            this.CBExactMatch.AutoSize = true;
            this.CBExactMatch.Location = new System.Drawing.Point(9, 236);
            this.CBExactMatch.Name = "CBExactMatch";
            this.CBExactMatch.Size = new System.Drawing.Size(103, 21);
            this.CBExactMatch.TabIndex = 18;
            this.CBExactMatch.Text = "Exact Match";
            this.CBExactMatch.UseVisualStyleBackColor = true;
            // 
            // CmdExecute
            // 
            this.CmdExecute.Location = new System.Drawing.Point(398, 290);
            this.CmdExecute.Name = "CmdExecute";
            this.CmdExecute.Size = new System.Drawing.Size(104, 29);
            this.CmdExecute.TabIndex = 21;
            this.CmdExecute.Text = "Search";
            this.CmdExecute.UseVisualStyleBackColor = true;
            this.CmdExecute.Click += new System.EventHandler(this.CmdExecute_Click);
            // 
            // RBMatchAny
            // 
            this.RBMatchAny.AutoSize = true;
            this.RBMatchAny.Checked = true;
            this.RBMatchAny.Location = new System.Drawing.Point(9, 263);
            this.RBMatchAny.Name = "RBMatchAny";
            this.RBMatchAny.Size = new System.Drawing.Size(152, 21);
            this.RBMatchAny.TabIndex = 22;
            this.RBMatchAny.TabStop = true;
            this.RBMatchAny.Text = "Match any condition";
            this.RBMatchAny.UseVisualStyleBackColor = true;
            // 
            // RBMatchAll
            // 
            this.RBMatchAll.AutoSize = true;
            this.RBMatchAll.Location = new System.Drawing.Point(9, 290);
            this.RBMatchAll.Name = "RBMatchAll";
            this.RBMatchAll.Size = new System.Drawing.Size(150, 21);
            this.RBMatchAll.TabIndex = 23;
            this.RBMatchAll.TabStop = true;
            this.RBMatchAll.Text = "Match all conditions";
            this.RBMatchAll.UseVisualStyleBackColor = true;
            // 
            // CBWorkers
            // 
            this.CBWorkers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBWorkers.FormattingEnabled = true;
            this.CBWorkers.Location = new System.Drawing.Point(87, 170);
            this.CBWorkers.Name = "CBWorkers";
            this.CBWorkers.Size = new System.Drawing.Size(415, 24);
            this.CBWorkers.TabIndex = 24;
            // 
            // CBStatusSelector
            // 
            this.CBStatusSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBStatusSelector.FormattingEnabled = true;
            this.CBStatusSelector.Items.AddRange(new object[] {
            "Created",
            "Field Work",
            "In Office",
            "Pending Review",
            "On hold",
            "Completed",
            "Cancelled",
            "Imported",
            "Engineer Review",
            "Invoicing"});
            this.CBStatusSelector.Location = new System.Drawing.Point(87, 200);
            this.CBStatusSelector.Name = "CBStatusSelector";
            this.CBStatusSelector.Size = new System.Drawing.Size(415, 24);
            this.CBStatusSelector.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Address:";
            // 
            // CBDateDue
            // 
            this.CBDateDue.AutoSize = true;
            this.CBDateDue.Location = new System.Drawing.Point(12, 114);
            this.CBDateDue.Name = "CBDateDue";
            this.CBDateDue.Size = new System.Drawing.Size(77, 21);
            this.CBDateDue.TabIndex = 13;
            this.CBDateDue.Text = "Due By:";
            this.CBDateDue.UseVisualStyleBackColor = true;
            // 
            // CBDateRange
            // 
            this.CBDateRange.AutoSize = true;
            this.CBDateRange.Location = new System.Drawing.Point(12, 83);
            this.CBDateRange.Name = "CBDateRange";
            this.CBDateRange.Size = new System.Drawing.Size(115, 21);
            this.CBDateRange.TabIndex = 12;
            this.CBDateRange.Text = "Date Created:";
            this.CBDateRange.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Customer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Employee:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Status:";
            // 
            // SearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 331);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBStatusSelector);
            this.Controls.Add(this.CBWorkers);
            this.Controls.Add(this.RBMatchAll);
            this.Controls.Add(this.RBMatchAny);
            this.Controls.Add(this.CmdExecute);
            this.Controls.Add(this.CBExactMatch);
            this.Controls.Add(this.TxtCustomer);
            this.Controls.Add(this.CBDateDue);
            this.Controls.Add(this.CBDateRange);
            this.Controls.Add(this.DateTimeDue);
            this.Controls.Add(this.DateTimeTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateTimeFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchWindow";
            this.Text = "SearchWindow";
            this.Load += new System.EventHandler(this.SearchWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateTimeFrom;
        private System.Windows.Forms.DateTimePicker DateTimeTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateTimeDue;
        private System.Windows.Forms.TextBox TxtCustomer;
        private System.Windows.Forms.CheckBox CBExactMatch;
        private System.Windows.Forms.Button CmdExecute;
        private System.Windows.Forms.RadioButton RBMatchAny;
        private System.Windows.Forms.RadioButton RBMatchAll;
        private System.Windows.Forms.ComboBox CBWorkers;
        private System.Windows.Forms.ComboBox CBStatusSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CBDateDue;
        private System.Windows.Forms.CheckBox CBDateRange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}