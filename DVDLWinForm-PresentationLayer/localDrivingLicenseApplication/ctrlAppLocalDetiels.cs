using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVDLWinForm_PresentationLayer.People;
using DVLDBusinessLayer;

namespace DVDLWinForm_PresentationLayer.localDrivingLicenseApplication
{
    public partial class ctrlAppLocalDetiels : UserControl
    {
        public ctrlAppLocalDetiels()
        {
            InitializeComponent();
        }
        clsLocalDrivingLicenseApplication LocalApp;
        private string _GetAppStatus(int status)
        {
            string Appstatues = "";
            if (status == 1)
            {
                Appstatues = "New";
            }
            else if (status == 2)
            {
                Appstatues = "Cancelled";
            }
            else if (status == 3)
            {
                Appstatues = "Completed";
            }
            else
            {
                Appstatues = "ERORR";
            }
            return Appstatues;
        }
        public void  LoadInfo(int LocalAppID)
        {
            LocalApp= clsLocalDrivingLicenseApplication.Find(LocalAppID);
            if (LocalApp != null) { 
                lblLocalAppID.Text = LocalAppID.ToString();
                lblClassType.Text = clsLicenseClasses.Find(LocalApp.LicenseClassID).ClassName.ToString();
                lblIDBase.Text= LocalApp.applicationId.ToString();
                string Appstatues = _GetAppStatus(LocalApp.ApplicationStatus);
                lblStatus.Text = Appstatues;
                lblFees.Text = clsLicenseClasses.Find(LocalApp.LicenseClassID).ClassFees.ToString();
                clsPerson person = clsPerson.FindByID(LocalApp.ApplicantPersonID);
                lblApplictant.Text= person.FirstName.ToString()+" "+person.SecondName.ToString() + " " + person.ThirdName.ToString() + " " + person.LastName.ToString();
                lblDate.Text= LocalApp.ApplicationDate.ToShortDateString();
                lblStatusDate.Text=LocalApp.LastStatusDate.ToShortDateString();
                lblCreatedBy.Text=clsUser.FindUserById(LocalApp.CreatedByUserID).UserName.ToString();
                lblType.Text=clsApplactionType.FindApplactionTypeById(LocalApp.ApplicationTypeID).ApplicationTypeName.ToString();
                lblPassedTest.Text=clsLocalDrivingLicenseApplication.GetCountOfPassedTest(LocalApp.LocalDrivingLicenseApplicationID).ToString()+"/3";
              


            }
        }
        private void ctrlAppLocalDetiels_Load(object sender, EventArgs e)
        {

        }

        private void lnkPersonDetiels_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonInfo frm =new frmPersonInfo(LocalApp.ApplicantPersonID);
            frm.ShowDialog();

        }
    }
}
