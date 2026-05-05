namespace DVDLWinForm_PresentationLayer.User
{
    partial class ctrlUserDetiels
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
            this.ctrlPersonDetiels1 = new DVDLWinForm_PresentationLayer.People.ctrlPersonDetiels();
            this.gbUserInformation = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblUserIDTitel = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUserNameTitel = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblIsActiveTitel = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.gbUserInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlPersonDetiels1
            // 
            this.ctrlPersonDetiels1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlPersonDetiels1.Location = new System.Drawing.Point(16, 12);
            this.ctrlPersonDetiels1.Name = "ctrlPersonDetiels1";
            this.ctrlPersonDetiels1.Size = new System.Drawing.Size(711, 288);
            this.ctrlPersonDetiels1.TabIndex = 0;
            // 
            // gbUserInformation
            // 
            this.gbUserInformation.Controls.Add(this.lblIsActive);
            this.gbUserInformation.Controls.Add(this.lblIsActiveTitel);
            this.gbUserInformation.Controls.Add(this.lblUserName);
            this.gbUserInformation.Controls.Add(this.lblUserNameTitel);
            this.gbUserInformation.Controls.Add(this.lblUserID);
            this.gbUserInformation.Controls.Add(this.lblUserIDTitel);
            this.gbUserInformation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUserInformation.Location = new System.Drawing.Point(16, 306);
            this.gbUserInformation.Name = "gbUserInformation";
            this.gbUserInformation.Size = new System.Drawing.Size(711, 111);
            this.gbUserInformation.TabIndex = 1;
            this.gbUserInformation.TabStop = false;
            this.gbUserInformation.Text = "User Information";
            // 
            // lblUserIDTitel
            // 
            this.lblUserIDTitel.AutoSize = true;
            this.lblUserIDTitel.Location = new System.Drawing.Point(97, 47);
            this.lblUserIDTitel.Name = "lblUserIDTitel";
            this.lblUserIDTitel.Size = new System.Drawing.Size(55, 13);
            this.lblUserIDTitel.TabIndex = 0;
            this.lblUserIDTitel.Text = "User ID :";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(160, 47);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(19, 13);
            this.lblUserID.TabIndex = 1;
            this.lblUserID.Text = "??";
            // 
            // lblUserNameTitel
            // 
            this.lblUserNameTitel.AutoSize = true;
            this.lblUserNameTitel.Location = new System.Drawing.Point(263, 47);
            this.lblUserNameTitel.Name = "lblUserNameTitel";
            this.lblUserNameTitel.Size = new System.Drawing.Size(74, 13);
            this.lblUserNameTitel.TabIndex = 2;
            this.lblUserNameTitel.Text = "User Name :";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(353, 47);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(25, 13);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "???";
            // 
            // lblIsActiveTitel
            // 
            this.lblIsActiveTitel.AutoSize = true;
            this.lblIsActiveTitel.Location = new System.Drawing.Point(468, 47);
            this.lblIsActiveTitel.Name = "lblIsActiveTitel";
            this.lblIsActiveTitel.Size = new System.Drawing.Size(63, 13);
            this.lblIsActiveTitel.TabIndex = 4;
            this.lblIsActiveTitel.Text = "Is Active :";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Location = new System.Drawing.Point(550, 47);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(19, 13);
            this.lblIsActive.TabIndex = 5;
            this.lblIsActive.Text = "??";
            // 
            // ctrlUserDetiels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.gbUserInformation);
            this.Controls.Add(this.ctrlPersonDetiels1);
            this.Name = "ctrlUserDetiels";
            this.Size = new System.Drawing.Size(745, 456);
            this.Load += new System.EventHandler(this.ctrlUserDetiels_Load);
            this.gbUserInformation.ResumeLayout(false);
            this.gbUserInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private People.ctrlPersonDetiels ctrlPersonDetiels1;
        private System.Windows.Forms.GroupBox gbUserInformation;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lblIsActiveTitel;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserNameTitel;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblUserIDTitel;
    }
}
