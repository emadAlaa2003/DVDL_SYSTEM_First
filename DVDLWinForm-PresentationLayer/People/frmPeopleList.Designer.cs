namespace DVDLWinForm_PresentationLayer.People
{
    partial class frmPeopleList
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
            this.dgvAllPeople = new System.Windows.Forms.DataGridView();
            this.cmsPeopleList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowDetils = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumberOfRecord = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbFilterType = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.btnFindPerson = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddnewPerson = new System.Windows.Forms.Button();
            this.ptbPeople = new System.Windows.Forms.PictureBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPeople)).BeginInit();
            this.cmsPeopleList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllPeople
            // 
            this.dgvAllPeople.AllowUserToAddRows = false;
            this.dgvAllPeople.AllowUserToDeleteRows = false;
            this.dgvAllPeople.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAllPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllPeople.ContextMenuStrip = this.cmsPeopleList;
            this.dgvAllPeople.Location = new System.Drawing.Point(12, 219);
            this.dgvAllPeople.Name = "dgvAllPeople";
            this.dgvAllPeople.ReadOnly = true;
            this.dgvAllPeople.Size = new System.Drawing.Size(855, 231);
            this.dgvAllPeople.TabIndex = 0;
            // 
            // cmsPeopleList
            // 
            this.cmsPeopleList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowDetils,
            this.toolStripMenuItem2,
            this.tsmiAddNewPerson,
            this.tsmiEdit,
            this.tsmiDelete,
            this.toolStripMenuItem1,
            this.tsmiSendEmail,
            this.tsmiPhoneCall});
            this.cmsPeopleList.Name = "cmsPeopleList";
            this.cmsPeopleList.Size = new System.Drawing.Size(197, 266);
            // 
            // tsmiShowDetils
            // 
            this.tsmiShowDetils.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiShowDetils.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.PersonDetails_32;
            this.tsmiShowDetils.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiShowDetils.Name = "tsmiShowDetils";
            this.tsmiShowDetils.Size = new System.Drawing.Size(196, 38);
            this.tsmiShowDetils.Text = "Show Details";
            this.tsmiShowDetils.Click += new System.EventHandler(this.tsmiShowDetils_Click);
            // 
            // tsmiAddNewPerson
            // 
            this.tsmiAddNewPerson.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiAddNewPerson.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.AddPerson_32;
            this.tsmiAddNewPerson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAddNewPerson.Name = "tsmiAddNewPerson";
            this.tsmiAddNewPerson.Size = new System.Drawing.Size(196, 38);
            this.tsmiAddNewPerson.Text = " Add New Person";
            this.tsmiAddNewPerson.Click += new System.EventHandler(this.tsmiAddNewPerson_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiEdit.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.edit_32;
            this.tsmiEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(196, 38);
            this.tsmiEdit.Text = "Edit";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiDelete.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Delete_32;
            this.tsmiDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(196, 38);
            this.tsmiDelete.Text = "Delete";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // tsmiSendEmail
            // 
            this.tsmiSendEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiSendEmail.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.send_email_32;
            this.tsmiSendEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSendEmail.Name = "tsmiSendEmail";
            this.tsmiSendEmail.Size = new System.Drawing.Size(196, 38);
            this.tsmiSendEmail.Text = "send Email";
            this.tsmiSendEmail.Click += new System.EventHandler(this.tsmiSendEmail_Click);
            // 
            // tsmiPhoneCall
            // 
            this.tsmiPhoneCall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiPhoneCall.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.call_32;
            this.tsmiPhoneCall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiPhoneCall.Name = "tsmiPhoneCall";
            this.tsmiPhoneCall.Size = new System.Drawing.Size(196, 38);
            this.tsmiPhoneCall.Text = "Phone Call";
            this.tsmiPhoneCall.Click += new System.EventHandler(this.tsmiPhoneCall_Click);
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitel.Location = new System.Drawing.Point(346, 149);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(189, 32);
            this.lblTitel.TabIndex = 2;
            this.lblTitel.Text = "Mange People";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "#Records:";
            // 
            // lblNumberOfRecord
            // 
            this.lblNumberOfRecord.AutoSize = true;
            this.lblNumberOfRecord.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecord.Location = new System.Drawing.Point(120, 480);
            this.lblNumberOfRecord.Name = "lblNumberOfRecord";
            this.lblNumberOfRecord.Size = new System.Drawing.Size(14, 13);
            this.lblNumberOfRecord.TabIndex = 5;
            this.lblNumberOfRecord.Text = "0";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(22, 197);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(68, 16);
            this.lblFilter.TabIndex = 15;
            this.lblFilter.Text = "Filter By :";
            // 
            // cmbFilterType
            // 
            this.cmbFilterType.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbFilterType.FormattingEnabled = true;
            this.cmbFilterType.Items.AddRange(new object[] {
            "None",
            "Person Id",
            "National No",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Gendor",
            "Phone",
            "Email"});
            this.cmbFilterType.Location = new System.Drawing.Point(96, 196);
            this.cmbFilterType.Name = "cmbFilterType";
            this.cmbFilterType.Size = new System.Drawing.Size(135, 21);
            this.cmbFilterType.TabIndex = 16;
            this.cmbFilterType.SelectedIndexChanged += new System.EventHandler(this.cmbFilterType_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(237, 196);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(160, 20);
            this.txtFilterValue.TabIndex = 17;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.SearchPerson1;
            this.btnFindPerson.Location = new System.Drawing.Point(716, 160);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.Size = new System.Drawing.Size(53, 53);
            this.btnFindPerson.TabIndex = 18;
            this.btnFindPerson.Text = " ";
            this.btnFindPerson.UseVisualStyleBackColor = true;
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(730, 462);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 34);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddnewPerson
            // 
            this.btnAddnewPerson.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Add_Person_40;
            this.btnAddnewPerson.Location = new System.Drawing.Point(784, 160);
            this.btnAddnewPerson.Name = "btnAddnewPerson";
            this.btnAddnewPerson.Size = new System.Drawing.Size(51, 53);
            this.btnAddnewPerson.TabIndex = 3;
            this.btnAddnewPerson.Text = " ";
            this.btnAddnewPerson.UseVisualStyleBackColor = true;
            this.btnAddnewPerson.Click += new System.EventHandler(this.button1_Click);
            // 
            // ptbPeople
            // 
            this.ptbPeople.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.People_400;
            this.ptbPeople.Location = new System.Drawing.Point(352, 12);
            this.ptbPeople.Name = "ptbPeople";
            this.ptbPeople.Size = new System.Drawing.Size(174, 130);
            this.ptbPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbPeople.TabIndex = 1;
            this.ptbPeople.TabStop = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(193, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(193, 6);
            // 
            // frmPeopleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(876, 508);
            this.Controls.Add(this.btnFindPerson);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cmbFilterType);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblNumberOfRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddnewPerson);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.ptbPeople);
            this.Controls.Add(this.dgvAllPeople);
            this.Name = "frmPeopleList";
            this.Text = "Mange People";
            this.Load += new System.EventHandler(this.frmPeopleList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPeople)).EndInit();
            this.cmsPeopleList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllPeople;
        private System.Windows.Forms.PictureBox ptbPeople;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Button btnAddnewPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumberOfRecord;
        private System.Windows.Forms.ContextMenuStrip cmsPeopleList;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDetils;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNewPerson;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiSendEmail;
        private System.Windows.Forms.ToolStripMenuItem tsmiPhoneCall;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbFilterType;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Button btnFindPerson;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}