namespace DVDLWinForm_PresentationLayer.People
{
    partial class frmAddNewPerson
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
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblPersonId = new System.Windows.Forms.Label();
            this.lblPersonIdTitel = new System.Windows.Forms.Label();
            this.ptbNationalNo = new System.Windows.Forms.PictureBox();
            this.ctrlAdd_UpdatePerson1 = new DVDLWinForm_PresentationLayer.People.ctrlAdd_UpdatePerson();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbNationalNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Tahoma", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.Red;
            this.lblTitel.Location = new System.Drawing.Point(287, 9);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(264, 35);
            this.lblTitel.TabIndex = 1;
            this.lblTitel.Text = "Add New Person ";
            // 
            // lblPersonId
            // 
            this.lblPersonId.AutoSize = true;
            this.lblPersonId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonId.Location = new System.Drawing.Point(156, 71);
            this.lblPersonId.Name = "lblPersonId";
            this.lblPersonId.Size = new System.Drawing.Size(42, 19);
            this.lblPersonId.TabIndex = 2;
            this.lblPersonId.Text = "N/A";
            // 
            // lblPersonIdTitel
            // 
            this.lblPersonIdTitel.AutoSize = true;
            this.lblPersonIdTitel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonIdTitel.Location = new System.Drawing.Point(21, 71);
            this.lblPersonIdTitel.Name = "lblPersonIdTitel";
            this.lblPersonIdTitel.Size = new System.Drawing.Size(91, 18);
            this.lblPersonIdTitel.TabIndex = 3;
            this.lblPersonIdTitel.Text = "Person ID :";
            // 
            // ptbNationalNo
            // 
            this.ptbNationalNo.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Number_32;
            this.ptbNationalNo.Location = new System.Drawing.Point(118, 68);
            this.ptbNationalNo.Name = "ptbNationalNo";
            this.ptbNationalNo.Size = new System.Drawing.Size(23, 22);
            this.ptbNationalNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbNationalNo.TabIndex = 31;
            this.ptbNationalNo.TabStop = false;
            // 
            // ctrlAdd_UpdatePerson1
            // 
            this.ctrlAdd_UpdatePerson1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlAdd_UpdatePerson1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlAdd_UpdatePerson1.Location = new System.Drawing.Point(12, 92);
            this.ctrlAdd_UpdatePerson1.Name = "ctrlAdd_UpdatePerson1";
            this.ctrlAdd_UpdatePerson1.Size = new System.Drawing.Size(750, 370);
            this.ctrlAdd_UpdatePerson1.TabIndex = 0;
            this.ctrlAdd_UpdatePerson1.onSavedClick += new System.Action<int>(this.ctrlAdd_UpdatePerson1_onSavedClick);
            this.ctrlAdd_UpdatePerson1.onCloseClick += new System.Action<int>(this.ctrlAdd_UpdatePerson1_onCloseClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddNewPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(779, 482);
            this.Controls.Add(this.ptbNationalNo);
            this.Controls.Add(this.lblPersonIdTitel);
            this.Controls.Add(this.lblPersonId);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.ctrlAdd_UpdatePerson1);
            this.Name = "frmAddNewPerson";
            this.Text = "Add Person";
            this.Load += new System.EventHandler(this.frmAddNewPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbNationalNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlAdd_UpdatePerson ctrlAdd_UpdatePerson1;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblPersonId;
        private System.Windows.Forms.Label lblPersonIdTitel;
        private System.Windows.Forms.PictureBox ptbNationalNo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}