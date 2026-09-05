using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVDLWinForm_PresentationLayer.InternationalLicenses;
using DVLDBusinessLayer;

namespace DVDLWinForm_PresentationLayer.licence
{
    public partial class frmRenewLocalDrivingLicense : Form
    {
        clsLicense license;
        int _LicenseId = -1;
        clsLicense RenwLicense;
        public frmRenewLocalDrivingLicense()
        {
            InitializeComponent();
        }
        private void _FindLicense()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter License ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBox1.Text.Trim(), out _LicenseId))
            {
                MessageBox.Show("Invalid License ID format. Please enter numbers only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            license = clsLicense.Find(_LicenseId);
            if (license == null)
            {
                MessageBox.Show("There is no License with this ID: " + _LicenseId, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrlLoadLesoinInfo1.LoadLesoinInfo(license.LicenseID);

            if (!license.IsActive)
            {
                MessageBox.Show("You Cannot Renew an inactive license!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }

            if (license.ExpirationDate > DateTime.Now)
            {
                MessageBox.Show("You Cannot Renew Your License Because Your License is Not Expired Yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }
            btnSave.Enabled = true;
        }
  


        private void _IssueLicense()
        {
            if (license == null)
            {
                MessageBox.Show("Please find a valid license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to renew this license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsLicenseClasses licenseClass = clsLicenseClasses.Find(license.LicenseClass);
            if (licenseClass == null) return;

            clsApplication RenewApp = new clsApplication();
            RenewApp.ApplicantPersonID = clsDriver.Find(license.DriverID).PersonID; 
            RenewApp.ApplicationDate = DateTime.Now;
            RenewApp.ApplicationTypeID = 2; 
            RenewApp.ApplicationStatus = 3; 
            RenewApp.LastStatusDate = DateTime.Now;
            RenewApp.PaidFees = clsApplactionType.FindApplactionTypeById(2).ApplicationTypeFees;
            RenewApp.CreatedByUserID = clsGloabelSettings.CurrentUser.UserId;

            if (!RenewApp.Save())
            {
                MessageBox.Show("Error creating the renewal application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RenwLicense = new clsLicense();
            RenwLicense.ApplicationID = RenewApp.applicationId; 
            RenwLicense.DriverID = license.DriverID;
            RenwLicense.LicenseClass = license.LicenseClass;
            RenwLicense.IssueDate = DateTime.Now;
            RenwLicense.ExpirationDate = DateTime.Now.AddYears(licenseClass.DefaultValidityLength);
            RenwLicense.PaidFees = (decimal)licenseClass.ClassFees; 
            RenwLicense.IsActive = true;
            RenwLicense.IssueReason = (int)clsLicense.enIssueReason.Renew; 
            RenwLicense.CreatedByUserID = clsGloabelSettings.CurrentUser.UserId;

            if (RenwLicense.save())
            {
                license.IsActive = false;
                license.save();

                MessageBox.Show("Your License renewed successfully. New License ID: " + RenwLicense.LicenseID, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lnkShowLicenseInfo.Enabled = true;
                ctrlRenewLicenseAppInfo1.LoadInfo(RenwLicense.LicenseID, _LicenseId); 
                btnSave.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error saving the new license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   

 

  

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            _FindLicense();

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            _IssueLicense();

        }

        private void lnkShowLicensesHistory_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_LicenseId == -1)
            {
                MessageBox.Show("Please enter License ID ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                return;
            }
            frmLicenseHistory frm = new frmLicenseHistory(clsDriver.Find(license.DriverID).PersonID, true);
            frm.ShowDialog();
        }

        private void lnkShowLicenseInfo_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_LicenseId == -1)
            {
                MessageBox.Show("Please enter License ID ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                return;
            }
            frmLicenceInfo frm = new frmLicenceInfo(RenwLicense.LicenseID);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
