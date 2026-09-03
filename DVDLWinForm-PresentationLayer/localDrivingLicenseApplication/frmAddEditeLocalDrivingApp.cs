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

namespace DVDLWinForm_PresentationLayer.localDrivingLicenseApplication
{
    public partial class frmAddEditeLocalDrivingApp : Form
    {
        public enum _Mode { AddApp, UpdateApp };
        public _Mode Mode=_Mode.AddApp;
        private int AppLDID;
        public clsLocalDrivingLicenseApplication _App;
        private int _ApplicantPersonID;
        public frmAddEditeLocalDrivingApp(int AppLDID)
        {
            InitializeComponent();
            this.AppLDID = AppLDID;

            if (AppLDID != -1)
            {
                Mode = _Mode.UpdateApp;
            }
        }
        private void _FullComboBox()
        {

            DataTable dtClass = clsLicenseClasses.GetAllLicenseClasses();
            foreach (DataRow row in dtClass.Rows)
            {
                cmbLicenceClass.Items.Add(row["ClassName"]);
            }
        }
        private void frmAddEditeLocalDrivingApp_Load(object sender, EventArgs e)
        {
            _FullComboBox();
            cmbLicenceClass.SelectedIndex = 0;
            lblDateVlaue.Text = DateTime.Now.ToString("yyyy/MM/dd");
            lblFees.Text =clsApplactionType.FindApplactionTypeById(1).ApplicationTypeFees.ToString();
            if (Mode == _Mode.AddApp)
            {
                lblUserName.Text = clsGloabelSettings.CurrentUser.UserName.ToString();
                _App = new clsLocalDrivingLicenseApplication();
                tabPage2.Enabled = false;
                _ApplicantPersonID = -1;
                return;
            }
            lblTitel.Text = "Update Local Driving License Application";
            this.Text = "Update Local Driving License Application";
             _App = clsLocalDrivingLicenseApplication.Find(AppLDID);
            ctrlPersonCardWithFilter1.UpadetMode(_App.ApplicantPersonID);
            lblAppLDID.Text = _App.LocalDrivingLicenseApplicationID.ToString();
            lblDateVlaue.Text = _App.ApplicationDate.ToString("yyyy/MM/dd");
            cmbLicenceClass.SelectedIndex = cmbLicenceClass.FindString(clsLicenseClasses.Find(_App.LicenseClassID).ClassName.ToString());
            lblUserName.Text = clsUser.FindUserById(_App.CreatedByUserID).UserName.ToString();
            Mode =_Mode.UpdateApp;
            _ApplicantPersonID = _App.ApplicantPersonID;
          

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_ApplicantPersonID != -1)
            {
                if (_App != null)
                {
                    
                        _App.ApplicantPersonID = _ApplicantPersonID;
                        tabPage2.Enabled = true;
                        tbcAddUpdateNewLocalDL.SelectedTab = tabPage2;
                   
               

                }
                else
                    return;
            }
            else
            {
                MessageBox.Show("please select person", "erorr", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ctrlPersonCardWithFilter1_onFindClick(int obj)
        {
            this._ApplicantPersonID = obj;

        }
        private void _Save()
        {

            _App.ApplicationDate = Convert.ToDateTime(lblDateVlaue.Text);
            _App.LicenseClassID = clsLicenseClasses.Find(cmbLicenceClass.SelectedItem.ToString()).ID;

            if (Mode == _Mode.AddApp)
            {
                if (clsLocalDrivingLicenseApplication.IsThereAnActiveApplicationForThisClass(_ApplicantPersonID, _App.LicenseClassID))
                {
                    MessageBox.Show("This person already has an active application or an issued license for this class!", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _App.ApplicationTypeID = 1;
                _App.ApplicationStatus = 1;

            }
            _App.CreatedByUserID = clsGloabelSettings.CurrentUser.UserId;
            
            _App.PaidFees=Convert.ToDecimal(lblFees.Text);

            if (_App.Save())
            {
                MessageBox.Show("Saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mode = _Mode.UpdateApp;
                lblTitel.Text = "Update LOCAL DRIVING LICENSE Application ";
                this.Text = "Update  LOCAL DRIVING LICENSE Application";
                lblAppLDID.Text = _App.LocalDrivingLicenseApplicationID.ToString();
            }
            else
            {
                MessageBox.Show("Error while saving", "erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
