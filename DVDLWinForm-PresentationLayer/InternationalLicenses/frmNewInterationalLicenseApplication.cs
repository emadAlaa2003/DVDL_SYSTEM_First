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
using DVLDBusinessLayer;

namespace DVDLWinForm_PresentationLayer.InternationalLicenses
{
    public partial class frmNewInterationalLicenseApplication : Form
    {
        clsLicense license;
        int _LicenseId = -1;
        clsInternationalLicense IntLicense;
        public frmNewInterationalLicenseApplication()
        {
            InitializeComponent();
        }

        private void frmNewInterationalLicenseApplication_Load(object sender, EventArgs e)
        {

        }
        private void _FindLicense()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Plese enter License ID","Erorr",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
             _LicenseId = Convert.ToInt32(textBox1.Text);
            license=clsLicense.Find(_LicenseId);
            if (license == null) {
                MessageBox.Show("there is no Leconse Wiht this ID :" + _LicenseId, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ctrlLoadLesoinInfo1.LoadLesoinInfo(license.LicenseID);

        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            _FindLicense();
        }

        private void lnkShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_LicenseId == -1) {
                MessageBox.Show("Please enter License ID ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                return;
            }
            frmLicenseHistory frm = new frmLicenseHistory(clsDriver.Find(license.DriverID).PersonID,true);
            frm.ShowDialog();
        }
        private void _IssueLicense()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Plese enter License ID", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            IntLicense=clsInternationalLicense.GetActiveInternationalLicenseByDriverID(license.DriverID);
            if (IntLicense != null)
            {
                MessageBox.Show("You Have active International Licecese","Erorr",MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            if (license.LicenseClass != 3)
            {
                MessageBox.Show("You must IssueLicencse From Class 3", "Eorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!license.IsActive)
            {
                MessageBox.Show("You Cannt Issue Internonal License Becouse Your Local Lecsen is NotActive!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (license.ExpirationDate < DateTime.Now)
            {
                MessageBox.Show("You Cannt Issue Internonal License Becouse Your Local Lecsen is DidLine", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            IntLicense =new clsInternationalLicense();
            IntLicense.CreatedByUserID =clsGloabelSettings.CurrentUser.UserId ;
            IntLicense.DriverID=license.DriverID;
            IntLicense.IssueDate=DateTime.Now;
            IntLicense.ExpirationDate = DateTime.Now.AddYears(1);
            IntLicense.IsActive = (DateTime.Now < IntLicense.ExpirationDate);
            IntLicense.IssuedUsingLocalLicenseID=license.LicenseID;
            IntLicense.ApplicantPersonID = clsDriver.Find(license.DriverID).PersonID;
            if (IntLicense.Save())
            {
                MessageBox.Show("Ypur International License ready ID: "+IntLicense.InternationalLicenseID,"Done",MessageBoxButtons.OK, MessageBoxIcon.Information);
                lnkShowLicenseInfo.Enabled = true;
                ctrlIenternationalAppDetiels1.LoadInfo(IntLicense.InternationalLicenseID);
                btnSave.Enabled = false;
                return;
            }
            else
            {
                MessageBox.Show ("Erorr In save","Erorr",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _IssueLicense();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_LicenseId == -1)
            {
                MessageBox.Show("Please enter License ID ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                return;
            }
            frmInternationalLicenseInfo frm = new frmInternationalLicenseInfo(IntLicense.InternationalLicenseID);
            frm.ShowDialog();
        }
    }
}
