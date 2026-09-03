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
    public partial class frmVisionTest : Form
    {
        int _LocalAppID=0;
        public enum enTestType
        {
            VisionTest = 1,
            WrittenTest = 2,
            streetTest = 3
        }
        enTestType _TestType;
        public frmVisionTest(int localAppID, int testType)
        {
            InitializeComponent();
            _LocalAppID = localAppID;
            _TestType = (enTestType)testType;
        }
        private void _RefrechAppointmentList()
        {
           dataGridView1.DataSource=clsTestAppointmont.GetAllTestAppointmontsByLocalAppId(_LocalAppID,(int)_TestType);
            lblNumberOfRecord.Text=dataGridView1.Rows.Count.ToString();

        }
        private void ctrlAppLocalDetiels1_Load(object sender, EventArgs e)
        {

        }
        
        private void _LoadInfo()
        {
            switch (_TestType)
            {
                case enTestType.VisionTest:
                    {
                        _TestType= enTestType.VisionTest;
                        lblTitel.Text= "Vision Test Appointment ";
                        this.Text= "Vision Test ";
                        ptbImgeTitel.Image=  Properties.Resources.Vision_512;

                    }
                    break;
                 case enTestType.WrittenTest:
                    {
                        _TestType= enTestType.WrittenTest;
                        lblTitel.Text = "Written Test Appointment ";
                        this.Text = "Written Test ";
                        ptbImgeTitel.Image = Properties.Resources.Written_Test_512;
                    }
                    break;
                case enTestType.streetTest:
                    {
                        _TestType = enTestType.streetTest;
                        lblTitel.Text = "Street Test Appointment ";
                        this.Text = "Street Test ";
                        ptbImgeTitel.Image = Properties.Resources.driving_test_512;
                    }
                    break;
            }
            ctrlAppLocalDetiels1.LoadInfo(_LocalAppID);

            _RefrechAppointmentList();
        }
        private void frmVisionTest_Load(object sender, EventArgs e)
        {
            _LoadInfo();
        }
        private void _ScheduelTest()
        {
            if (clsTestAppointmont.IsThereActiveAppointment(_LocalAppID, (int)_TestType) )
            {
                MessageBox.Show("There is active Appointment", "Erorr ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (clsTest.GetTestTrilCount(_LocalAppID,(int) _TestType, true) != 0)
                {
                    MessageBox.Show("Your Passed Exam ", " Erorr ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(clsTest.GetTestTrilCount(_LocalAppID, (int)_TestType, false) != 0)
                {
                    //Open Retake Test Form
                    return;
                }
                FrmScheduleTest frmVisionTest = new FrmScheduleTest(-1, _LocalAppID,(int)_TestType);
                frmVisionTest.ShowDialog();
                _RefrechAppointmentList();
            }
        }
        private void btnAddNewLdlApp_Click(object sender, EventArgs e)
        {
            _ScheduelTest();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmScheduleTest frmVisionTest = new FrmScheduleTest((int)dataGridView1.CurrentRow.Cells[0].Value, _LocalAppID,(int)_TestType);
            frmVisionTest.ShowDialog();
            _RefrechAppointmentList();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((bool)dataGridView1.CurrentRow.Cells[3].Value == false)
            {
                frmTakeTest frm = new frmTakeTest((int)dataGridView1.CurrentRow.Cells[0].Value,(int)_TestType);
                frm.ShowDialog();
                _RefrechAppointmentList();
            }
            else
            {
                MessageBox.Show("This appointment is locked because the test has already been taken.", "Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ptbImgeTitel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
