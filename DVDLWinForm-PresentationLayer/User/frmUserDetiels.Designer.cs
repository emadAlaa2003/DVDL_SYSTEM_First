namespace DVDLWinForm_PresentationLayer.User
{
    partial class frmUserDetiels
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
            this.ctrlUserDetiels1 = new DVDLWinForm_PresentationLayer.User.ctrlUserDetiels();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlUserDetiels1
            // 
            this.ctrlUserDetiels1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrlUserDetiels1.Location = new System.Drawing.Point(3, 6);
            this.ctrlUserDetiels1.Name = "ctrlUserDetiels1";
            this.ctrlUserDetiels1.Size = new System.Drawing.Size(759, 428);
            this.ctrlUserDetiels1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(664, 430);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 34);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmUserDetiels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(781, 466);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlUserDetiels1);
            this.Name = "frmUserDetiels";
            this.Text = "User Infromation";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlUserDetiels ctrlUserDetiels1;
        private System.Windows.Forms.Button btnClose;
    }
}