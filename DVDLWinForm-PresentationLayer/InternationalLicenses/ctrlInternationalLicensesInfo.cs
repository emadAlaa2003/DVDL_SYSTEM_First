using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVDLWinForm_PresentationLayer.Properties;
using DVLDBusinessLayer;

namespace DVDLWinForm_PresentationLayer.InternationalLicenses
{
    public partial class ctrlInternationalLicensesInfo : UserControl
    {
        public ctrlInternationalLicensesInfo()
        {
            InitializeComponent();
        }
        public void LoadLicenseInfo(int LicenseID)

        {
            clsInternationalLicense INTlicense = clsInternationalLicense.Find(LicenseID);
            if (INTlicense == null)
            {
                return;
            }

            clsApplication app = clsApplication.FindApplicationById(INTlicense.ApplicationID);
            if (app == null) return;

            clsPerson person = clsPerson.FindByID(app.ApplicantPersonID);
            if (person == null) return;
            lblIntLicenseId.Text= INTlicense.InternationalLicenseID.ToString();
            lblName.Text = person.getFullName();
            lblLicenseId.Text = INTlicense.IssuedUsingLocalLicenseID.ToString();
            lblNationalNo.Text = person.NationalNo.ToString();

            if (person.Gendor == 0)
            {
                lblGender.Text = "Male";
                ptbMale.Image = Resources.Man_32;
            }
            else
            {
                lblGender.Text = "Female";
                ptbMale.Image = Resources.Woman_32;
            }

            lblIssueDate.Text = INTlicense.IssueDate.ToString("dd/MMM/yyyy");


            lblIsActive.Text = INTlicense.IsActive ? "Yes" : "No";

            lblDateOfBirht.Text = person.DateOfBirth.ToString("dd/MMM/yyyy");
            lblDriverID.Text = INTlicense.DriverID.ToString();
            lblExpDate.Text = INTlicense.ExpirationDate.ToString("dd/MMM/yyyy");

   

            // معالجة الصورة ممتازة جداً عندك
            if (person.ImagePath != "")
            {
                using (Image img = Image.FromFile(person.ImagePath))
                {
                    ptbPersonImge.Image = new Bitmap(img);
                }
                ptbPersonImge.ImageLocation = person.ImagePath;
            }
            else
            {
                ptbPersonImge.Image = (person.Gendor == 0) ? Resources.Male_512 : Resources.Female_512;
            }
        }
    }
}
