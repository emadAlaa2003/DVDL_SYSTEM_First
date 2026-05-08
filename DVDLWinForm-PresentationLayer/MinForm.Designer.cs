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
            this.TmsiApplication.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TmsiApplication.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Applications_64;
            this.TmsiApplication.Name = "TmsiApplication";
            this.TmsiApplication.Size = new System.Drawing.Size(142, 63);
            this.TmsiApplication.Text = "Applicatiens";
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
            this.currentUserInfoToolStripMenuItem.Size = new System.Drawing.Size(199, 36);
            this.currentUserInfoToolStripMenuItem.Text = "Current User Info";
            this.currentUserInfoToolStripMenuItem.Click += new System.EventHandler(this.currentUserInfoToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordToolStripMenuItem.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Password_32;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(199, 36);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(196, 6);
            // 
            // singOutToolStripMenuItem
            // 
            this.singOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singOutToolStripMenuItem.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.sign_out_32__2;
            this.singOutToolStripMenuItem.Name = "singOutToolStripMenuItem";
            this.singOutToolStripMenuItem.Size = new System.Drawing.Size(199, 36);
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
    }
}

