namespace DVDLWinForm_PresentationLayer.localDrivingLicenseApplication
{
    partial class frmAddEditeLocalDrivingApp
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
            this.tbcAddUpdateNewLocalDL = new System.Windows.Forms.TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFilter1 = new DVDLWinForm_PresentationLayer.People.ctrlPersonCardWithFilter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.cmbLicenceClass = new System.Windows.Forms.ComboBox();
            this.lblDateVlaue = new System.Windows.Forms.Label();
            this.lblAppLDID = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptbNationalNo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConformPassword = new System.Windows.Forms.Label();
            this.lbDlAppID = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitel = new System.Windows.Forms.Label();
            this.tbcAddUpdateNewLocalDL.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNationalNo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcAddUpdateNewLocalDL
            // 
            this.tbcAddUpdateNewLocalDL.Controls.Add(this.tpPersonInfo);
            this.tbcAddUpdateNewLocalDL.Controls.Add(this.tabPage2);
            this.tbcAddUpdateNewLocalDL.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcAddUpdateNewLocalDL.Location = new System.Drawing.Point(34, 58);
            this.tbcAddUpdateNewLocalDL.Name = "tbcAddUpdateNewLocalDL";
            this.tbcAddUpdateNewLocalDL.SelectedIndex = 0;
            this.tbcAddUpdateNewLocalDL.Size = new System.Drawing.Size(877, 491);
            this.tbcAddUpdateNewLocalDL.TabIndex = 0;
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpPersonInfo.Controls.Add(this.btnNext);
            this.tpPersonInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 22);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(869, 465);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Person Info";
            // 
            // btnNext
            // 
            this.btnNext.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(739, 412);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(114, 38);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(36, 36);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(817, 361);
            this.ctrlPersonCardWithFilter1.TabIndex = 1;
            this.ctrlPersonCardWithFilter1.onFindClick += new System.Action<int>(this.ctrlPersonCardWithFilter1_onFindClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage2.Controls.Add(this.lblUserName);
            this.tabPage2.Controls.Add(this.lblFees);
            this.tabPage2.Controls.Add(this.cmbLicenceClass);
            this.tabPage2.Controls.Add(this.lblDateVlaue);
            this.tabPage2.Controls.Add(this.lblAppLDID);
            this.tabPage2.Controls.Add(this.pictureBox4);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.ptbNationalNo);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lblConformPassword);
            this.tabPage2.Controls.Add(this.lbDlAppID);
            this.tabPage2.Controls.Add(this.lblPassword);
            this.tabPage2.Controls.Add(this.lblAppDate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(869, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Application Info";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(360, 218);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(47, 16);
            this.lblUserName.TabIndex = 69;
            this.lblUserName.Text = "[????]";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(360, 177);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(23, 16);
            this.lblFees.TabIndex = 68;
            this.lblFees.Text = "15";
            // 
            // cmbLicenceClass
            // 
            this.cmbLicenceClass.FormattingEnabled = true;
            this.cmbLicenceClass.Location = new System.Drawing.Point(360, 140);
            this.cmbLicenceClass.Name = "cmbLicenceClass";
            this.cmbLicenceClass.Size = new System.Drawing.Size(151, 21);
            this.cmbLicenceClass.TabIndex = 67;
            // 
            // lblDateVlaue
            // 
            this.lblDateVlaue.AutoSize = true;
            this.lblDateVlaue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateVlaue.Location = new System.Drawing.Point(360, 106);
            this.lblDateVlaue.Name = "lblDateVlaue";
            this.lblDateVlaue.Size = new System.Drawing.Size(47, 16);
            this.lblDateVlaue.TabIndex = 65;
            this.lblDateVlaue.Text = "[????]";
            // 
            // lblAppLDID
            // 
            this.lblAppLDID.AutoSize = true;
            this.lblAppLDID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppLDID.Location = new System.Drawing.Point(360, 72);
            this.lblAppLDID.Name = "lblAppLDID";
            this.lblAppLDID.Size = new System.Drawing.Size(47, 16);
            this.lblAppLDID.TabIndex = 64;
            this.lblAppLDID.Text = "[????]";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.User_32__2;
            this.pictureBox4.Location = new System.Drawing.Point(317, 212);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 63;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.money_321;
            this.pictureBox3.Location = new System.Drawing.Point(317, 171);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 62;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.License_Type_32;
            this.pictureBox2.Location = new System.Drawing.Point(317, 135);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Calendar_321;
            this.pictureBox1.Location = new System.Drawing.Point(317, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // ptbNationalNo
            // 
            this.ptbNationalNo.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Number_32;
            this.ptbNationalNo.Location = new System.Drawing.Point(317, 70);
            this.ptbNationalNo.Name = "ptbNationalNo";
            this.ptbNationalNo.Size = new System.Drawing.Size(23, 22);
            this.ptbNationalNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbNationalNo.TabIndex = 59;
            this.ptbNationalNo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 58;
            this.label1.Text = "Created By :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblConformPassword
            // 
            this.lblConformPassword.AutoSize = true;
            this.lblConformPassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConformPassword.Location = new System.Drawing.Point(146, 171);
            this.lblConformPassword.Name = "lblConformPassword";
            this.lblConformPassword.Size = new System.Drawing.Size(139, 18);
            this.lblConformPassword.TabIndex = 57;
            this.lblConformPassword.Text = "Application Fess :";
            // 
            // lbDlAppID
            // 
            this.lbDlAppID.AutoSize = true;
            this.lbDlAppID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDlAppID.Location = new System.Drawing.Point(146, 70);
            this.lbDlAppID.Name = "lbDlAppID";
            this.lbDlAppID.Size = new System.Drawing.Size(152, 18);
            this.lbDlAppID.TabIndex = 56;
            this.lbDlAppID.Text = "D.L Application ID :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(146, 135);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(116, 18);
            this.lblPassword.TabIndex = 55;
            this.lblPassword.Text = "License class :";
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAppDate.ImageKey = "(none)";
            this.lblAppDate.Location = new System.Drawing.Point(146, 100);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(140, 18);
            this.lblAppDate.TabIndex = 54;
            this.lblAppDate.Text = "Application Date :";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(813, 555);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 34);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = " Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(702, 555);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 34);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.Crimson;
            this.lblTitel.Location = new System.Drawing.Point(157, 9);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(650, 35);
            this.lblTitel.TabIndex = 19;
            this.lblTitel.Text = "NEW LOCAL DRIVING LICENSE Application ";
            // 
            // frmAddEditeLocalDrivingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(927, 614);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbcAddUpdateNewLocalDL);
            this.Name = "frmAddEditeLocalDrivingApp";
            this.Text = "Add Local Driving Lessons";
            this.Load += new System.EventHandler(this.frmAddEditeLocalDrivingApp_Load);
            this.tbcAddUpdateNewLocalDL.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNationalNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcAddUpdateNewLocalDL;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.TabPage tabPage2;
        private People.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConformPassword;
        private System.Windows.Forms.Label lbDlAppID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptbNationalNo;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.ComboBox cmbLicenceClass;
        private System.Windows.Forms.Label lblDateVlaue;
        private System.Windows.Forms.Label lblAppLDID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitel;
    }
}