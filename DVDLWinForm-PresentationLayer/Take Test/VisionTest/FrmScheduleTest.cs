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

namespace DVDLWinForm_PresentationLayer.Take_Test.VisionTest
{
    public partial class FrmScheduleTest : Form
    {
        public enum _Mode { AddApp=0,UpdateApp=1,RetakeApp=2};
        public _Mode Mode = _Mode.AddApp;
        private clsTestAppointmont _App;
        int _AppontID = 0;
        int _LdAppID = 0;
        private static int _Trial = 0;
        clsLocalDrivingLicenseApplication L_App;
        public enum enTestType
        {
            VisionTest = 1,
            WrittenTest = 2,
            streetTest = 3
        }
        enTestType _TestType;
        public FrmScheduleTest(int AppontID,int LdAppID, int testType)
        {
            InitializeComponent();
            _LdAppID=LdAppID;
             L_App = clsLocalDrivingLicenseApplication.Find(_LdAppID);
            _TestType = (enTestType)testType;
            _AppontID = AppontID;
            if (_AppontID == -1) {
                 Mode = _Mode.AddApp;
                return;
            }
            Mode = _Mode.UpdateApp;
        }
        private void  _LoadInfo()
        {
            switch (_TestType)
            {
                case enTestType.VisionTest:
                    {
                        _TestType = enTestType.VisionTest;
                        lblTitel.Text = "Vision Test  ";
                        this.Text = "Vision Test ";
                        ptbImgeTitel.Image = Properties.Resources.Vision_512;
                        groupBox1.Text= "Vision Test  ";
                    }
                    break;
                case enTestType.WrittenTest:
                    {
                        _TestType = enTestType.WrittenTest;
                        lblTitel.Text = "Written Test  ";
                        this.Text = "Written Test ";
                        ptbImgeTitel.Image = Properties.Resources.Written_Test_512;
                        groupBox1.Text = "Written Test ";

                    }
                    break;
                case enTestType.streetTest:
                    {
                        _TestType = enTestType.streetTest;
                        lblTitel.Text = "Street Test  ";
                        this.Text = "Street Test ";
                        ptbImgeTitel.Image = Properties.Resources.driving_test_512;
                        groupBox1.Text = "Street Test ";

                    }
                    break;
            }

            if (L_App == null)
            {
                return;
            }
            lblClassType.Text = clsLicenseClasses.Find(L_App.LicenseClassID).ClassName.ToString();
            lblLocalAppID.Text = _LdAppID.ToString();
            lblClassType.Text = clsLicenseClasses.Find(L_App.LicenseClassID).ClassName.ToString();
            lblName.Text = clsPerson.FindByID(L_App.ApplicantPersonID).FirstName.ToString() + " " + clsPerson.FindByID(L_App.ApplicantPersonID).SecondName.ToString() + " " + clsPerson.FindByID(L_App.ApplicantPersonID).LastName.ToString();
            lblTrial.Text = _Trial.ToString();
            lblFees.Text = clsTestType.FindTestTypeById((int)_TestType).TestFees.ToString();

            if (Mode == _Mode.AddApp) {
                _Trial = 0;
                dtbDate.Value = DateTime.Now;
                return;

            }
            if (Mode == _Mode.RetakeApp)
            {
                _Trial += 1;
                groupBox2.Enabled = true;
            }else if (Mode ==_Mode.UpdateApp)
            {
                _Trial = 1;
            }
            _App =clsTestAppointmont.Find(_AppontID);
            if (_App == null) {
                return;
            }
            dtbDate.Value = _App.AppointmentDate;
            if (_App.IsLocked == true) {
                btnSave.Enabled = false;
                dtbDate.Enabled = false;
            
            }

        }

        private void FrmScheduleTest_Load(object sender, EventArgs e)
        {
            _LoadInfo();
        }
        private void _Save()
        {
            if (Mode == _Mode.AddApp)
            {
                _App = new clsTestAppointmont();
            }
            _App.LocalDrivingLicenseApplicationID = L_App.LocalDrivingLicenseApplicationID;
            _App.PaidFees= clsTestType.FindTestTypeById((int)_TestType).TestFees;
            _App.IsLocked = false;
            _App.CreatedByUserID = clsGloabelSettings.CurrentUser.UserId;
            _App.TestTypeID = (int)_TestType;

            _App.AppointmentDate = dtbDate.Value.Date;
            if (_App.Save())
            {
                MessageBox.Show("Appointment Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mode=_Mode.UpdateApp;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void dtbDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtbDate.Value < DateTime.Now)
            {
                MessageBox.Show("Appointment Date cannot be in the past", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
