using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DVDLWinForm_PresentationLayer.Applications;
using DVDLWinForm_PresentationLayer.licence;
using DVDLWinForm_PresentationLayer.People;
using DVDLWinForm_PresentationLayer.Take_Test.VisionTest;
using DVLDBusinessLayer;

namespace DVDLWinForm_PresentationLayer.localDrivingLicenseApplication
{
    public partial class frmListLocalDrivingLicenseApplactions : Form
    {
        private DataTable _dtAllldlApp = DVLDBusinessLayer.clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
        public enum enAppStatus
        {
            New = 1,
            Cancelled = 2,
            Completed = 3
        }
        public enum enTestType
        {
            Vision = 1,
            Written = 2,
            Practical = 3
        }
        public frmListLocalDrivingLicenseApplactions()
        {
            InitializeComponent();
        }

        private void lblNumberOfRecord_Click(object sender, EventArgs e)
        {

        }

        private void lblRecodTitel_Click(object sender, EventArgs e)
        {

        }
        private void _RefershLocalDrivingList()
        {
            DataTable dt = DVLDBusinessLayer.clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
            lblNumberOfRecord.Text = dt.Rows.Count.ToString();
        }
        private void frmListLocalDrivingLicenseApplactions_Load(object sender, EventArgs e)
        {
            _RefershLocalDrivingList();
            cmbFilterType.SelectedIndex = 0;
        }

        private void btnAddNewLdlApp_Click(object sender, EventArgs e)
        {
            frmAddEditeLocalDrivingApp frm =new frmAddEditeLocalDrivingApp(-1);
            frm.ShowDialog();
            _RefershLocalDrivingList();
        }


        private string _GetFiltetTypeName()
        {
            string FilterType;
            switch (cmbFilterType.Text)
            {

                case "L.D.LAppID": FilterType = "LocalDrivingLicenseApplicationID"; break;
                case "NationalNo": FilterType = "NationalNo"; break;
                case "Full Name": FilterType = "FullName"; break;
                case "Stauts": FilterType = "Status"; break;
                default: FilterType = "None"; break;
            }
            return FilterType;
        }
        private void _Filter()
        {
            string ColmName = _GetFiltetTypeName();

            if (ColmName == "None")
            {
                dataGridView1.DataSource = _dtAllldlApp;
                lblNumberOfRecord.Text = dataGridView1.Rows.Count.ToString();
                return;
            }

            DataRow[] ResultRows;

            if (ColmName == "Status")
            {
                if (cmbStatus.Text == "New")
                {
                    ResultRows = _dtAllldlApp.Select("[" + ColmName + "] = 'New'");
                }
                else if (cmbStatus.Text == "Completed")
                {
                    ResultRows = _dtAllldlApp.Select("[" + ColmName + "] = 'Completed'");
                }
                else if (cmbStatus.Text == "Cancelled")
                {
                    ResultRows = _dtAllldlApp.Select("[" + ColmName + "] = 'Cancelled'");
                }
                else
                {
                    ResultRows = _dtAllldlApp.Select();
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtFilterValue.Text))
                {
                    dataGridView1.DataSource = _dtAllldlApp;
                    lblNumberOfRecord.Text = dataGridView1.Rows.Count.ToString();
                    return;
                }

                if (ColmName == "LocalDrivingLicenseApplicationID" )
                {
                    if (int.TryParse(txtFilterValue.Text.Trim(), out int id))
                    {
                        ResultRows = _dtAllldlApp.Select("[" + ColmName + "] = " + id);
                    }
                    else
                    {
                        ResultRows = new DataRow[0];
                    }
                }
                else
                {
                    ResultRows = _dtAllldlApp.Select("[" + ColmName + "] LIKE '%" + txtFilterValue.Text.Trim() + "%'");
                }
            }

            if (ResultRows.Length > 0)
            {
                DataTable dtFilterdPeople = ResultRows.CopyToDataTable();
                dataGridView1.DataSource = dtFilterdPeople;
                lblNumberOfRecord.Text = dataGridView1.Rows.Count.ToString();
            }
            else
            {
                dataGridView1.DataSource = _dtAllldlApp.Clone();
                lblNumberOfRecord.Text = "0";
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            if (cmbFilterType.Text == "None")
            {
                txtFilterValue.Visible = false;
               cmbStatus.Visible = false;

            }
            else if (cmbFilterType.Text == "Stauts")
            {
                txtFilterValue.Visible = false;
                cmbStatus.Visible = true;
            }
            else
            {
                txtFilterValue.Visible = true;
                cmbStatus.Visible = false;
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Filter();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _Filter();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cancelAppEffict()
        {
            showApplicationDetielsToolStripMenuItem.Enabled = true;
            editApplicationToolStripMenuItem.Enabled = false;
            TSMDelete.Enabled = false;
            TSMICancel.Enabled = false;
            TSMIissueDrivingLicenseFirstTime.Enabled = false;
            TSMIsecdul.Enabled = false;
            TSMIshowPersonLicenseHistory.Enabled = false;
            TSMIissueDrivingLicenseFirstTime.Enabled = false;
            TSMIshowLicense.Enabled = false;
        }
        private void CompletedAppEffict()
        {
            showApplicationDetielsToolStripMenuItem.Enabled = true;
            editApplicationToolStripMenuItem.Enabled = false;
            TSMDelete.Enabled = false;
            TSMICancel.Enabled = false;
            TSMIissueDrivingLicenseFirstTime.Enabled = false;
            TSMIsecdul.Enabled = false;
            TSMIshowPersonLicenseHistory.Enabled = true;
            TSMIissueDrivingLicenseFirstTime.Enabled = false;
            TSMIshowLicense.Enabled = true;
        }
        private void NewApp(clsLocalDrivingLicenseApplication LocalApp)
        {
           
 
            int PassedTestCount = clsLocalDrivingLicenseApplication.GetCountOfPassedTest(LocalApp.LocalDrivingLicenseApplicationID);   

                if(PassedTestCount == 0)
                {
                    TSMIvision.Enabled = true;
                    TSMIwritten.Enabled = false;
                    TSMIpractical.Enabled = false;
                }
                else if (PassedTestCount == 1)
                {
                    TSMIvision.Enabled = false;
                    TSMIwritten.Enabled = true;
                    TSMIpractical.Enabled= false;
                TSMIissueDrivingLicenseFirstTime.Enabled = false;

            }
            else if(PassedTestCount == 2)
                  {
                        TSMIvision.Enabled = false;
                        TSMIwritten.Enabled = false;
                        TSMIpractical.Enabled = true;
                TSMIissueDrivingLicenseFirstTime.Enabled = false;

            }
            else if(PassedTestCount == 3)
                  {
                TSMIvision.Enabled = false;
                TSMIwritten.Enabled = false;
                TSMIpractical.Enabled = false;
                TSMIissueDrivingLicenseFirstTime.Enabled = true;

            }
            else
                {
                    TSMIvision.Enabled = false;
                    TSMIwritten.Enabled = false;
                    TSMIpractical.Enabled = false;
                TSMIissueDrivingLicenseFirstTime.Enabled = false;

            }
            showApplicationDetielsToolStripMenuItem.Enabled = true;
                editApplicationToolStripMenuItem.Enabled = true;
                TSMDelete.Enabled = true;
                TSMICancel.Enabled = true;
                TSMIshowLicense.Enabled = false;
                TSMIsecdul.Enabled = true;
                TSMIshowPersonLicenseHistory.Enabled = true;
    
            
        }
        private void _MakeChange(int AppId)
        {
            clsLocalDrivingLicenseApplication LocalApp = clsLocalDrivingLicenseApplication.Find(AppId);
            if (LocalApp != null) {
                enAppStatus appStatus = (enAppStatus)LocalApp.ApplicationStatus;
                switch (appStatus)
                {
                    case enAppStatus.New:
                        NewApp(LocalApp);
                        break;
                    case enAppStatus.Cancelled:
                        cancelAppEffict();
                        break;
                    case enAppStatus.Completed:
                        CompletedAppEffict();
                        break;
                }
 


            }
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            _MakeChange((int)dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void showApplicationDetielsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
                return;
            frmLocalDrivingLicensesAppInfo frm = new frmLocalDrivingLicensesAppInfo((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefershLocalDrivingList();
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
                return;
            frmAddEditeLocalDrivingApp frm = new frmAddEditeLocalDrivingApp((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefershLocalDrivingList();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
                return;
            if (clsLocalDrivingLicenseApplication.DeleteLocalDrivingLicenseApplication((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                _RefershLocalDrivingList();
                MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value + " Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
                MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value + " Delete Failed", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
                return;
            if(clsLocalDrivingLicenseApplication.ChangeStatues((int)dataGridView1.CurrentRow.Cells[0].Value,(int) enAppStatus.Cancelled))
            {
                _RefershLocalDrivingList();
                MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value + " Cancelled Successfully", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value + " Cancel Failed", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void visionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
                return;
            frmVisionTest frm = new frmVisionTest((int)dataGridView1.CurrentRow.Cells[0].Value,(int)enTestType.Vision);
            frm.ShowDialog();
            _RefershLocalDrivingList();
        }

        private void writtenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
                return;
            frmVisionTest frm = new frmVisionTest((int)dataGridView1.CurrentRow.Cells[0].Value, (int)enTestType.Written);
            frm.ShowDialog();
            _RefershLocalDrivingList();
        }

        private void TSMIpractical_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
                return;
            frmVisionTest frm = new frmVisionTest((int)dataGridView1.CurrentRow.Cells[0].Value, (int)enTestType.Practical);
            frm.ShowDialog();
            _RefershLocalDrivingList();

        }

        private void TSMIissueDrivingLicenseFirstTime_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
                return;

            
            frmIssueDrivierLicenceForTheFirstTime frm = new frmIssueDrivierLicenceForTheFirstTime((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _MakeChange((int)dataGridView1.CurrentRow.Cells[0].Value);
            _RefershLocalDrivingList();
        }

        private void TSMIshowLicense_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
                return;
            clsLocalDrivingLicenseApplication localapp = clsLocalDrivingLicenseApplication.Find((int)dataGridView1.CurrentRow.Cells[0].Value);
            if (localapp == null)
                return;
            clsLicense license = clsLicense.FindByAppID(localapp.applicationId);
            if (license == null)
            {
                return;
            }

            frmLicenceInfo frm = new frmLicenceInfo(license.LicenseID);
            frm.ShowDialog();
        }

        private void TSMIshowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
                return;
            frmLicenseHistory frm = new frmLicenseHistory((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
