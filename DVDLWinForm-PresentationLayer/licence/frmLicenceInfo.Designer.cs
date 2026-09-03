namespace DVDLWinForm_PresentationLayer.licence
{
    partial class frmLicenceInfo
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
            this.ctrlLoadLesoinInfo1 = new DVDLWinForm_PresentationLayer.licence.ctrlLoadLesoinInfo();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlLoadLesoinInfo1
            // 
            this.ctrlLoadLesoinInfo1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlLoadLesoinInfo1.Location = new System.Drawing.Point(12, 12);
            this.ctrlLoadLesoinInfo1.Name = "ctrlLoadLesoinInfo1";
            this.ctrlLoadLesoinInfo1.Size = new System.Drawing.Size(687, 316);
            this.ctrlLoadLesoinInfo1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(594, 335);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 34);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmLicenceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(737, 381);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlLoadLesoinInfo1);
            this.Name = "frmLicenceInfo";
            this.Text = " Licence Info";
            this.Load += new System.EventHandler(this.frmLicenceInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlLoadLesoinInfo ctrlLoadLesoinInfo1;
        private System.Windows.Forms.Button btnClose;
    }
}