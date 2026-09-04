namespace DVDLWinForm_PresentationLayer.InternationalLicenses
{
    partial class frmInterntionalLicesesApplictions
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
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbFilterType = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.InternationalLicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssuedUsingLocalLicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblRecodTitel = new System.Windows.Forms.Label();
            this.lblNumberOfRecord = new System.Windows.Forms.Label();
            this.cmbIsActive = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddNewLdlApp = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ptbLdlApp = new System.Windows.Forms.PictureBox();
            this.showPersonDetilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLdlApp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(12, 195);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(68, 16);
            this.lblFilter.TabIndex = 29;
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
            "International License ID",
            "Application ID",
            "Driver ID",
            "Local License ID",
            "Is Active"});
            this.cmbFilterType.Location = new System.Drawing.Point(95, 195);
            this.cmbFilterType.Name = "cmbFilterType";
            this.cmbFilterType.Size = new System.Drawing.Size(135, 21);
            this.cmbFilterType.TabIndex = 30;
            this.cmbFilterType.SelectedIndexChanged += new System.EventHandler(this.cmbFilterType_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(249, 196);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(154, 20);
            this.txtFilterValue.TabIndex = 31;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(244, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Interntional  License Application";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InternationalLicenseID,
            this.ApplicationID,
            this.DriverID,
            this.IssuedUsingLocalLicenseID,
            this.IssueDate,
            this.ExpirationDate,
            this.IsActive});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(16, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(745, 249);
            this.dataGridView1.TabIndex = 34;
            // 
            // InternationalLicenseID
            // 
            this.InternationalLicenseID.DataPropertyName = "InternationalLicenseID";
            this.InternationalLicenseID.HeaderText = "Int LicenseID";
            this.InternationalLicenseID.Name = "InternationalLicenseID";
            this.InternationalLicenseID.ReadOnly = true;
            // 
            // ApplicationID
            // 
            this.ApplicationID.DataPropertyName = "ApplicationID";
            this.ApplicationID.HeaderText = "ApplicationID";
            this.ApplicationID.Name = "ApplicationID";
            this.ApplicationID.ReadOnly = true;
            // 
            // DriverID
            // 
            this.DriverID.DataPropertyName = "DriverID";
            this.DriverID.HeaderText = "DriverID";
            this.DriverID.Name = "DriverID";
            this.DriverID.ReadOnly = true;
            // 
            // IssuedUsingLocalLicenseID
            // 
            this.IssuedUsingLocalLicenseID.DataPropertyName = "IssuedUsingLocalLicenseID";
            this.IssuedUsingLocalLicenseID.HeaderText = "L.LicenseID";
            this.IssuedUsingLocalLicenseID.Name = "IssuedUsingLocalLicenseID";
            this.IssuedUsingLocalLicenseID.ReadOnly = true;
            // 
            // IssueDate
            // 
            this.IssueDate.DataPropertyName = "IssueDate";
            this.IssueDate.HeaderText = "IssueDate";
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.ReadOnly = true;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.DataPropertyName = "ExpirationDate";
            this.ExpirationDate.HeaderText = "ExpirationDate";
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.ReadOnly = true;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "IsActive";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            // 
            // lblRecodTitel
            // 
            this.lblRecodTitel.AutoSize = true;
            this.lblRecodTitel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecodTitel.Location = new System.Drawing.Point(12, 485);
            this.lblRecodTitel.Name = "lblRecodTitel";
            this.lblRecodTitel.Size = new System.Drawing.Size(93, 19);
            this.lblRecodTitel.TabIndex = 36;
            this.lblRecodTitel.Text = "#Records:";
            // 
            // lblNumberOfRecord
            // 
            this.lblNumberOfRecord.AutoSize = true;
            this.lblNumberOfRecord.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecord.Location = new System.Drawing.Point(111, 490);
            this.lblNumberOfRecord.Name = "lblNumberOfRecord";
            this.lblNumberOfRecord.Size = new System.Drawing.Size(14, 13);
            this.lblNumberOfRecord.TabIndex = 37;
            this.lblNumberOfRecord.Text = "0";
            // 
            // cmbIsActive
            // 
            this.cmbIsActive.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbIsActive.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbIsActive.FormattingEnabled = true;
            this.cmbIsActive.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbIsActive.Location = new System.Drawing.Point(249, 194);
            this.cmbIsActive.Name = "cmbIsActive";
            this.cmbIsActive.Size = new System.Drawing.Size(135, 21);
            this.cmbIsActive.TabIndex = 38;
            this.cmbIsActive.SelectedIndexChanged += new System.EventHandler(this.cmbIsActive_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetilsToolStripMenuItem,
            this.showLicenseDetilsToolStripMenuItem,
            this.showLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 92);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(651, 479);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 34);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnAddNewLdlApp
            // 
            this.btnAddNewLdlApp.FlatAppearance.BorderSize = 2;
            this.btnAddNewLdlApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewLdlApp.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.New_Application_64;
            this.btnAddNewLdlApp.Location = new System.Drawing.Point(692, 143);
            this.btnAddNewLdlApp.Name = "btnAddNewLdlApp";
            this.btnAddNewLdlApp.Size = new System.Drawing.Size(64, 73);
            this.btnAddNewLdlApp.TabIndex = 32;
            this.btnAddNewLdlApp.UseVisualStyleBackColor = true;
            this.btnAddNewLdlApp.Click += new System.EventHandler(this.btnAddNewLdlApp_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.International_323;
            this.pictureBox2.Location = new System.Drawing.Point(330, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // ptbLdlApp
            // 
            this.ptbLdlApp.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Applications;
            this.ptbLdlApp.Location = new System.Drawing.Point(330, 12);
            this.ptbLdlApp.Name = "ptbLdlApp";
            this.ptbLdlApp.Size = new System.Drawing.Size(153, 144);
            this.ptbLdlApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLdlApp.TabIndex = 27;
            this.ptbLdlApp.TabStop = false;
            // 
            // showPersonDetilsToolStripMenuItem
            // 
            this.showPersonDetilsToolStripMenuItem.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.PersonDetails_324;
            this.showPersonDetilsToolStripMenuItem.Name = "showPersonDetilsToolStripMenuItem";
            this.showPersonDetilsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.showPersonDetilsToolStripMenuItem.Text = "Show person Detils";
            this.showPersonDetilsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetilsToolStripMenuItem_Click);
            // 
            // showLicenseDetilsToolStripMenuItem
            // 
            this.showLicenseDetilsToolStripMenuItem.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.License_View_325;
            this.showLicenseDetilsToolStripMenuItem.Name = "showLicenseDetilsToolStripMenuItem";
            this.showLicenseDetilsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.showLicenseDetilsToolStripMenuItem.Text = "Show License Detils";
            this.showLicenseDetilsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetilsToolStripMenuItem_Click);
            // 
            // showLicenseHistoryToolStripMenuItem
            // 
            this.showLicenseHistoryToolStripMenuItem.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.PersonLicenseHistory_322;
            this.showLicenseHistoryToolStripMenuItem.Name = "showLicenseHistoryToolStripMenuItem";
            this.showLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.showLicenseHistoryToolStripMenuItem.Text = "Show License History";
            this.showLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showLicenseHistoryToolStripMenuItem_Click);
            // 
            // frmInterntionalLicesesApplictions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(764, 522);
            this.Controls.Add(this.cmbIsActive);
            this.Controls.Add(this.lblNumberOfRecord);
            this.Controls.Add(this.lblRecodTitel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNewLdlApp);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cmbFilterType);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ptbLdlApp);
            this.Name = "frmInterntionalLicesesApplictions";
            this.Text = "Interntional Liceses Applictions";
            this.Load += new System.EventHandler(this.frmInterntionalLicesesApplictions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLdlApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbLdlApp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbFilterType;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Button btnAddNewLdlApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecodTitel;
        private System.Windows.Forms.Label lblNumberOfRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn InternationalLicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssuedUsingLocalLicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.ComboBox cmbIsActive;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseHistoryToolStripMenuItem;
    }
}