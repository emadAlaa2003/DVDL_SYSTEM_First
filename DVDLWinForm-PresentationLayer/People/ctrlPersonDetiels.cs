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

namespace DVDLWinForm_PresentationLayer.People
{
    public partial class ctrlPersonDetiels : UserControl
    {


        int personID = -1;

        private clsPerson _person;
        public ctrlPersonDetiels()
        {
            InitializeComponent();
        }
        private void _SetDefoultGenderImg()
        {

            if (_person.Gendor == 0)
            {
                pictureBox1.Image = imlGenderImge.Images[0];
            }
            else
                pictureBox1.Image = imlGenderImge.Images[1];


        }
        public void LoadPersonInfo(int PersonID)
        {
            this.personID = PersonID;
 
          

            _person = clsPerson.FindByID(this.personID);
            lblPersonID.Text = personID.ToString();
            lblPersonName.Text = _person.FirstName+" "+ _person.SecondName+ " " + _person.ThirdName+ " " + _person.LastName;
            lblNationalNo.Text = _person.NationalNo;
            if (_person.Gendor == 0)
            {
                lblGender.Text = "Male";
                    
             }
            else
            {
                lblGender.Text = "Female";

              
            }
            lblEmail.Text = _person.Email;
            lblPhone.Text = _person.Phone;
            lblAddress.Text = _person.Address;
            lblDateOfBirht.Text = _person.DateOfBirth.ToString();
            if (_person.ImagePath != "")
            {
                // نفتح الصورة بأمان
                using (Image img = Image.FromFile(_person.ImagePath))
                {
                    // نأخذ نسخة منها للـ PictureBox
                    pictureBox1.Image = new Bitmap(img);
                }
                // بمجرد انتهاء قوس الـ using، الويندوز بيفلت الملف فوراً!

                // ملاحظة: بما إننا بطلنا نستخدم Load، لازم نخزن المسار يدوياً عشان نحتاجه في دالة الحفظ
                pictureBox1.ImageLocation = _person.ImagePath;
            }
            else
            {
                _SetDefoultGenderImg();
            }

           
            lblCountry.Text = clsCountry.Find(_person.NationalityCountryID).CountryName;

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void llUpdetPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson(personID);
            frm.ShowDialog();
            LoadPersonInfo(personID);
        }

        private void lblPersonIdTitel_Click(object sender, EventArgs e)
        {

        }

        private void lblNationalNo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblPersonName_Click(object sender, EventArgs e)
        {

        }

        private void ptbName_Click(object sender, EventArgs e)
        {

        }

        private void lblNatinalNoTitel_Click(object sender, EventArgs e)
        {

        }

        private void lblNameTitel_Click(object sender, EventArgs e)
        {

        }

        private void lblPersonID_Click(object sender, EventArgs e)
        {

        }
    }
}
