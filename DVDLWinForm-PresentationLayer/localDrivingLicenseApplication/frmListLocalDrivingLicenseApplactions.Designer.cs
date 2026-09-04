namespace DVDLWinForm_PresentationLayer.localDrivingLicenseApplication
{
    partial class frmListLocalDrivingLicenseApplactions
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LocalDrivingLicenseApplicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassedTestCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.lblNumberOfRecord = new System.Windows.Forms.Label();
            this.lblRecodTitel = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbFilterType = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnAddNewLdlApp = new System.Windows.Forms.Button();
            this.ptbLdlApp = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.showApplicationDetielsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMICancel = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIsecdul = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIvision = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIwritten = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIpractical = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIissueDrivingLicenseFirstTime = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIshowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIshowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLdlApp)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LocalDrivingLicenseApplicationID,
            this.ClassName,
            this.NationalNo,
            this.FullName,
            this.ApplicationDate,
            this.PassedTestCount,
            this.Status});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(45, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(965, 349);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LocalDrivingLicenseApplicationID
            // 
            this.LocalDrivingLicenseApplicationID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LocalDrivingLicenseApplicationID.DataPropertyName = "LocalDrivingLicenseApplicationID";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalDrivingLicenseApplicationID.DefaultCellStyle = dataGridViewCellStyle2;
            this.LocalDrivingLicenseApplicationID.HeaderText = "L.D.LAppID";
            this.LocalDrivingLicenseApplicationID.Name = "LocalDrivingLicenseApplicationID";
            this.LocalDrivingLicenseApplicationID.ReadOnly = true;
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "Driving class";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            this.ClassName.Width = 250;
            // 
            // NationalNo
            // 
            this.NationalNo.DataPropertyName = "NationalNo";
            this.NationalNo.HeaderText = "National No";
            this.NationalNo.Name = "NationalNo";
            this.NationalNo.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.FillWeight = 200F;
            this.FullName.HeaderText = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // ApplicationDate
            // 
            this.ApplicationDate.DataPropertyName = "ApplicationDate";
            this.ApplicationDate.HeaderText = "Appliaction Date ";
            this.ApplicationDate.Name = "ApplicationDate";
            this.ApplicationDate.ReadOnly = true;
            this.ApplicationDate.Width = 150;
            // 
            // PassedTestCount
            // 
            this.PassedTestCount.DataPropertyName = "PassedTestCount";
            this.PassedTestCount.HeaderText = "Passed Test";
            this.PassedTestCount.Name = "PassedTestCount";
            this.PassedTestCount.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetielsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.editApplicationToolStripMenuItem,
            this.TSMDelete,
            this.toolStripSeparator1,
            this.TSMICancel,
            this.toolStripMenuItem4,
            this.TSMIsecdul,
            this.toolStripMenuItem3,
            this.TSMIissueDrivingLicenseFirstTime,
            this.TSMIshowLicense,
            this.toolStripMenuItem5,
            this.TSMIshowPersonLicenseHistory});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(282, 210);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(278, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(278, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(278, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(278, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(278, 6);
            // 
            // lblNumberOfRecord
            // 
            this.lblNumberOfRecord.AutoSize = true;
            this.lblNumberOfRecord.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecord.Location = new System.Drawing.Point(140, 599);
            this.lblNumberOfRecord.Name = "lblNumberOfRecord";
            this.lblNumberOfRecord.Size = new System.Drawing.Size(14, 13);
            this.lblNumberOfRecord.TabIndex = 9;
            this.lblNumberOfRecord.Text = "0";
            this.lblNumberOfRecord.Click += new System.EventHandler(this.lblNumberOfRecord_Click);
            // 
            // lblRecodTitel
            // 
            this.lblRecodTitel.AutoSize = true;
            this.lblRecodTitel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecodTitel.Location = new System.Drawing.Point(41, 595);
            this.lblRecodTitel.Name = "lblRecodTitel";
            this.lblRecodTitel.Size = new System.Drawing.Size(93, 19);
            this.lblRecodTitel.TabIndex = 8;
            this.lblRecodTitel.Text = "#Records:";
            this.lblRecodTitel.Click += new System.EventHandler(this.lblRecodTitel_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(42, 208);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(68, 16);
            this.lblFilter.TabIndex = 22;
            this.lblFilter.Text = "Filter By :";
            // 
            // cmbFilterType
            // 
            this.cmbFilterType.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFilterType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbFilterType.FormattingEnabled = true;
            this.cmbFilterType.Items.AddRange(new object[] {
            "None",
            "L.D.LAppID",
            "NationalNo",
            "Full Name",
            "Stauts"});
            this.cmbFilterType.Location = new System.Drawing.Point(116, 208);
            this.cmbFilterType.Name = "cmbFilterType";
            this.cmbFilterType.Size = new System.Drawing.Size(135, 21);
            this.cmbFilterType.TabIndex = 23;
            this.cmbFilterType.SelectedIndexChanged += new System.EventHandler(this.cmbFilterType_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(257, 209);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(154, 20);
            this.txtFilterValue.TabIndex = 24;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(377, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Local Driving License Application";
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "New",
            "Cancelled",
            "Completed"});
            this.cmbStatus.Location = new System.Drawing.Point(257, 208);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(154, 21);
            this.cmbStatus.TabIndex = 28;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // btnAddNewLdlApp
            // 
            this.btnAddNewLdlApp.FlatAppearance.BorderSize = 2;
            this.btnAddNewLdlApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewLdlApp.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.New_Application_64;
            this.btnAddNewLdlApp.Location = new System.Drawing.Point(934, 156);
            this.btnAddNewLdlApp.Name = "btnAddNewLdlApp";
            this.btnAddNewLdlApp.Size = new System.Drawing.Size(64, 73);
            this.btnAddNewLdlApp.TabIndex = 27;
            this.btnAddNewLdlApp.UseVisualStyleBackColor = true;
            this.btnAddNewLdlApp.Click += new System.EventHandler(this.btnAddNewLdlApp_Click);
            // 
            // ptbLdlApp
            // 
            this.ptbLdlApp.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Applications;
            this.ptbLdlApp.Location = new System.Drawing.Point(472, -4);
            this.ptbLdlApp.Name = "ptbLdlApp";
            this.ptbLdlApp.Size = new System.Drawing.Size(153, 144);
            this.ptbLdlApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLdlApp.TabIndex = 26;
            this.ptbLdlApp.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(906, 587);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 34);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // showApplicationDetielsToolStripMenuItem
            // 
            this.showApplicationDetielsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showApplicationDetielsToolStripMenuItem.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.PersonDetails_323;
            this.showApplicationDetielsToolStripMenuItem.Name = "showApplicationDetielsToolStripMenuItem";
            this.showApplicationDetielsToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.showApplicationDetielsToolStripMenuItem.Text = "Show Application Detiels";
            this.showApplicationDetielsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetielsToolStripMenuItem_Click);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editApplicationToolStripMenuItem.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.edit_323;
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.editApplicationToolStripMenuItem.Text = "Edit Application";
            this.editApplicationToolStripMenuItem.Click += new System.EventHandler(this.editApplicationToolStripMenuItem_Click);
            // 
            // TSMDelete
            // 
            this.TSMDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMDelete.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Delete_32_21;
            this.TSMDelete.Name = "TSMDelete";
            this.TSMDelete.Size = new System.Drawing.Size(281, 22);
            this.TSMDelete.Text = "Delete Application";
            this.TSMDelete.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // TSMICancel
            // 
            this.TSMICancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMICancel.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Close_641;
            this.TSMICancel.Name = "TSMICancel";
            this.TSMICancel.Size = new System.Drawing.Size(281, 22);
            this.TSMICancel.Text = "Cancel Application";
            this.TSMICancel.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // TSMIsecdul
            // 
            this.TSMIsecdul.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIvision,
            this.TSMIwritten,
            this.TSMIpractical});
            this.TSMIsecdul.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMIsecdul.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Schedule_Test_32;
            this.TSMIsecdul.Name = "TSMIsecdul";
            this.TSMIsecdul.Size = new System.Drawing.Size(281, 22);
            this.TSMIsecdul.Text = "Sechdule Tests";
            // 
            // TSMIvision
            // 
            this.TSMIvision.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Vision_Test_32;
            this.TSMIvision.Name = "TSMIvision";
            this.TSMIvision.Size = new System.Drawing.Size(211, 22);
            this.TSMIvision.Text = "Schedule Vision Test";
            this.TSMIvision.Click += new System.EventHandler(this.visionTestToolStripMenuItem_Click);
            // 
            // TSMIwritten
            // 
            this.TSMIwritten.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Written_Test_32_Sechdule;
            this.TSMIwritten.Name = "TSMIwritten";
            this.TSMIwritten.Size = new System.Drawing.Size(211, 22);
            this.TSMIwritten.Text = "Schedule Written Test";
            this.TSMIwritten.Click += new System.EventHandler(this.writtenTestToolStripMenuItem_Click);
            // 
            // TSMIpractical
            // 
            this.TSMIpractical.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Street_Test_32;
            this.TSMIpractical.Name = "TSMIpractical";
            this.TSMIpractical.Size = new System.Drawing.Size(211, 22);
            this.TSMIpractical.Text = "Schedule Street Test";
            this.TSMIpractical.Click += new System.EventHandler(this.TSMIpractical_Click);
            // 
            // TSMIissueDrivingLicenseFirstTime
            // 
            this.TSMIissueDrivingLicenseFirstTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMIissueDrivingLicenseFirstTime.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.IssueDrivingLicense_32;
            this.TSMIissueDrivingLicenseFirstTime.Name = "TSMIissueDrivingLicenseFirstTime";
            this.TSMIissueDrivingLicenseFirstTime.Size = new System.Drawing.Size(281, 22);
            this.TSMIissueDrivingLicenseFirstTime.Text = "Issue Driving License (First Time)";
            this.TSMIissueDrivingLicenseFirstTime.Click += new System.EventHandler(this.TSMIissueDrivingLicenseFirstTime_Click);
            // 
            // TSMIshowLicense
            // 
            this.TSMIshowLicense.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMIshowLicense.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.License_View_322;
            this.TSMIshowLicense.Name = "TSMIshowLicense";
            this.TSMIshowLicense.Size = new System.Drawing.Size(281, 22);
            this.TSMIshowLicense.Text = "Show License";
            this.TSMIshowLicense.Click += new System.EventHandler(this.TSMIshowLicense_Click);
            // 
            // TSMIshowPersonLicenseHistory
            // 
            this.TSMIshowPersonLicenseHistory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMIshowPersonLicenseHistory.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.PersonLicenseHistory_32;
            this.TSMIshowPersonLicenseHistory.Name = "TSMIshowPersonLicenseHistory";
            this.TSMIshowPersonLicenseHistory.Size = new System.Drawing.Size(281, 22);
            this.TSMIshowPersonLicenseHistory.Text = "Show Person License History";
            this.TSMIshowPersonLicenseHistory.Click += new System.EventHandler(this.TSMIshowPersonLicenseHistory_Click);
            // 
            // frmListLocalDrivingLicenseApplactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1023, 623);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnAddNewLdlApp);
            this.Controls.Add(this.ptbLdlApp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cmbFilterType);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblNumberOfRecord);
            this.Controls.Add(this.lblRecodTitel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmListLocalDrivingLicenseApplactions";
            this.Text = "frmListLocalDrivingLicenseApplactions";
            this.Load += new System.EventHandler(this.frmListLocalDrivingLicenseApplactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLdlApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNumberOfRecord;
        private System.Windows.Forms.Label lblRecodTitel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbFilterType;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbLdlApp;
        private System.Windows.Forms.Button btnAddNewLdlApp;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalDrivingLicenseApplicationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassedTestCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetielsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMICancel;
        private System.Windows.Forms.ToolStripMenuItem TSMDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem TSMIsecdul;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem TSMIissueDrivingLicenseFirstTime;
        private System.Windows.Forms.ToolStripMenuItem TSMIshowLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem TSMIshowPersonLicenseHistory;
        private System.Windows.Forms.ToolStripMenuItem TSMIvision;
        private System.Windows.Forms.ToolStripMenuItem TSMIwritten;
        private System.Windows.Forms.ToolStripMenuItem TSMIpractical;
    }
}