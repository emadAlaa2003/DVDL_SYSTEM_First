using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVDLWinForm_PresentationLayer.Applications
{
    public partial class frmApplicationTypes : Form
    {
        public frmApplicationTypes()
        {
            InitializeComponent();
        }
        public void _RefrchApplicationTypesList()
        {
            DataTable dt = clsApplactionType.GetAllApplactionTypes();
            dgvApplicationTypes.AutoGenerateColumns = false;
            dgvApplicationTypes.DataSource = dt;
            lblNumberOfRecord.Text = dt.Rows.Count.ToString();
        }

        private void frmApplicationTypes_Load(object sender, EventArgs e)
        {
            _RefrchApplicationTypesList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplictionTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditApplictionType frm = new frmEditApplictionType((int)dgvApplicationTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefrchApplicationTypesList();
        }
    }
}
