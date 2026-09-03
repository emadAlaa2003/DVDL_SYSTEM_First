namespace DVDLWinForm_PresentationLayer.localDrivingLicenseApplication
{
    partial class frmLocalDrivingLicensesAppInfo
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
            this.lblTitel = new System.Windows.Forms.Label();
            this.ctrlAppLocalDetiels1 = new DVDLWinForm_PresentationLayer.localDrivingLicenseApplication.ctrlAppLocalDetiels();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.BackColor = System.Drawing.Color.Cornsilk;
            this.lblTitel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.Red;
            this.lblTitel.Location = new System.Drawing.Point(234, 26);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(371, 25);
            this.lblTitel.TabIndex = 1;
            this.lblTitel.Text = "Local Driving Licenses AppLiaction";
            // 
            // ctrlAppLocalDetiels1
            // 
            this.ctrlAppLocalDetiels1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlAppLocalDetiels1.Location = new System.Drawing.Point(12, 66);
            this.ctrlAppLocalDetiels1.Name = "ctrlAppLocalDetiels1";
            this.ctrlAppLocalDetiels1.Size = new System.Drawing.Size(813, 394);
            this.ctrlAppLocalDetiels1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(720, 466);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 34);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmLocalDrivingLicensesAppInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(827, 506);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.ctrlAppLocalDetiels1);
            this.Name = "frmLocalDrivingLicensesAppInfo";
            this.Text = "Local Driving Licenses App Info ";
            this.Load += new System.EventHandler(this.frmLocalDrivingLicensesAppInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlAppLocalDetiels ctrlAppLocalDetiels1;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Button btnClose;
    }
}