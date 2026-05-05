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

namespace DVDLWinForm_PresentationLayer.User
{
    public partial class frmAdd_UpdateUser : Form
    {
        private enum _Mode { AddUser,UpdateUser};
        private _Mode _FormMode= _Mode.AddUser;
        private int _UserID;
        private clsUser _User;
        private int _personId;
        public frmAdd_UpdateUser(int UserID)
        {
            InitializeComponent();
            this._UserID = UserID;
            if (UserID != -1)
            {
                _FormMode = _Mode.UpdateUser;
               
            }
        }

        private void frmAdd_UpdateUser_Load(object sender, EventArgs e)
        {
      
            if (_FormMode == _Mode.AddUser) { 

                _User = new clsUser();
                tpLoginInfo.Enabled = false;
                _personId = -1;
                return;
            }
            lblTitel.Text = "Update User";
            this.Text= "Update Userr";
            _User = clsUser.FindUserById(_UserID);
            ctrlPersonCardWithFilter1.UpadetMode(_User.PersonId);
            lblUserID.Text = _UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.UserPassword;
            ckbIsActive.Checked = _User.IsActive;
            _personId= _User.PersonId;
            _FormMode = _Mode.UpdateUser;

        }
        private void _Save()
        {
            _User.PersonId = _personId;
            _User.UserName = txtUserName.Text;
            _User.UserPassword = txtPassword.Text;
            _User.IsActive = ckbIsActive.Checked;
            if (_User.PersonId == 0)
            {
                return;
            }
            if(_FormMode == _Mode.AddUser)
            {
                if (!this.ValidateChildren())
                {
                    // بنطلعله رسالة وبنوقف الكود عشان ما يحفظ بيانات فاضية
                    MessageBox.Show("Some fields are not valid! Please check the red error icons.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // 🛑 بنمنع الحفظ
                }
            }
           
            if (_User.Save())
            {
                MessageBox.Show("Saved successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblTitel.Text = "Update User";
                this.Text = "Update User";
                lblUserID.Text = _User.UserId.ToString();
            }
            else
            {
                MessageBox.Show("Error while saving", "erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_FormMode == _Mode.UpdateUser)
            {
                tpLoginInfo.Enabled = true;
                tbcAddUpdateUser.SelectedTab = tpLoginInfo;
                return;
            }
            if (_personId != -1)
            {
                if (_User != null)
                {
                    if (!clsUser.IsUseExistsByPersonID(_personId))
                    {
                        _User.PersonId = _personId;
                        tpLoginInfo.Enabled = true;
                        tbcAddUpdateUser.SelectedTab = tpLoginInfo;
                    }
                    else
                    {
                        MessageBox.Show("this person already has user account", "erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                    return;
            }
            else
            {
                MessageBox.Show("please select person", "erorr", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ctrlPersonCardWithFilter1_Load(object sender, EventArgs e)
        {
             
        }

        private void ctrlPersonCardWithFilter1_onFindClick(int obj)
        {
            int personID = obj;
            _personId= personID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                e.Cancel = true;
                txtUserName.Focus();
                errorProvider1.SetError(txtUserName, " User Name is required  ");

            }
            else if (clsUser.IsUseExistsByUserName(txtUserName.Text))
            {
                e.Cancel = true;
                txtUserName.Focus();
                errorProvider1.SetError(txtUserName, "User Name is exist ");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUserName, "");
            }

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, " Password is required  ");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, "");
            }
        }

        private void txtConformPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConformPassword.Text))
            {
                e.Cancel = true;
                txtConformPassword.Focus();
                errorProvider1.SetError(txtConformPassword, " Conform Password is required  ");

            }
            else if (txtConformPassword.Text != txtPassword.Text)
            {
                e.Cancel = true;
                txtConformPassword.Focus();
                errorProvider1.SetError(txtConformPassword, " Conform Passwod is defrant   ");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConformPassword, "");
            }
            
   
        }
    }
}
