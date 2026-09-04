using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVDLWinForm_PresentationLayer.licence;
using DVDLWinForm_PresentationLayer.localDrivingLicenseApplication;
using DVDLWinForm_PresentationLayer.People;
using DVLDBusinessLayer;

namespace DVDLWinForm_PresentationLayer.InternationalLicenses
{
    public partial class frmInterntionalLicesesApplictions : Form
    {
        public frmInterntionalLicesesApplictions()
        {
            InitializeComponent();
        }
        private DataTable _dtInternationalLicenses;
        private void _RefershLocalDrivingList()
        {
            _dtInternationalLicenses = DVLDBusinessLayer.clsInternationalLicense.GetAllInternationalLicenses();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = _dtInternationalLicenses;
            lblNumberOfRecord.Text = _dtInternationalLicenses.Rows.Count.ToString();
        }
        private string _GetFilterColumnName()
        {
            string FilterColumn;
            switch (cmbFilterType.Text)
            {
                case "International License ID": FilterColumn = "InternationalLicenseID"; break;
                case "Application ID": FilterColumn = "ApplicationID"; break;
                case "Driver ID": FilterColumn = "DriverID"; break;
                case "Local License ID": FilterColumn = "IssuedUsingLocalLicenseID"; break;
                case "Is Active": FilterColumn = "IsActive"; break;
                default: FilterColumn = "None"; break;
            }
            return FilterColumn;
        }

        private void _Filter()
        {
            string ColmName = _GetFilterColumnName();

            if (ColmName == "None")
            {
                dataGridView1.DataSource = _dtInternationalLicenses;
                lblNumberOfRecord.Text = dataGridView1.Rows.Count.ToString();
                return;
            }

            DataRow[] ResultRows;

            if (ColmName == "IsActive")
            {
                if (cmbIsActive.Text == "Yes")
                {
                    ResultRows = _dtInternationalLicenses.Select("[" + ColmName + "] = 1");
                }
                else if (cmbIsActive.Text == "No")
                {
                    ResultRows = _dtInternationalLicenses.Select("[" + ColmName + "] = 0");
                }
                else
                {
                    ResultRows = _dtInternationalLicenses.Select(); 
                }
            }

            else
            {
                if (string.IsNullOrWhiteSpace(txtFilterValue.Text))
                {
                    dataGridView1.DataSource = _dtInternationalLicenses;
                    lblNumberOfRecord.Text = dataGridView1.Rows.Count.ToString();
                    return;
                }

                if (int.TryParse(txtFilterValue.Text.Trim(), out int id))
                {
                    ResultRows = _dtInternationalLicenses.Select("[" + ColmName + "] = " + id);
                }
                else
                {
                    ResultRows = new DataRow[0];
                }
            }

            if (ResultRows.Length > 0)
            {
                DataTable dtFiltered = ResultRows.CopyToDataTable();
                dataGridView1.DataSource = dtFiltered;
                lblNumberOfRecord.Text = dataGridView1.Rows.Count.ToString();
            }
            else
            {
                dataGridView1.DataSource = _dtInternationalLicenses.Clone();
                lblNumberOfRecord.Text = "0";
            }
        }

        private void btnAddNewLdlApp_Click(object sender, EventArgs e)
        {
            frmNewInterationalLicenseApplication frm=new frmNewInterationalLicenseApplication();
            frm.ShowDialog();
            _RefershLocalDrivingList();
        }

        private void frmInterntionalLicesesApplictions_Load(object sender, EventArgs e)
        {
            _RefershLocalDrivingList();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _Filter();
        }

        private void cmbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Filter();
        }

        private void cmbFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterType.Text == "None")
            {
                txtFilterValue.Visible = false;
                cmbIsActive.Visible = false;

                txtFilterValue.Text = "";
            }
            else if (cmbFilterType.Text == "Is Active")
            {
                txtFilterValue.Visible = false;
                cmbIsActive.Visible = true;
                cmbIsActive.SelectedIndex = 0; 
            }
            else
            {
                txtFilterValue.Visible = true;
                cmbIsActive.Visible = false;
                txtFilterValue.Text = "";
                txtFilterValue.Focus(); 
            }

            _Filter();
        }

        private void showPersonDetilsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
                return;
            clsDriver dr = clsDriver.Find((int)dataGridView1.CurrentRow.Cells[2].Value);
            if(dr == null) return;
            frmPersonInfo frm = new frmPersonInfo(dr.PersonID);
            frm.ShowDialog();
            _RefershLocalDrivingList();
        }

        private void showLicenseDetilsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
                return;
            frmInternationalLicenseInfo frm = new frmInternationalLicenseInfo((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefershLocalDrivingList();
        }

        private void showLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
                return;
            clsDriver dr = clsDriver.Find((int)dataGridView1.CurrentRow.Cells[2].Value);
            if (dr == null) return;
            frmLicenseHistory frm = new frmLicenseHistory(dr.PersonID,true);
            frm.ShowDialog();
            _RefershLocalDrivingList();
        }
    }
}
