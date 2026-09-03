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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DVDLWinForm_PresentationLayer.Take_Test.VisionTest
{
    public partial class frmTakeTest : Form
    {
        public enum _Mode { AddApp = 0, UpdateApp = 1, RetakeApp = 2 };
        public _Mode Mode = _Mode.AddApp;
        private clsTestAppointmont _Appointment;
        int _AppontID = -1;
        int _TestId = -1;
        public enum enTestType
        {
            VisionTest = 1,
            WrittenTest = 2,
            streetTest = 3
        }
        enTestType _TestType;
        public frmTakeTest(int appontID,int testType)
        {
            InitializeComponent();
            _AppontID = appontID;
            _TestType = (enTestType)testType;
            if (_TestId == -1)
            {
                Mode = _Mode.AddApp;
                return;
            }
        }
        private void _LoadInfo()
        {
            _Appointment=clsTestAppointmont.Find(_AppontID);
            switch (_TestType)
            {
                case enTestType.VisionTest:
                    {
                        _TestType = enTestType.VisionTest;
                        lblTitel.Text = "Vision Test";
                        this.Text = "Vision Test ";
                        ptbImgeTitel.Image = Properties.Resources.Vision_512;

                    }
                    break;
                case enTestType.WrittenTest:
                    {
                        _TestType = enTestType.WrittenTest;
                        lblTitel.Text = "Written Test";
                        this.Text = "Written Test ";
                        ptbImgeTitel.Image = Properties.Resources.Written_Test_512;
                    }
                    break;
                case enTestType.streetTest:
                    {
                        _TestType = enTestType.streetTest;
                        lblTitel.Text = "Street Test";
                        this.Text = "Street Test ";
                        ptbImgeTitel.Image = Properties.Resources.driving_test_512;
                    }
                    break;
            }

                    if (_Appointment == null)
            {
                return;
            }
            clsLocalDrivingLicenseApplication L_App = clsLocalDrivingLicenseApplication.Find(_Appointment.LocalDrivingLicenseApplicationID);
            if(L_App == null)
            {
                return;
            }
            lblClassType.Text = clsLicenseClasses.Find(L_App.LicenseClassID).ClassName.ToString();
            lblLocalAppID.Text = _Appointment.LocalDrivingLicenseApplicationID.ToString();
            lblName.Text = clsPerson.FindByID(L_App.ApplicantPersonID).FirstName.ToString() + " " + clsPerson.FindByID(L_App.ApplicantPersonID).SecondName.ToString() + " " + clsPerson.FindByID(L_App.ApplicantPersonID).LastName.ToString();
            lblFees.Text = clsTestType.FindTestTypeById(_Appointment.TestTypeID).TestFees.ToString();
            lblDateValue.Text = _Appointment.AppointmentDate.ToString("dd/MM/yyyy");
            rdbPass.Checked=true;
            lblTrial.Text = (clsTest.GetTestTrilCount(_Appointment.LocalDrivingLicenseApplicationID, _Appointment.TestTypeID, false)+1).ToString();


        }
   

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            _LoadInfo();
        }
        private void _Save()
        {
            clsTest test=new clsTest();
            test.Notes=textBox1.Text;
            test.CreatedByUserID = clsGloabelSettings.CurrentUser.UserId;
            test.TestAppointmentID = _Appointment.appointmentID;
            if (rdbFail.Checked)
            {
                test.TestResult = false;
            }else
            {
                test.TestResult = true;
            }
            if (!(MessageBox.Show("Conform", "Are Yoou Sure You Want Save Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK))
            {
                return;
            }
                if (test.Save())
            {
              
                    MessageBox.Show("Test  Saved Succsefull", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rdbFail.Enabled = false;
                    rdbPass.Enabled = false;
                    textBox1.Enabled = false;
                    btnSave.Enabled = false;
                    _Appointment.IsLocked = true;
                    _Appointment.Save();


                
                }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }
    }
}
