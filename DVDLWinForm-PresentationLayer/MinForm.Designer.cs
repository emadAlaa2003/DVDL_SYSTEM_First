namespace DVDLWinForm_PresentationLayer
{
    partial class MinForm
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
            this.mstMainForm = new System.Windows.Forms.MenuStrip();
            this.TmsiApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingLicensesServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renwDrivingLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLiceneseApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interntionalLicensesApplictonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TmsiPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.TmsiDrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.TmsiUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.TmsiAccountSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.singOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mstMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstMainForm
            // 
            this.mstMainForm.AutoSize = false;
            this.mstMainForm.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.mstMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TmsiApplication,
            this.TmsiPeople,
            this.TmsiDrivers,
            this.TmsiUsers,
            this.TmsiAccountSettings,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.mstMainForm.Location = new System.Drawing.Point(0, 0);
            this.mstMainForm.Name = "mstMainForm";
            this.mstMainForm.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.mstMainForm.Size = new System.Drawing.Size(1200, 69);
            this.mstMainForm.TabIndex = 0;
            this.mstMainForm.Text = "menuStrip1";
            // 
            // TmsiApplication
            // 
            this.TmsiApplication.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLicensesServicesToolStripMenuItem,
            this.manageApplicationsToolStripMenuItem,
            this.detainLicensesToolStripMenuItem,
            this.manageApplicationTypesToolStripMenuItem,
            this.manageTestTypesToolStripMenuItem});
            this.TmsiApplication.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TmsiApplication.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Applications_64;
            this.TmsiApplication.Name = "TmsiApplication";
            this.TmsiApplication.Size = new System.Drawing.Size(142, 63);
            this.TmsiApplication.Text = "Applicatiens";
            // 
            // drivingLicensesServicesToolStripMenuItem
            // 
            this.drivingLicensesServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicensesToolStripMenuItem,
            this.renwDrivingLicensesToolStripMenuItem});
            this.drivingLicensesServicesToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drivingLicensesServicesToolStripMenuItem.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.License_View_32;
            this.drivingLicensesServicesToolStripMenuItem.Name = "drivingLicensesServicesToolStripMenuItem";
            this.drivingLicensesServicesToolStripMenuItem.Size = new System.Drawing.Size(237, 36);
            this.drivingLicensesServicesToolStripMenuItem.Text = "Driving Licenses Services";
            // 
            // newDrivingLicensesToolStripMenuItem
            // 
            this.newDrivingLicensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicensesToolStripMenuItem,
            this.internationalLicensesToolStripMenuItem});
            this.newDrivingLicensesToolStripMenuItem.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.New_Driving_License_32;
            this.newDrivingLicensesToolStripMenuItem.Name = "newDrivingLicensesToolStripMenuItem";
            this.newDrivingLicensesToolStripMenuItem.Size = new System.Drawing.Size(213, 36);
            this.newDrivingLicensesToolStripMenuItem.Text = "New Driving Licenses";
            // 
            // localLicensesToolStripMenuItem
            // 
            this.localLicensesToolStripMenuItem.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Local_32;
            this.localLicensesToolStripMenuItem.Name = "localLicensesToolStripMenuItem";
            this.localLicensesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.localLicensesToolStripMenuItem.Text = "Local Licenses";
            this.localLicensesToolStripMenuItem.Click += new System.EventHandler(this.localLicensesToolStripMenuItem_Click);
            // 
            // internationalLicensesToolStripMenuItem
            // 
            this.internationalLicensesToolStripMenuItem.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.International_321;
            this.internationalLicensesToolStripMenuItem.Name = "internationalLicensesToolStripMenuItem";
            this.internationalLicensesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.internationalLicensesToolStripMenuItem.Text = "international Licenses";
            this.internationalLicensesToolStripMenuItem.Click += new System.EventHandler(this.internationalLicensesToolStripMenuItem_Click);
            // 
            // renwDrivingLicensesToolStripMenuItem
            // 
            this.renwDrivingLicensesToolStripMenuItem.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Renew_Driving_License_321;
            this.renwDrivingLicensesToolStripMenuItem.Name = "renwDrivingLicensesToolStripMenuItem";
            this.renwDrivingLicensesToolStripMenuItem.Size = new System.Drawing.Size(213, 36);
            this.renwDrivingLicensesToolStripMenuItem.Text = "Renw Driving Licenses";
            this.renwDrivingLicensesToolStripMenuItem.Click += new System.EventHandler(this.renwDrivingLicensesToolStripMenuItem_Click);
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLiceneseApplicationToolStripMenuItem,
            this.interntionalLicensesApplictonsToolStripMenuItem});
            this.manageApplicationsToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageApplicationsToolStripMenuItem.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Manage_Applications_32;
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(237, 36);
            this.manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // localDrivingLiceneseApplicationToolStripMenuItem
            // 
            this.localDrivingLiceneseApplicationToolStripMenuItem.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.LocalDriving_License1;
            this.localDrivingLiceneseApplicationToolStripMenuItem.Name = "localDrivingLiceneseApplicationToolStripMenuItem";
            this.localDrivingLiceneseApplicationToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.localDrivingLiceneseApplicationToolStripMenuItem.Text = "Local Driving Licenese Application";
            this.localDrivingLiceneseApplicationToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLiceneseApplicationToolStripMenuItem_Click);
            // 
            // interntionalLicensesApplictonsToolStripMenuItem
            // 
            this.interntionalLicensesApplictonsToolStripMenuItem.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.International_324;
            this.interntionalLicensesApplictonsToolStripMenuItem.Name = "interntionalLicensesApplictonsToolStripMenuItem";
            this.interntionalLicensesApplictonsToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.interntionalLicensesApplictonsToolStripMenuItem.Text = "Interntional Licenses Applictons";
            this.interntionalLicensesApplictonsToolStripMenuItem.Click += new System.EventHandler(this.interntionalLicensesApplictonsToolStripMenuItem_Click);
            // 
            // detainLicensesToolStripMenuItem
            // 
            this.detainLicensesToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detainLicensesToolStripMenuItem.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Detain_32;
            this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(237, 36);
            this.detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            this.manageApplicationTypesToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageApplicationTypesToolStripMenuItem.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Application_Types_64;
            this.manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            this.manageApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(237, 36);
            this.manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            this.manageApplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationTypesToolStripMenuItem_Click);
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageTestTypesToolStripMenuItem.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.TestType_32;
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(237, 36);
            this.manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            this.manageTestTypesToolStripMenuItem.Click += new System.EventHandler(this.manageTestTypesToolStripMenuItem_Click);
            // 
            // TmsiPeople
            // 
            this.TmsiPeople.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TmsiPeople.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.People_400;
            this.TmsiPeople.Name = "TmsiPeople";
            this.TmsiPeople.Size = new System.Drawing.Size(101, 63);
            this.TmsiPeople.Text = "People";
            this.TmsiPeople.Click += new System.EventHandler(this.TmsiPeople_Click);
            // 
            // TmsiDrivers
            // 
            this.TmsiDrivers.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TmsiDrivers.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Drivers_64;
            this.TmsiDrivers.Name = "TmsiDrivers";
            this.TmsiDrivers.Size = new System.Drawing.Size(106, 63);
            this.TmsiDrivers.Text = "Drivers";
            this.TmsiDrivers.Click += new System.EventHandler(this.TmsiDrivers_Click);
            // 
            // TmsiUsers
            // 
            this.TmsiUsers.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TmsiUsers.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Users_2_4001;
            this.TmsiUsers.Name = "TmsiUsers";
            this.TmsiUsers.Size = new System.Drawing.Size(90, 63);
            this.TmsiUsers.Text = "Users";
            this.TmsiUsers.Click += new System.EventHandler(this.TmsiUsers_Click);
            // 
            // TmsiAccountSettings
            // 
            this.TmsiAccountSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripMenuItem3,
            this.singOutToolStripMenuItem});
            this.TmsiAccountSettings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TmsiAccountSettings.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.account_settings_64;
            this.TmsiAccountSettings.Name = "TmsiAccountSettings";
            this.TmsiAccountSettings.Size = new System.Drawing.Size(170, 63);
            this.TmsiAccountSettings.Text = "Account Settings";
            // 
            // currentUserInfoToolStripMenuItem
            // 
            this.currentUserInfoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserInfoToolStripMenuItem.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.PersonDetails_32;
            this.currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            this.currentUserInfoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.currentUserInfoToolStripMenuItem.Text = "Current User Info";
            this.currentUserInfoToolStripMenuItem.Click += new System.EventHandler(this.currentUserInfoToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordToolStripMenuItem.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Password_32;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(182, 6);
            // 
            // singOutToolStripMenuItem
            // 
            this.singOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singOutToolStripMenuItem.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.sign_out_32__2;
            this.singOutToolStripMenuItem.Name = "singOutToolStripMenuItem";
            this.singOutToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.singOutToolStripMenuItem.Text = "Sing out";
            this.singOutToolStripMenuItem.Click += new System.EventHandler(this.singOutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 63);
            this.toolStripMenuItem1.Text = " ";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(22, 63);
            this.toolStripMenuItem2.Text = " ";
            // 
            // MinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DVDLWinForm_PresentationLayer.Properties.Resources.Logo_Final1;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.mstMainForm);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mstMainForm;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MinForm_FormClosed);
            this.mstMainForm.ResumeLayout(false);
            this.mstMainForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstMainForm;
        private System.Windows.Forms.ToolStripMenuItem TmsiApplication;
        private System.Windows.Forms.ToolStripMenuItem TmsiPeople;
        private System.Windows.Forms.ToolStripMenuItem TmsiDrivers;
        private System.Windows.Forms.ToolStripMenuItem TmsiUsers;
        private System.Windows.Forms.ToolStripMenuItem TmsiAccountSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem singOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivingLicensesServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLiceneseApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interntionalLicensesApplictonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renwDrivingLicensesToolStripMenuItem;
    }
}

