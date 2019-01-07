namespace JMS.UC
{
    partial class MainWindow
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
            this.CmdEdit = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFolderLocation = new System.Windows.Forms.TextBox();
            this.CmdOpen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDate = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTime = new System.Windows.Forms.MaskedTextBox();
            this.CmdMaps = new System.Windows.Forms.Button();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.TxtTimeEdited = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDateEdited = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GBPOC = new System.Windows.Forms.GroupBox();
            this.CmdEmailCopy = new System.Windows.Forms.Button();
            this.LBRepresentatives = new System.Windows.Forms.TreeView();
            this.CmdRemoveRep = new System.Windows.Forms.Button();
            this.CmdAddRep = new System.Windows.Forms.Button();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.cmdRepMaps = new System.Windows.Forms.Button();
            this.TxtRepAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtRepCompany = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtRepName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CmdAddComment = new System.Windows.Forms.Button();
            this.TxtnoteEditor = new System.Windows.Forms.TextBox();
            this.CmdAddTask = new System.Windows.Forms.Button();
            this.LBTasks = new System.Windows.Forms.ListBox();
            this.TxtCreatedBy = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtEditedBy = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.LBAssigned = new System.Windows.Forms.ListBox();
            this.CmdModifyEmployees = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.CmdSave = new System.Windows.Forms.Button();
            this.LblDateCompare = new System.Windows.Forms.Label();
            this.DateTimeDueDate = new System.Windows.Forms.DateTimePicker();
            this.CmdRemove = new System.Windows.Forms.Button();
            this.TxtLog = new System.Windows.Forms.TextBox();
            this.CmdRefresh = new System.Windows.Forms.Button();
            this.GBPOC.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job Name:";
            // 
            // CmdEdit
            // 
            this.CmdEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdEdit.Location = new System.Drawing.Point(983, 3);
            this.CmdEdit.Name = "CmdEdit";
            this.CmdEdit.Size = new System.Drawing.Size(75, 23);
            this.CmdEdit.TabIndex = 1;
            this.CmdEdit.Text = "Edit";
            this.CmdEdit.UseVisualStyleBackColor = true;
            this.CmdEdit.Click += new System.EventHandler(this.CmdEdit_Click);
            // 
            // TxtName
            // 
            this.TxtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtName.Enabled = false;
            this.TxtName.Location = new System.Drawing.Point(85, 32);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(973, 23);
            this.TxtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Folder Location:";
            // 
            // TxtFolderLocation
            // 
            this.TxtFolderLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFolderLocation.Enabled = false;
            this.TxtFolderLocation.Location = new System.Drawing.Point(119, 61);
            this.TxtFolderLocation.Name = "TxtFolderLocation";
            this.TxtFolderLocation.Size = new System.Drawing.Size(858, 23);
            this.TxtFolderLocation.TabIndex = 4;
            // 
            // CmdOpen
            // 
            this.CmdOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdOpen.Location = new System.Drawing.Point(983, 61);
            this.CmdOpen.Name = "CmdOpen";
            this.CmdOpen.Size = new System.Drawing.Size(75, 23);
            this.CmdOpen.TabIndex = 5;
            this.CmdOpen.Text = "Open";
            this.CmdOpen.UseVisualStyleBackColor = true;
            this.CmdOpen.Click += new System.EventHandler(this.CmdOpen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date Created:";
            // 
            // TxtDate
            // 
            this.TxtDate.Enabled = false;
            this.TxtDate.Location = new System.Drawing.Point(105, 121);
            this.TxtDate.Mask = "00/00/0000";
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(100, 23);
            this.TxtDate.TabIndex = 7;
            this.TxtDate.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Time Created:";
            // 
            // TxtTime
            // 
            this.TxtTime.Enabled = false;
            this.TxtTime.Location = new System.Drawing.Point(314, 121);
            this.TxtTime.Mask = "00:00:00";
            this.TxtTime.Name = "TxtTime";
            this.TxtTime.Size = new System.Drawing.Size(100, 23);
            this.TxtTime.TabIndex = 9;
            this.TxtTime.ValidatingType = typeof(System.DateTime);
            // 
            // CmdMaps
            // 
            this.CmdMaps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdMaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdMaps.Location = new System.Drawing.Point(983, 90);
            this.CmdMaps.Name = "CmdMaps";
            this.CmdMaps.Size = new System.Drawing.Size(75, 23);
            this.CmdMaps.TabIndex = 12;
            this.CmdMaps.Text = "Go to";
            this.CmdMaps.UseVisualStyleBackColor = true;
            this.CmdMaps.Click += new System.EventHandler(this.CmdMaps_Click);
            // 
            // TxtAddress
            // 
            this.TxtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAddress.Enabled = false;
            this.TxtAddress.Location = new System.Drawing.Point(73, 90);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(904, 23);
            this.TxtAddress.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(838, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Status:";
            // 
            // CmbStatus
            // 
            this.CmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Items.AddRange(new object[] {
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
            this.CmbStatus.Location = new System.Drawing.Point(896, 121);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(162, 24);
            this.CmbStatus.TabIndex = 14;
            this.CmbStatus.SelectedIndexChanged += new System.EventHandler(this.CmbStatus_SelectedIndexChanged);
            // 
            // TxtTimeEdited
            // 
            this.TxtTimeEdited.Enabled = false;
            this.TxtTimeEdited.Location = new System.Drawing.Point(314, 150);
            this.TxtTimeEdited.Mask = "00:00:00";
            this.TxtTimeEdited.Name = "TxtTimeEdited";
            this.TxtTimeEdited.Size = new System.Drawing.Size(100, 23);
            this.TxtTimeEdited.TabIndex = 18;
            this.TxtTimeEdited.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Time Edited:";
            // 
            // TxtDateEdited
            // 
            this.TxtDateEdited.Enabled = false;
            this.TxtDateEdited.Location = new System.Drawing.Point(105, 150);
            this.TxtDateEdited.Mask = "00/00/0000";
            this.TxtDateEdited.Name = "TxtDateEdited";
            this.TxtDateEdited.Size = new System.Drawing.Size(100, 23);
            this.TxtDateEdited.TabIndex = 16;
            this.TxtDateEdited.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Date Edited:";
            // 
            // GBPOC
            // 
            this.GBPOC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBPOC.Controls.Add(this.CmdEmailCopy);
            this.GBPOC.Controls.Add(this.LBRepresentatives);
            this.GBPOC.Controls.Add(this.CmdRemoveRep);
            this.GBPOC.Controls.Add(this.CmdAddRep);
            this.GBPOC.Controls.Add(this.TxtEmail);
            this.GBPOC.Controls.Add(this.label13);
            this.GBPOC.Controls.Add(this.label12);
            this.GBPOC.Controls.Add(this.TxtPhone);
            this.GBPOC.Controls.Add(this.cmdRepMaps);
            this.GBPOC.Controls.Add(this.TxtRepAddress);
            this.GBPOC.Controls.Add(this.label11);
            this.GBPOC.Controls.Add(this.TxtRepCompany);
            this.GBPOC.Controls.Add(this.label10);
            this.GBPOC.Controls.Add(this.TxtRepName);
            this.GBPOC.Controls.Add(this.label9);
            this.GBPOC.Location = new System.Drawing.Point(6, 179);
            this.GBPOC.Name = "GBPOC";
            this.GBPOC.Size = new System.Drawing.Size(1052, 169);
            this.GBPOC.TabIndex = 19;
            this.GBPOC.TabStop = false;
            this.GBPOC.Text = "Points of Contact";
            // 
            // CmdEmailCopy
            // 
            this.CmdEmailCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdEmailCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdEmailCopy.Location = new System.Drawing.Point(971, 108);
            this.CmdEmailCopy.Name = "CmdEmailCopy";
            this.CmdEmailCopy.Size = new System.Drawing.Size(75, 23);
            this.CmdEmailCopy.TabIndex = 28;
            this.CmdEmailCopy.Text = "Copy";
            this.CmdEmailCopy.UseVisualStyleBackColor = true;
            this.CmdEmailCopy.Click += new System.EventHandler(this.CmdEmailCopy_Click);
            // 
            // LBRepresentatives
            // 
            this.LBRepresentatives.Location = new System.Drawing.Point(6, 22);
            this.LBRepresentatives.Name = "LBRepresentatives";
            this.LBRepresentatives.Size = new System.Drawing.Size(357, 112);
            this.LBRepresentatives.TabIndex = 27;
            this.LBRepresentatives.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.LBRepresentatives_AfterSelect);
            // 
            // CmdRemoveRep
            // 
            this.CmdRemoveRep.Enabled = false;
            this.CmdRemoveRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdRemoveRep.Location = new System.Drawing.Point(87, 140);
            this.CmdRemoveRep.Name = "CmdRemoveRep";
            this.CmdRemoveRep.Size = new System.Drawing.Size(75, 23);
            this.CmdRemoveRep.TabIndex = 26;
            this.CmdRemoveRep.Text = "Remove";
            this.CmdRemoveRep.UseVisualStyleBackColor = true;
            this.CmdRemoveRep.Click += new System.EventHandler(this.CmdRemoveRep_Click);
            // 
            // CmdAddRep
            // 
            this.CmdAddRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAddRep.Location = new System.Drawing.Point(6, 140);
            this.CmdAddRep.Name = "CmdAddRep";
            this.CmdAddRep.Size = new System.Drawing.Size(75, 23);
            this.CmdAddRep.TabIndex = 24;
            this.CmdAddRep.Text = "Add";
            this.CmdAddRep.UseVisualStyleBackColor = true;
            this.CmdAddRep.Click += new System.EventHandler(this.CmdAddRep_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEmail.Enabled = false;
            this.TxtEmail.Location = new System.Drawing.Point(602, 108);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(369, 23);
            this.TxtEmail.TabIndex = 23;
            this.TxtEmail.DoubleClick += new System.EventHandler(this.TxtEmail_DoubleClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(545, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "E-Mail:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(369, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Phone:";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Enabled = false;
            this.TxtPhone.Location = new System.Drawing.Point(428, 108);
            this.TxtPhone.Mask = "(999) 000-0000";
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(111, 23);
            this.TxtPhone.TabIndex = 20;
            // 
            // cmdRepMaps
            // 
            this.cmdRepMaps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRepMaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRepMaps.Location = new System.Drawing.Point(971, 79);
            this.cmdRepMaps.Name = "cmdRepMaps";
            this.cmdRepMaps.Size = new System.Drawing.Size(75, 23);
            this.cmdRepMaps.TabIndex = 20;
            this.cmdRepMaps.Text = "Go to";
            this.cmdRepMaps.UseVisualStyleBackColor = true;
            this.cmdRepMaps.Click += new System.EventHandler(this.CmdRepMaps_Click);
            // 
            // TxtRepAddress
            // 
            this.TxtRepAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtRepAddress.Enabled = false;
            this.TxtRepAddress.Location = new System.Drawing.Point(439, 79);
            this.TxtRepAddress.Name = "TxtRepAddress";
            this.TxtRepAddress.Size = new System.Drawing.Size(532, 23);
            this.TxtRepAddress.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(369, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Address:";
            // 
            // TxtRepCompany
            // 
            this.TxtRepCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtRepCompany.Enabled = false;
            this.TxtRepCompany.Location = new System.Drawing.Point(446, 51);
            this.TxtRepCompany.Name = "TxtRepCompany";
            this.TxtRepCompany.Size = new System.Drawing.Size(600, 23);
            this.TxtRepCompany.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(369, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Company:";
            // 
            // TxtRepName
            // 
            this.TxtRepName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtRepName.Enabled = false;
            this.TxtRepName.Location = new System.Drawing.Point(424, 22);
            this.TxtRepName.Name = "TxtRepName";
            this.TxtRepName.Size = new System.Drawing.Size(622, 23);
            this.TxtRepName.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(369, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Name:";
            // 
            // CmdAddComment
            // 
            this.CmdAddComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdAddComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAddComment.Location = new System.Drawing.Point(983, 588);
            this.CmdAddComment.Name = "CmdAddComment";
            this.CmdAddComment.Size = new System.Drawing.Size(75, 44);
            this.CmdAddComment.TabIndex = 27;
            this.CmdAddComment.Text = "Add Comment";
            this.CmdAddComment.UseVisualStyleBackColor = true;
            this.CmdAddComment.Click += new System.EventHandler(this.CmdAddComment_Click);
            // 
            // TxtnoteEditor
            // 
            this.TxtnoteEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtnoteEditor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TxtnoteEditor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.TxtnoteEditor.Location = new System.Drawing.Point(501, 588);
            this.TxtnoteEditor.Multiline = true;
            this.TxtnoteEditor.Name = "TxtnoteEditor";
            this.TxtnoteEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtnoteEditor.Size = new System.Drawing.Size(476, 44);
            this.TxtnoteEditor.TabIndex = 28;
            // 
            // CmdAddTask
            // 
            this.CmdAddTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdAddTask.Location = new System.Drawing.Point(3, 604);
            this.CmdAddTask.Name = "CmdAddTask";
            this.CmdAddTask.Size = new System.Drawing.Size(240, 28);
            this.CmdAddTask.TabIndex = 29;
            this.CmdAddTask.Text = "Manage Tasks";
            this.CmdAddTask.UseVisualStyleBackColor = true;
            this.CmdAddTask.Click += new System.EventHandler(this.CmdAddTask_Click);
            // 
            // LBTasks
            // 
            this.LBTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBTasks.FormattingEnabled = true;
            this.LBTasks.ItemHeight = 16;
            this.LBTasks.Location = new System.Drawing.Point(3, 354);
            this.LBTasks.Name = "LBTasks";
            this.LBTasks.Size = new System.Drawing.Size(240, 244);
            this.LBTasks.TabIndex = 31;
            // 
            // TxtCreatedBy
            // 
            this.TxtCreatedBy.Enabled = false;
            this.TxtCreatedBy.Location = new System.Drawing.Point(508, 121);
            this.TxtCreatedBy.Name = "TxtCreatedBy";
            this.TxtCreatedBy.Size = new System.Drawing.Size(121, 23);
            this.TxtCreatedBy.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(420, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 17);
            this.label14.TabIndex = 33;
            this.label14.Text = "Created By:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(430, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 17);
            this.label15.TabIndex = 35;
            this.label15.Text = "Edited By:";
            // 
            // TxtEditedBy
            // 
            this.TxtEditedBy.Enabled = false;
            this.TxtEditedBy.Location = new System.Drawing.Point(508, 150);
            this.TxtEditedBy.Name = "TxtEditedBy";
            this.TxtEditedBy.Size = new System.Drawing.Size(121, 23);
            this.TxtEditedBy.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(846, 153);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 17);
            this.label16.TabIndex = 37;
            this.label16.Text = "Price:";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPrice.Enabled = false;
            this.TxtPrice.Location = new System.Drawing.Point(896, 150);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(162, 23);
            this.TxtPrice.TabIndex = 36;
            // 
            // LBAssigned
            // 
            this.LBAssigned.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBAssigned.FormattingEnabled = true;
            this.LBAssigned.ItemHeight = 16;
            this.LBAssigned.Location = new System.Drawing.Point(249, 354);
            this.LBAssigned.Name = "LBAssigned";
            this.LBAssigned.Size = new System.Drawing.Size(240, 244);
            this.LBAssigned.TabIndex = 38;
            // 
            // CmdModifyEmployees
            // 
            this.CmdModifyEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdModifyEmployees.Location = new System.Drawing.Point(249, 604);
            this.CmdModifyEmployees.Name = "CmdModifyEmployees";
            this.CmdModifyEmployees.Size = new System.Drawing.Size(240, 28);
            this.CmdModifyEmployees.TabIndex = 39;
            this.CmdModifyEmployees.Text = "Manage Employees";
            this.CmdModifyEmployees.UseVisualStyleBackColor = true;
            this.CmdModifyEmployees.Click += new System.EventHandler(this.CmdModifyEmployees_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(641, 124);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 17);
            this.label18.TabIndex = 43;
            this.label18.Text = "Due Date:";
            // 
            // CmdSave
            // 
            this.CmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdSave.Enabled = false;
            this.CmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSave.Location = new System.Drawing.Point(902, 3);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(75, 23);
            this.CmdSave.TabIndex = 47;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // LblDateCompare
            // 
            this.LblDateCompare.Location = new System.Drawing.Point(635, 150);
            this.LblDateCompare.Name = "LblDateCompare";
            this.LblDateCompare.Size = new System.Drawing.Size(197, 23);
            this.LblDateCompare.TabIndex = 48;
            this.LblDateCompare.Text = "XX days until due";
            this.LblDateCompare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DateTimeDueDate
            // 
            this.DateTimeDueDate.Enabled = false;
            this.DateTimeDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeDueDate.Location = new System.Drawing.Point(719, 121);
            this.DateTimeDueDate.Name = "DateTimeDueDate";
            this.DateTimeDueDate.Size = new System.Drawing.Size(113, 23);
            this.DateTimeDueDate.TabIndex = 49;
            // 
            // CmdRemove
            // 
            this.CmdRemove.Enabled = false;
            this.CmdRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdRemove.Location = new System.Drawing.Point(3, 3);
            this.CmdRemove.Name = "CmdRemove";
            this.CmdRemove.Size = new System.Drawing.Size(75, 23);
            this.CmdRemove.TabIndex = 50;
            this.CmdRemove.Text = "Remove";
            this.CmdRemove.UseVisualStyleBackColor = true;
            this.CmdRemove.Visible = false;
            this.CmdRemove.Click += new System.EventHandler(this.CmdRemove_Click);
            // 
            // TxtLog
            // 
            this.TxtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtLog.Enabled = false;
            this.TxtLog.Location = new System.Drawing.Point(501, 354);
            this.TxtLog.Multiline = true;
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtLog.Size = new System.Drawing.Size(551, 228);
            this.TxtLog.TabIndex = 51;
            // 
            // CmdRefresh
            // 
            this.CmdRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdRefresh.Location = new System.Drawing.Point(821, 3);
            this.CmdRefresh.Name = "CmdRefresh";
            this.CmdRefresh.Size = new System.Drawing.Size(75, 23);
            this.CmdRefresh.TabIndex = 52;
            this.CmdRefresh.Text = "Refresh\r\n";
            this.CmdRefresh.UseVisualStyleBackColor = true;
            this.CmdRefresh.Click += new System.EventHandler(this.UpdateJobInfo);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.CmdRefresh);
            this.Controls.Add(this.TxtLog);
            this.Controls.Add(this.CmdRemove);
            this.Controls.Add(this.DateTimeDueDate);
            this.Controls.Add(this.LblDateCompare);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.CmdModifyEmployees);
            this.Controls.Add(this.LBAssigned);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtEditedBy);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TxtCreatedBy);
            this.Controls.Add(this.LBTasks);
            this.Controls.Add(this.CmdAddTask);
            this.Controls.Add(this.TxtnoteEditor);
            this.Controls.Add(this.CmdAddComment);
            this.Controls.Add(this.GBPOC);
            this.Controls.Add(this.TxtTimeEdited);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtDateEdited);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CmbStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmdMaps);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmdOpen);
            this.Controls.Add(this.TxtFolderLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.CmdEdit);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1061, 640);
            this.Name = "MainWindow";
            this.Size = new System.Drawing.Size(1061, 640);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.GBPOC.ResumeLayout(false);
            this.GBPOC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CmdOpen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CmdMaps;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtName;
        public System.Windows.Forms.TextBox TxtFolderLocation;
        public System.Windows.Forms.MaskedTextBox TxtDate;
        public System.Windows.Forms.MaskedTextBox TxtTime;
        public System.Windows.Forms.TextBox TxtAddress;
        public System.Windows.Forms.ComboBox CmbStatus;
        public System.Windows.Forms.MaskedTextBox TxtTimeEdited;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.MaskedTextBox TxtDateEdited;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.GroupBox GBPOC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cmdRepMaps;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.MaskedTextBox TxtPhone;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox TxtRepName;
        public System.Windows.Forms.TextBox TxtRepAddress;
        public System.Windows.Forms.TextBox TxtRepCompany;
        public System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button CmdAddComment;
        public System.Windows.Forms.TextBox TxtnoteEditor;
        private System.Windows.Forms.Button CmdAddTask;
        public System.Windows.Forms.ListBox LBTasks;
        public System.Windows.Forms.TextBox TxtCreatedBy;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox TxtEditedBy;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Button CmdRemoveRep;
        private System.Windows.Forms.Button CmdAddRep;
        public System.Windows.Forms.ListBox LBAssigned;
        private System.Windows.Forms.Button CmdModifyEmployees;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button CmdSave;
        public System.Windows.Forms.Label LblDateCompare;
        public System.Windows.Forms.DateTimePicker DateTimeDueDate;
        private System.Windows.Forms.Button CmdRemove;
        public System.Windows.Forms.TreeView LBRepresentatives;
        public System.Windows.Forms.TextBox TxtLog;
        private System.Windows.Forms.Button CmdEmailCopy;
        private System.Windows.Forms.Button CmdRefresh;
    }
}
