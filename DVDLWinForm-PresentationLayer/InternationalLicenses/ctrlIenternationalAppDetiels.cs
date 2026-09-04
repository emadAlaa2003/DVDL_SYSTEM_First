using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVDLWinForm_PresentationLayer.InternationalLicenses
{
    public partial class ctrlIenternationalAppDetiels : UserControl
    {
        public ctrlIenternationalAppDetiels()
        {
            InitializeComponent();
        }
        public void LoadInfo(int INterninalID)
        {
            clsInternationalLicense IntLicense=clsInternationalLicense.Find(INterninalID);
            if (IntLicense == null) return;
            lblILappID.Text=IntLicense.ApplicationID.ToString();
            lblInternationalLicenseId.Text= IntLicense.InternationalLicenseID.ToString();
            lblLocalLicenseId.Text= IntLicense.IssuedUsingLocalLicenseID.ToString();
            lblAppDate.Text = clsApplication.FindApplicationById(IntLicense.ApplicationID).ApplicationDate.ToShortDateString();
            lblIssueDate.Text = IntLicense.IssueDate.ToShortDateString();
            lblExpDate.Text = IntLicense.ExpirationDate.ToShortDateString();
            lblFees.Text = clsApplactionType.FindApplactionTypeById(6).ApplicationTypeFees.ToString();
            lblCreatedUser.Text =clsUser.FindUserById( IntLicense.CreatedByUserID).UserName;


        }
        private void ctrlIenternationalAppDetiels_Load(object sender, EventArgs e)
        {
            lblAppDate.Text=DateTime.Now.ToShortDateString();
           lblIssueDate.Text=DateTime.Now.ToShortDateString();
            lblExpDate.Text = DateTime.Now.AddYears(1).ToShortDateString();
            if (clsGloabelSettings.CurrentUser != null)
            {
                lblCreatedUser.Text = clsGloabelSettings.CurrentUser.UserName;
            }
            else
            {
                lblCreatedUser.Text = "[????]"; // رح تبين بس وإنت بتصمم الشاشة
            }

            // 2. حماية من الانهيار في وضع التصميم (للداتا بيز)
            var appType = clsApplactionType.FindApplactionTypeById(6);
            if (appType != null)
            {
                lblFees.Text = appType.ApplicationTypeFees.ToString();
            }
            else
            {
                lblFees.Text = "[$$$]"; // في حال ما قدر يشبك داتا بيز بالديزاينر
            }

        }
    }
}
