namespace DVDLWinForm_PresentationLayer.Applications
{
    partial class frmApplicationTypes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvApplicationTypes = new System.Windows.Forms.DataGridView();
            this.ApplicationTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationTypeTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editApplictionTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHedear = new System.Windows.Forms.Label();
            this.lblNumberOfRecord = new System.Windows.Forms.Label();
            this.lblRecodTitel = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvApplicationTypes
            // 
            this.dgvApplicationTypes.AllowUserToAddRows = false;
            this.dgvApplicationTypes.AllowUserToDeleteRows = false;
            this.dgvApplicationTypes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplicationTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApplicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicationTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApplicationTypeID,
            this.ApplicationTypeTitle,
            this.ApplicationFees});
            this.dgvApplicationTypes.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvApplicationTypes.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvApplicationTypes.Location = new System.Drawing.Point(26, 201);
            this.dgvApplicationTypes.Name = "dgvApplicationTypes";
            this.dgvApplicationTypes.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplicationTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvApplicationTypes.Size = new System.Drawing.Size(431, 249);
            this.dgvApplicationTypes.TabIndex = 0;
            // 
            // ApplicationTypeID
            // 
            this.ApplicationTypeID.DataPropertyName = "ApplicationTypeID";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationTypeID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ApplicationTypeID.HeaderText = "ID";
            this.ApplicationTypeID.Name = "ApplicationTypeID";
            this.ApplicationTypeID.ReadOnly = true;
            this.ApplicationTypeID.Width = 46;
            // 
            // ApplicationTypeTitle
            // 
            this.ApplicationTypeTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ApplicationTypeTitle.DataPropertyName = "ApplicationTypeTitle";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationTypeTitle.DefaultCellStyle = dataGridViewCellStyle3;
            this.ApplicationTypeTitle.FillWeight = 150F;
            this.ApplicationTypeTitle.HeaderText = "Tile";
            this.ApplicationTypeTitle.Name = "ApplicationTypeTitle";
            this.ApplicationTypeTitle.ReadOnly = true;
            this.ApplicationTypeTitle.Width = 53;
            // 
            // ApplicationFees
            // 
            this.ApplicationFees.DataPropertyName = "ApplicationFees";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationFees.DefaultCellStyle = dataGridViewCellStyle4;
            this.ApplicationFees.HeaderText = "Fees";
            this.ApplicationFees.Name = "ApplicationFees";
            this.ApplicationFees.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editApplictionTypeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 48);
            // 
            // editApplictionTypeToolStripMenuItem
            // 
            this.editApplictionTypeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editApplictionTypeToolStripMenuItem.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.edit_322;
            this.editApplictionTypeToolStripMenuItem.Name = "editApplictionTypeToolStripMenuItem";
            this.editApplictionTypeToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.editApplictionTypeToolStripMenuItem.Text = "Edit Appliction Type";
            this.editApplictionTypeToolStripMenuItem.Click += new System.EventHandler(this.editApplictionTypeToolStripMenuItem_Click);
            // 
            // lblHedear
            // 
            this.lblHedear.AutoSize = true;
            this.lblHedear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHedear.ForeColor = System.Drawing.Color.Red;
            this.lblHedear.Location = new System.Drawing.Point(161, 162);
            this.lblHedear.Name = "lblHedear";
            this.lblHedear.Size = new System.Drawing.Size(201, 19);
            this.lblHedear.TabIndex = 2;
            this.lblHedear.Text = "Mange Appliclion Types";
            // 
            // lblNumberOfRecord
            // 
            this.lblNumberOfRecord.AutoSize = true;
            this.lblNumberOfRecord.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecord.Location = new System.Drawing.Point(111, 468);
            this.lblNumberOfRecord.Name = "lblNumberOfRecord";
            this.lblNumberOfRecord.Size = new System.Drawing.Size(14, 13);
            this.lblNumberOfRecord.TabIndex = 9;
            this.lblNumberOfRecord.Text = "0";
            // 
            // lblRecodTitel
            // 
            this.lblRecodTitel.AutoSize = true;
            this.lblRecodTitel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecodTitel.Location = new System.Drawing.Point(12, 462);
            this.lblRecodTitel.Name = "lblRecodTitel";
            this.lblRecodTitel.Size = new System.Drawing.Size(93, 19);
            this.lblRecodTitel.TabIndex = 8;
            this.lblRecodTitel.Text = "#Records:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(352, 456);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 34);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVDLWinForm_PresentationLayer.Properties.Resources.Application_Types_512;
            this.pictureBox1.Location = new System.Drawing.Point(185, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(486, 494);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblNumberOfRecord);
            this.Controls.Add(this.lblRecodTitel);
            this.Controls.Add(this.lblHedear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvApplicationTypes);
            this.Name = "frmApplicationTypes";
            this.Text = "Application Types";
            this.Load += new System.EventHandler(this.frmApplicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvApplicationTypes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHedear;
        private System.Windows.Forms.Label lblNumberOfRecord;
        private System.Windows.Forms.Label lblRecodTitel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationTypeTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationFees;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editApplictionTypeToolStripMenuItem;
    }
}