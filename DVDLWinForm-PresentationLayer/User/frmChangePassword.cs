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

namespace DVDLWinForm_PresentationLayer.User
{
    public partial class frmChangePassword : Form
    {
        private int _UserId;
        private clsUser _User;
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            this._UserId = UserID;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _User=clsUser.FindUserById(this._UserId);
            ctrlUserDetiels1.UserDetiels_Load(_UserId);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _User.UserPassword=txtNewPassword.Text;
            if (_User.Save())
            {
                MessageBox.Show("passwoed save secsess", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
            {
                e.Cancel = true;
                txtCurrentPassword.Focus();
                errorProvider1.SetError(txtCurrentPassword, " Current Password is Reqeard  ");

            }else if(txtCurrentPassword.Text != _User.UserPassword)
            {
                e.Cancel = true;
                txtCurrentPassword.Focus();
                errorProvider1.SetError(txtCurrentPassword, " Current Password is false  ");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCurrentPassword, "");
            }

        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                e.Cancel = true;
                txtNewPassword.Focus();
                errorProvider1.SetError(txtNewPassword, " new Password is Reqeard  ");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNewPassword, "");
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
            else if (txtConformPassword.Text != txtNewPassword.Text)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
