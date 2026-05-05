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
            this.mstMainForm.Size = new System.Drawing.Size(800, 50);
            this.mstMainForm.TabIndex = 0;
            this.mstMainForm.Text = "menuStrip1";
            // 
            // TmsiApplication
            // 
            this.TmsiApplication.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Applications_64;
            this.TmsiApplication.Name = "TmsiApplication";
            this.TmsiApplication.Size = new System.Drawing.Size(114, 46);
            this.TmsiApplication.Text = "Applicatiens";
            // 
            // TmsiPeople
            // 
            this.TmsiPeople.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.People_400;
            this.TmsiPeople.Name = "TmsiPeople";
            this.TmsiPeople.Size = new System.Drawing.Size(85, 46);
            this.TmsiPeople.Text = "People";
            this.TmsiPeople.Click += new System.EventHandler(this.TmsiPeople_Click);
            // 
            // TmsiDrivers
            // 
            this.TmsiDrivers.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Drivers_64;
            this.TmsiDrivers.Name = "TmsiDrivers";
            this.TmsiDrivers.Size = new System.Drawing.Size(85, 46);
            this.TmsiDrivers.Text = "Drivers";
            // 
            // TmsiUsers
            // 
            this.TmsiUsers.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Users_2_4001;
            this.TmsiUsers.Name = "TmsiUsers";
            this.TmsiUsers.Size = new System.Drawing.Size(77, 46);
            this.TmsiUsers.Text = "Users";
            this.TmsiUsers.Click += new System.EventHandler(this.TmsiUsers_Click);
            // 
            // TmsiAccountSettings
            // 
            this.TmsiAccountSettings.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.account_settings_64;
            this.TmsiAccountSettings.Name = "TmsiAccountSettings";
            this.TmsiAccountSettings.Size = new System.Drawing.Size(139, 46);
            this.TmsiAccountSettings.Text = "Account Settings";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 46);
            this.toolStripMenuItem1.Text = " ";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(22, 46);
            this.toolStripMenuItem2.Text = " ";
            // 
            // MinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mstMainForm);
            this.MainMenuStrip = this.mstMainForm;
            this.Name = "MinForm";
            this.Text = "Form1";
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
    }
}

