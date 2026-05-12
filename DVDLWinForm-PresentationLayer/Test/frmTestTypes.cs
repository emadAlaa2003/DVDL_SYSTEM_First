using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVDLWinForm_PresentationLayer.Applications;
using DVLDBusinessLayer;

namespace DVDLWinForm_PresentationLayer.Test
{
    public partial class frmTestTypes : Form
    {
        public void _RefrchTestTypesList()
        {
            DataTable dt = clsTestType.GetAllTestTypes();
            dgvTestTypes.AutoGenerateColumns = false;
            dgvTestTypes.DataSource = dt;
            lblNumberOfRecord.Text = dt.Rows.Count.ToString();
        }
        public frmTestTypes()
        {
            InitializeComponent();
        }

        private void frmTestTypes_Load(object sender, EventArgs e)
        {
            _RefrchTestTypesList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
        private void lblHedear_Click(object sender, EventArgs e)
        {

        }

        private void editApplictionTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateTestType frm = new frmUpdateTestType((int)dgvTestTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefrchTestTypesList();
        }
    }
}
