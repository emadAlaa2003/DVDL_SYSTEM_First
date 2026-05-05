namespace DVDLWinForm_PresentationLayer.People
{
    partial class ctrlPersonCardWithFilter
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
            this.grbFilter = new System.Windows.Forms.GroupBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnFindPerson = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.cmbFindby = new System.Windows.Forms.ComboBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.ctrlPersonDetiels1 = new DVDLWinForm_PresentationLayer.People.ctrlPersonDetiels();
            this.grbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbFilter
            // 
            this.grbFilter.Controls.Add(this.btnAddPerson);
            this.grbFilter.Controls.Add(this.btnFindPerson);
            this.grbFilter.Controls.Add(this.txtFind);
            this.grbFilter.Controls.Add(this.cmbFindby);
            this.grbFilter.Controls.Add(this.lblFind);
            this.grbFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFilter.Location = new System.Drawing.Point(3, 15);
            this.grbFilter.Name = "grbFilter";
            this.grbFilter.Size = new System.Drawing.Size(700, 75);
            this.grbFilter.TabIndex = 1;
            this.grbFilter.TabStop = false;
            this.grbFilter.Text = "Filter";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.AddPerson_321;
            this.btnAddPerson.Location = new System.Drawing.Point(495, 27);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(40, 36);
            this.btnAddPerson.TabIndex = 4;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.SearchPerson;
            this.btnFindPerson.Location = new System.Drawing.Point(440, 26);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.Size = new System.Drawing.Size(40, 36);
            this.btnFindPerson.TabIndex = 0;
            this.btnFindPerson.UseVisualStyleBackColor = true;
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(253, 34);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(160, 23);
            this.txtFind.TabIndex = 2;
            this.txtFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFind_KeyPress);
            // 
            // cmbFindby
            // 
            this.cmbFindby.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbFindby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFindby.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFindby.FormattingEnabled = true;
            this.cmbFindby.Items.AddRange(new object[] {
            "Person ID",
            "National No"});
            this.cmbFindby.Location = new System.Drawing.Point(86, 33);
            this.cmbFindby.Name = "cmbFindby";
            this.cmbFindby.Size = new System.Drawing.Size(161, 24);
            this.cmbFindby.TabIndex = 1;
            this.cmbFindby.SelectedIndexChanged += new System.EventHandler(this.cmbFindby_SelectedIndexChanged);
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFind.Location = new System.Drawing.Point(17, 37);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(63, 14);
            this.lblFind.TabIndex = 0;
            this.lblFind.Text = "Find By : ";
            // 
            // ctrlPersonDetiels1
            // 
            this.ctrlPersonDetiels1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlPersonDetiels1.Location = new System.Drawing.Point(3, 96);
            this.ctrlPersonDetiels1.Name = "ctrlPersonDetiels1";
            this.ctrlPersonDetiels1.Size = new System.Drawing.Size(703, 289);
            this.ctrlPersonDetiels1.TabIndex = 0;
            // 
            // ctrlPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.grbFilter);
            this.Controls.Add(this.ctrlPersonDetiels1);
            this.Name = "ctrlPersonCardWithFilter";
            this.Size = new System.Drawing.Size(722, 408);
            this.Load += new System.EventHandler(this.ctrlPersonCardWithFilter_Load);
            this.grbFilter.ResumeLayout(false);
            this.grbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonDetiels ctrlPersonDetiels1;
        private System.Windows.Forms.GroupBox grbFilter;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.ComboBox cmbFindby;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnFindPerson;
    }
}
