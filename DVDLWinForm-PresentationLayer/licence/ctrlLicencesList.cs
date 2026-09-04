using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDLWinForm_PresentationLayer.licence
{
    public partial class ctrlLicencesList : UserControl
    {
        private int _personId = -1; 

        public ctrlLicencesList()
        {
            InitializeComponent();
        }

        private void _RefreshLicensesList()
        {
            DataTable dt = DVLDBusinessLayer.clsLicense.GetAllLicensesByPersonID(_personId);

            if (dt != null)
            {
                dgvLocalLicences.DataSource = dt;
                lblNumberOfRecord.Text = dt.Rows.Count.ToString();

                if (dgvLocalLicences.Columns.Contains("IssueDate"))
                {
                    dgvLocalLicences.Columns["IssueDate"].DefaultCellStyle.Format = "dd/MMM/yyyy";
                    dgvLocalLicences.Columns["ExpirationDate"].DefaultCellStyle.Format = "dd/MMM/yyyy";
                }
            }
            else
            {
                lblNumberOfRecord.Text = "0";
            }
        }

        private void _RefreeshIntLicenseList()
        {
            DataTable dt = DVLDBusinessLayer.clsInternationalLicense.GetAllInternationalLicensesByPersonId(_personId);

            if (dt != null)
            {
                dataGridView1.DataSource = dt;
                lblNumberOfIntRecord.Text = dt.Rows.Count.ToString();

                if (dataGridView1.Columns.Contains("IssueDate"))
                {
                    dataGridView1.Columns["IssueDate"].DefaultCellStyle.Format = "dd/MMM/yyyy";
                    dataGridView1.Columns["ExpirationDate"].DefaultCellStyle.Format = "dd/MMM/yyyy";
                }
            }
            else
            {
                lblNumberOfIntRecord.Text = "0";
            }
        }
        public void LoadInfo(int PersonID)
        {
            _personId = PersonID;
            if (_personId < 0) return;

            _RefreshLicensesList();
            _RefreeshIntLicenseList();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalLicences.CurrentRow == null || dgvLocalLicences.CurrentRow.IsNewRow)
                return;
            frmLicenceInfo frm = new frmLicenceInfo((int)dgvLocalLicences.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
