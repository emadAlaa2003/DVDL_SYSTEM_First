namespace DVDLWinForm_PresentationLayer.licence
{
    partial class frmRenewLocalDrivingLicense
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ctrlLoadLesoinInfo1 = new DVDLWinForm_PresentationLayer.licence.ctrlLoadLesoinInfo();
            this.ctrlRenewLicenseAppInfo1 = new DVDLWinForm_PresentationLayer.licence.ctrlRenewLicenseAppInfo();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lnkShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.lnkShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renew Drining Licinse Appliction";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 93);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // btnFind
            // 
            this.btnFind.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.License_View_324;
            this.btnFind.Location = new System.Drawing.Point(351, 25);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(54, 45);
            this.btnFind.TabIndex = 2;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "License ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ctrlLoadLesoinInfo1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(715, 296);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Driver License Info";
            // 
            // ctrlLoadLesoinInfo1
            // 
            this.ctrlLoadLesoinInfo1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlLoadLesoinInfo1.Location = new System.Drawing.Point(7, 19);
            this.ctrlLoadLesoinInfo1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlLoadLesoinInfo1.Name = "ctrlLoadLesoinInfo1";
            this.ctrlLoadLesoinInfo1.Size = new System.Drawing.Size(696, 269);
            this.ctrlLoadLesoinInfo1.TabIndex = 0;
            // 
            // ctrlRenewLicenseAppInfo1
            // 
            this.ctrlRenewLicenseAppInfo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrlRenewLicenseAppInfo1.Location = new System.Drawing.Point(18, 418);
            this.ctrlRenewLicenseAppInfo1.Name = "ctrlRenewLicenseAppInfo1";
            this.ctrlRenewLicenseAppInfo1.Size = new System.Drawing.Size(526, 294);
            this.ctrlRenewLicenseAppInfo1.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.IssueDrivingLicense_321;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(642, 533);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 34);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "     Issue";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(531, 533);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 34);
            this.btnClose.TabIndex = 57;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lnkShowLicensesHistory
            // 
            this.lnkShowLicensesHistory.AutoSize = true;
            this.lnkShowLicensesHistory.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkShowLicensesHistory.Location = new System.Drawing.Point(581, 617);
            this.lnkShowLicensesHistory.Name = "lnkShowLicensesHistory";
            this.lnkShowLicensesHistory.Size = new System.Drawing.Size(134, 13);
            this.lnkShowLicensesHistory.TabIndex = 58;
            this.lnkShowLicensesHistory.TabStop = true;
            this.lnkShowLicensesHistory.Text = "Show LIcenses History";
            this.lnkShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShowLicensesHistory_LinkClicked_1);
            // 
            // lnkShowLicenseInfo
            // 
            this.lnkShowLicenseInfo.AutoSize = true;
            this.lnkShowLicenseInfo.Enabled = false;
            this.lnkShowLicenseInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkShowLicenseInfo.Location = new System.Drawing.Point(591, 647);
            this.lnkShowLicenseInfo.Name = "lnkShowLicenseInfo";
            this.lnkShowLicenseInfo.Size = new System.Drawing.Size(108, 13);
            this.lnkShowLicenseInfo.TabIndex = 59;
            this.lnkShowLicenseInfo.TabStop = true;
            this.lnkShowLicenseInfo.Text = "Show License Info";
            this.lnkShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShowLicenseInfo_LinkClicked_1);
            // 
            // frmRenewLocalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(760, 712);
            this.Controls.Add(this.lnkShowLicenseInfo);
            this.Controls.Add(this.lnkShowLicensesHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctrlRenewLicenseAppInfo1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmRenewLocalDrivingLicense";
            this.Text = "Renew Local Driving License";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private ctrlLoadLesoinInfo ctrlLoadLesoinInfo1;
        private ctrlRenewLicenseAppInfo ctrlRenewLicenseAppInfo1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel lnkShowLicensesHistory;
        private System.Windows.Forms.LinkLabel lnkShowLicenseInfo;
    }
}