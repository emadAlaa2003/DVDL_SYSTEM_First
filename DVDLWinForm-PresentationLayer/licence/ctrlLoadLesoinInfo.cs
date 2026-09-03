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

namespace DVDLWinForm_PresentationLayer.licence
{
    public partial class ctrlLoadLesoinInfo : UserControl
    {
        public ctrlLoadLesoinInfo()
        {
            InitializeComponent();
        }
        public void LoadLesoinInfo(int LicenseID)

        {
            clsLicense license = clsLicense.Find(LicenseID);
            if (license == null)
            {
                return;
            }

            clsApplication app = clsApplication.FindApplicationById(license.ApplicationID);
            if (app == null) return;

            clsPerson person = clsPerson.FindByID(app.ApplicantPersonID);
            if (person == null) return;

            lblClassType.Text = clsLicenseClasses.Find(license.LicenseClass).ClassName.ToString();
            lblName.Text = person.getFullName();
            lblLicenseId.Text = license.LicenseID.ToString();
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

            lblIssueDate.Text = license.IssueDate.ToString("dd/MMM/yyyy");

            if (string.IsNullOrEmpty(license.Notes))
            {
                lblNote.Text = "No Notes";
            }
            else
            {
                lblNote.Text = license.Notes; 
            }

            lblIsActive.Text = license.IsActive ? "Yes" : "No";

            lblDateOfBirht.Text = person.DateOfBirth.ToString("dd/MMM/yyyy");
            lblDriverID.Text = license.DriverID.ToString();
            lblExpDate.Text = license.ExpirationDate.ToString("dd/MMM/yyyy");

            if (license.ExpirationDate > DateTime.Now)
            {
                lblIsDelained.Text = "No";
            }
            else
            {
                lblIsDelained.Text = "Yes";
            }

            // معالجة الصورة ممتازة جداً عندك
            if (person.ImagePath != "")
            {
                using (Image img = Image.FromFile(person.ImagePath))
                {
                    pictureBox1.Image = new Bitmap(img);
                }
                pictureBox1.ImageLocation = person.ImagePath;
            }
            else
            {
                pictureBox1.Image = (person.Gendor == 0) ? Resources.Male_512 : Resources.Female_512;
            }
        }
        private void ctrlLoadLesoinInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
