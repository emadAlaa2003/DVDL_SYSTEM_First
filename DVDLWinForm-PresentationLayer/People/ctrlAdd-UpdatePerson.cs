using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;
using static DVLDBusinessLayer.clsCountry;
using System.Text.RegularExpressions;
using System.IO;
namespace DVDLWinForm_PresentationLayer.People
{
    public partial class ctrlAdd_UpdatePerson : UserControl
    {
        private enum _enMode { AddNew = 0, Update = 1 };
        private _enMode _currentMode = _enMode.AddNew;

        int personID=-1 ;

        private clsPerson _person;
        public event Action <int> onSavedClick;
        public event Action<int> onCloseClick;

        protected virtual void SavedClick(int personID)
        {
            Action<int> handlar = onSavedClick;
            if (handlar != null)
            {
                handlar(personID);
            }
        }
        protected virtual void CloseClick(int personID)
        {
            Action<int> handlar = onCloseClick;
            if (handlar != null)
            {
                handlar(personID);
            }
        }
        private void  _Mode(int PersonID)
        {
            if (personID != -1)
            {
                _currentMode = _enMode.Update;
            }
            else
            {
                _currentMode = _enMode.AddNew;
            }

        }

        private  void _FullCountriesInComboBox()
        {
            DataTable dtCountries=clsCountry.GetAllCountries();
            foreach (DataRow row in dtCountries.Rows) {
                cmbCountry.Items.Add(row["CountryName"]);
            }
           
        }
        public ctrlAdd_UpdatePerson()
        {
            InitializeComponent();
        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void _SetDefoultGenderImg()
        {
         
                if (rdbMale.Checked)
                {
                    pictureBox1.Image = imlGenderImge.Images[0];
                }
                else
                    pictureBox1.Image = imlGenderImge.Images[1];
          
       
        }
        private void ctrlAdd_UpdatePerson_Load(object sender, EventArgs e)
        {

        }
        public void LoadPersonInfo(int PersonID)
        {
            this.personID = PersonID;
            _Mode(personID);
            //if (this.DesignMode) return;
            dtbDateOfBirht.MaxDate = DateTime.Now.AddYears(-18);
            _FullCountriesInComboBox();
            cmbCountry.SelectedIndex = cmbCountry.FindString("Jordan");
            if (_currentMode == _enMode.AddNew)
            {
                dtbDateOfBirht.Value = DateTime.Now.AddYears(-20);
                _SetDefoultGenderImg();
                _person = new clsPerson();
                return;
            }
            _person = clsPerson.FindByID(this.personID);
            txtFirstName.Text = _person.FirstName;
            txtSecond.Text = _person.SecondName;
            txtThirdName.Text = _person.ThirdName;
            txtLastName.Text = _person.LastName;
            txtNatinolNo.Text = _person.NationalNo;
            if (_person.Gendor == 0)
            {
                rdbMale.Checked = true;
            }
            else
            {
                rdbFemale.Checked = true;
            }
            txtEmail.Text = _person.Email;
            txtPhone.Text = _person.Phone;
            txtAdderss.Text = _person.Address;
            dtbDateOfBirht.Value = _person.DateOfBirth;
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

            llRemoveImage.Visible = (_person.ImagePath != "");

           
            cmbCountry.SelectedIndex = cmbCountry.FindString(clsCountry.Find(_person.NationalityCountryID).CountryName);

        }
        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (!llRemoveImage.Visible)
            {
                _SetDefoultGenderImg();
            }
               
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (!llRemoveImage.Visible)
            {
                _SetDefoultGenderImg();
            }
        }


        private bool _HandelPersonImage()
        {
            if (_person.ImagePath != pictureBox1.ImageLocation)
            {

                if (_person.ImagePath != "")
                {
                    if (File.Exists(_person.ImagePath))
                    {
                        try
                        {
                            // بنحاول نحذفها بأدب
                            System.GC.Collect();
                            System.GC.WaitForPendingFinalizers();
                            File.Delete(_person.ImagePath);
                        }
                        catch
                        {
                            // 💥 السحر هنا: الصندوق فاضي!
                            // إذا الويندوز رافض يفك القفل، البرنامج رح يطنش الخطأ تماماً
                            // ورح يكمل حفظ الشخص في الداتا بيز بدون أي رسائل حمراء
                        }
                    }
                }
                if (string.IsNullOrEmpty(pictureBox1.ImageLocation))
                {
                    _person.ImagePath = "";
                    return true;
                }
                string sourcePaht = pictureBox1.ImageLocation;
                string folderPath = @"C:\DVLD_Images";
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);
                string extension = Path.GetExtension(sourcePaht);
                string newImageName = Guid.NewGuid().ToString() + extension;
                string destinationPath = Path.Combine(folderPath, newImageName);

                try
                {
                    File.Copy(sourcePaht, destinationPath);
                    _person.ImagePath = destinationPath;
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("erorr in image uplode " + ex.Message);
                    return false;
                }
            }
            return true;
        }
        private void _Save()
        {
            int CountryId = clsCountry.Find(cmbCountry.Text).ID;
            _person.FirstName = txtFirstName.Text;
            _person.SecondName= txtSecond.Text;
            _person.ThirdName = txtThirdName.Text;
            _person.LastName = txtLastName.Text;
            _person.NationalNo = txtNatinolNo.Text;
           _person.Gendor = (byte)((rdbMale.Checked) ? 0 : 1);
            _person.Email = txtEmail.Text;
            _person.Phone = txtPhone.Text;
            _person.Address = txtAdderss.Text;
            _person.DateOfBirth = dtbDateOfBirht.Value;
            _person.NationalityCountryID = CountryId;
            if (!_HandelPersonImage())
            {
                return;
            }
            if(_currentMode == _enMode.AddNew)
            {
                if (!this.ValidateChildren())
                {
                    MessageBox.Show("Some fields are not valid! Please check the red error icons.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
  
            if (_person.Save())
            {
                MessageBox.Show("Person Save Successfully");
                if(onSavedClick != null )
                {
                    onSavedClick(_person.PersonID);
                }
            }
            else
            {
                MessageBox.Show("Error While Saving Person");
                return ;
            }
            _currentMode = _enMode.Update;


        }
        private void btnSave_Click(object sender, EventArgs e)
        {
      
            _Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (onCloseClick != null)
            {
                onCloseClick(_person.PersonID);
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProvider1.SetError(txtFirstName, "First Name is required.");
            }else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFirstName, "");
            }
        }

        private void txtSecond_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSecond.Text))
            {
                e.Cancel = true;
                txtSecond.Focus();
                errorProvider1.SetError(txtSecond, "SecondName Name is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSecond, "");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                e.Cancel = true;
                txtLastName.Focus();
                errorProvider1.SetError(txtLastName, "Last Name Name is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLastName, "");
            }
        }

        private void txtNatinolNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNatinolNo.Text)||clsPerson.IsPersonExist(txtNatinolNo.Text))
            {
                e.Cancel = true;
                txtNatinolNo.Focus();
                errorProvider1.SetError(txtNatinolNo, " Natino NO is required  ");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNatinolNo, "");
            }
            if (clsPerson.IsPersonExist(txtNatinolNo.Text))
            {
                e.Cancel = true;
                txtNatinolNo.Focus();
                errorProvider1.SetError(txtNatinolNo, "Natinol NO is exist ");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNatinolNo, "");
            }
        }

        private void dtbDateOfBirht_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dtbDateOfBirht.Text))
            {
                e.Cancel = true;
                dtbDateOfBirht.Focus();
                errorProvider1.SetError(dtbDateOfBirht, "DateOfBirht is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dtbDateOfBirht, "");
            }
    
            if (dtbDateOfBirht.Value> DateTime.Now.AddYears(-18))
            {
                e.Cancel = true;
                dtbDateOfBirht.Focus();
                errorProvider1.SetError(dtbDateOfBirht, "DateOfBirht is in valid.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dtbDateOfBirht, "");
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                e.Cancel = true;
                txtPhone.Focus();
                errorProvider1.SetError(txtPhone, "Phone is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, "");
            }
        }

        private void cmbCountry_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbCountry.Text))
            {
                e.Cancel = true;
                cmbCountry.Focus();
                errorProvider1.SetError(cmbCountry, "country is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cmbCountry, "");
            }
        }
   
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
    
            if (!txtEmail.Text.EndsWith("@gmail.com"))
            {
            
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "email format not true: (example@domain.com)");
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }
        }

        private void llblSetImge_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(pictureBox1.ImageLocation))
                {
                    pictureBox1.Image.Dispose();
                }
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                pictureBox1.Load(selectedFilePath);
                llRemoveImage.Visible = true;
                // ...
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(pictureBox1.ImageLocation))
            {
                pictureBox1.Image.Dispose();
            }
            pictureBox1.ImageLocation = null;

    
            _SetDefoultGenderImg();

            llRemoveImage.Visible = false;
        }
    }
}