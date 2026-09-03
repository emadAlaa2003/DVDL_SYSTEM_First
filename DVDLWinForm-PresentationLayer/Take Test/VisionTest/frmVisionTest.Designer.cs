namespace DVDLWinForm_PresentationLayer.Take_Test.VisionTest
{
    partial class frmVisionTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisionTest));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TestAppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsLocked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNumberOfRecord = new System.Windows.Forms.Label();
            this.lblRecodTitel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAddNewLdlApp = new System.Windows.Forms.Button();
            this.ptbImgeTitel = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlAppLocalDetiels1 = new DVDLWinForm_PresentationLayer.localDrivingLicenseApplication.ctrlAppLocalDetiels();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImgeTitel)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestAppointmentID,
            this.AppointmentDate,
            this.PaidFees,
            this.IsLocked});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(9, 516);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(795, 127);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TestAppointmentID
            // 
            this.TestAppointmentID.DataPropertyName = "TestAppointmentID";
            this.TestAppointmentID.FillWeight = 300F;
            this.TestAppointmentID.HeaderText = "AppointmentID";
            this.TestAppointmentID.Name = "TestAppointmentID";
            this.TestAppointmentID.ReadOnly = true;
            // 
            // AppointmentDate
            // 
            this.AppointmentDate.DataPropertyName = "AppointmentDate";
            this.AppointmentDate.FillWeight = 250F;
            this.AppointmentDate.HeaderText = "AppointmentDate";
            this.AppointmentDate.Name = "AppointmentDate";
            this.AppointmentDate.ReadOnly = true;
            // 
            // PaidFees
            // 
            this.PaidFees.DataPropertyName = "PaidFees";
            this.PaidFees.HeaderText = "PaidFees";
            this.PaidFees.Name = "PaidFees";
            this.PaidFees.ReadOnly = true;
            // 
            // IsLocked
            // 
            this.IsLocked.DataPropertyName = "IsLocked";
            this.IsLocked.HeaderText = "IsLocked";
            this.IsLocked.Name = "IsLocked";
            this.IsLocked.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.edit_324;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeTestToolStripMenuItem.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Test_32;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // lblNumberOfRecord
            // 
            this.lblNumberOfRecord.AutoSize = true;
            this.lblNumberOfRecord.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecord.Location = new System.Drawing.Point(105, 657);
            this.lblNumberOfRecord.Name = "lblNumberOfRecord";
            this.lblNumberOfRecord.Size = new System.Drawing.Size(14, 13);
            this.lblNumberOfRecord.TabIndex = 11;
            this.lblNumberOfRecord.Text = "0";
            // 
            // lblRecodTitel
            // 
            this.lblRecodTitel.AutoSize = true;
            this.lblRecodTitel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecodTitel.Location = new System.Drawing.Point(11, 652);
            this.lblRecodTitel.Name = "lblRecodTitel";
            this.lblRecodTitel.Size = new System.Drawing.Size(93, 19);
            this.lblRecodTitel.TabIndex = 10;
            this.lblRecodTitel.Text = "#Records:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Appointmonts :";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.Red;
            this.lblTitel.Location = new System.Drawing.Point(288, 89);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(262, 29);
            this.lblTitel.TabIndex = 26;
            this.lblTitel.Text = " Vision Appointmont ";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Vision 512.png");
            this.imageList1.Images.SetKeyName(1, "Written Test 32 Sechdule.png");
            this.imageList1.Images.SetKeyName(2, "driving-test 512.png");
            // 
            // btnAddNewLdlApp
            // 
            this.btnAddNewLdlApp.FlatAppearance.BorderSize = 2;
            this.btnAddNewLdlApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewLdlApp.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.AddAppointment_32;
            this.btnAddNewLdlApp.Location = new System.Drawing.Point(772, 476);
            this.btnAddNewLdlApp.Name = "btnAddNewLdlApp";
            this.btnAddNewLdlApp.Size = new System.Drawing.Size(39, 39);
            this.btnAddNewLdlApp.TabIndex = 28;
            this.btnAddNewLdlApp.UseVisualStyleBackColor = true;
            this.btnAddNewLdlApp.Click += new System.EventHandler(this.btnAddNewLdlApp_Click);
            // 
            // ptbImgeTitel
            // 
            this.ptbImgeTitel.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Written_Test_512;
            this.ptbImgeTitel.Location = new System.Drawing.Point(337, 13);
            this.ptbImgeTitel.Name = "ptbImgeTitel";
            this.ptbImgeTitel.Size = new System.Drawing.Size(161, 86);
            this.ptbImgeTitel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbImgeTitel.TabIndex = 25;
            this.ptbImgeTitel.TabStop = false;
            this.ptbImgeTitel.Click += new System.EventHandler(this.ptbImgeTitel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(706, 645);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 36);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlAppLocalDetiels1
            // 
            this.ctrlAppLocalDetiels1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlAppLocalDetiels1.Location = new System.Drawing.Point(9, 105);
            this.ctrlAppLocalDetiels1.Name = "ctrlAppLocalDetiels1";
            this.ctrlAppLocalDetiels1.Size = new System.Drawing.Size(807, 379);
            this.ctrlAppLocalDetiels1.TabIndex = 24;
            // 
            // frmVisionTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(850, 681);
            this.Controls.Add(this.btnAddNewLdlApp);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.ptbImgeTitel);
            this.Controls.Add(this.ctrlAppLocalDetiels1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblNumberOfRecord);
            this.Controls.Add(this.lblRecodTitel);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "frmVisionTest";
            this.Text = "Vision Test";
            this.Load += new System.EventHandler(this.frmVisionTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImgeTitel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNumberOfRecord;
        private System.Windows.Forms.Label lblRecodTitel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private localDrivingLicenseApplication.ctrlAppLocalDetiels ctrlAppLocalDetiels1;
        private System.Windows.Forms.PictureBox ptbImgeTitel;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Button btnAddNewLdlApp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestAppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidFees;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsLocked;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
    }
}