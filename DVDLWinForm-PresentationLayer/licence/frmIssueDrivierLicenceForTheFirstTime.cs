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

namespace DVDLWinForm_PresentationLayer.licence
{
    public partial class frmIssueDrivierLicenceForTheFirstTime : Form
    {
        private int _LocalAppID;
        private clsApplication _app;
        private clsLocalDrivingLicenseApplication _localApp;
        private clsLicense _license;
        public frmIssueDrivierLicenceForTheFirstTime(int LocalApp)
        {
            InitializeComponent();
            _LocalAppID = LocalApp;
            _localApp = clsLocalDrivingLicenseApplication.Find(_LocalAppID);
        }
        private void _LoadInfo()
        {
            if(_localApp == null)
            {
                MessageBox.Show("Local Driving License Application not found.");
                this.Close();
                return;
            }
            ctrlAppLocalDetiels1.LoadInfo(_LocalAppID);
            _app = clsApplication.FindApplicationById(_localApp.applicationId);
        }
        private void frmIssueDrivierLicenceForTheFirstTime_Load(object sender, EventArgs e)
        {
            _LoadInfo();
        }
        private void _Issue()
        {
            int DriverID = -1;
            bool isNewDriverCreatedNow = false; 
            clsDriver driver = clsDriver.FindByPersonID(_app.ApplicantPersonID);
            if (driver == null)
            {
                // 2. إذا مش سواق، بنعمله سجل جديد
                driver = new clsDriver();
                driver.PersonID = _app.ApplicantPersonID;
                driver.CreatedByUserID = clsGloabelSettings.CurrentUser.UserId;
                driver.CreatedDate = DateTime.Now;

                if (driver.save())
                {
                    isNewDriverCreatedNow = true; // 🚩 بنرفع العلم: ترى إحنا خلقنا سواق جديد هسا!
                }
                else
                {
                    MessageBox.Show("Failed to create driver record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            DriverID = driver.DriverID;

            _license = new clsLicense();
            _license.ApplicationID = _app.applicationId;
            _license.DriverID = DriverID;
            _license.LicenseClass = _localApp.LicenseClassID;
            _license.IssueDate = DateTime.Now;
            _license.ExpirationDate = DateTime.Now.AddYears(clsLicenseClasses.Find(_localApp.LicenseClassID).DefaultValidityLength);
            _license.Notes = textBox1.Text;
            _license.PaidFees = (decimal)clsLicenseClasses.Find(_localApp.LicenseClassID).ClassFees; 
            _license.IsActive = true;
            _license.IssueReason = (int)clsLicense.enIssueReason.FirstTime;
            _license.CreatedByUserID = clsGloabelSettings.CurrentUser.UserId;
            if (_license.save())
            {
                // ✅ نجح كل إشي
                MessageBox.Show("License issued successfully with ID: " + _license.LicenseID, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clsApplication.ChangeStatues(_app.applicationId, (int)clsApplication.enApplicationSatus.Completed);
                btnSave.Enabled = false;
            }
            else
            {
                // ❌ فشل حفظ الرخصة! هون بنطبق فكرتك
                if (isNewDriverCreatedNow)
                {
                    // بنحذف السواق اللي عملناه قبل ثواني عشان ما يضل يتيم بالداتا بيز
                    clsDriver.DeleteDriver(driver.DriverID);
                }

                MessageBox.Show("Failed to issue license. No partial data was saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Issue();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
