using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVDLWinForm_PresentationLayer.licence
{
    public partial class ctrlRenewLicenseAppInfo : UserControl
    {
        public ctrlRenewLicenseAppInfo()
        {
            InitializeComponent();
        }
        public void LoadInfo(int RenwLicenseID,int oldLicense)
        {
            clsLicense RenwLis= clsLicense.Find(RenwLicenseID);
            if (RenwLis == null) return;
            clsApplactionType appType = clsApplactionType.FindApplactionTypeById(2);
            clsLicenseClasses licenseClass = clsLicenseClasses.Find(RenwLis.LicenseClass);
            clsApplication app = clsApplication.FindApplicationById(RenwLis.ApplicationID);
            clsUser user = clsUser.FindUserById(RenwLis.CreatedByUserID);
            decimal appFees = (appType != null) ? appType.ApplicationTypeFees : 0;
            decimal LicenseFees = (licenseClass != null) ? (decimal)licenseClass.ClassFees : 0;
            decimal totalFees = appFees + LicenseFees;
            lblILappID.Text = RenwLis.ApplicationID.ToString();
            lblRenewLicenseId.Text = RenwLis.LicenseID.ToString();
            lblOldLicenseId.Text = oldLicense.ToString();
            lblAppDate.Text = (app != null) ? app.ApplicationDate.ToShortDateString() : "[????]";
            lblIssueDate.Text = RenwLis.IssueDate.ToShortDateString();
            lblCreatedUser.Text = (user != null) ? user.UserName : "[????]";
            txtNote.Text = string.IsNullOrEmpty(RenwLis.Notes) ? "" : RenwLis.Notes;
            lblApplictionFees.Text = appFees.ToString();
            lblLicenseFees.Text = LicenseFees.ToString();
            lblTotalFees.Text = totalFees.ToString();

        }

        private void ctrlRenewLicenseAppInfo_Load(object sender, EventArgs e)
        {
            lblAppDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            if (clsGloabelSettings.CurrentUser != null)
            {
                lblCreatedUser.Text = clsGloabelSettings.CurrentUser.UserName;
            }
            else
            {
                lblCreatedUser.Text = "[????]"; 
            }

            var appType = clsApplactionType.FindApplactionTypeById(2);
            if (appType != null)
            {
                lblApplictionFees.Text = appType.ApplicationTypeFees.ToString();
            }
            else
            {
                lblApplictionFees.Text = "[$$$]"; 
            }
        }
    }
}
