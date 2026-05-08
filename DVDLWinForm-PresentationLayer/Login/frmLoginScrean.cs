using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVDLWinForm_PresentationLayer.User;
using DVLDBusinessLayer;
using System.IO;
namespace DVDLWinForm_PresentationLayer.Login
{
    public partial class frmLoginScrean : Form
    {
        private clsUser _User ;
        public frmLoginScrean()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         private void SaveCredentials(string userName,string Password)
        {
            string FilePath = Application.StartupPath+"\\credentials.txt";
            string[] Lines = { userName, Password };
            File.WriteAllLines(FilePath, Lines);
        }
        private void _LoadCredentials()
        {
            string filePath = Application.StartupPath + "\\credentials.txt";

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length == 2)
                {
                    txtUserName.Text = lines[0]; // السطر الأول
                    TxtPassword.Text = lines[1]; // السطر الثاني
                    chkRememberMe.Checked = true; // بنفعل الشيك بوكس
                }
            }
        }
        private bool _Login()
        {
           clsUser _User =clsUser.FindUserByUserName(txtUserName.Text);
            if (_User == null|| _User.UserPassword!=TxtPassword.Text) {
                MessageBox.Show(" User Name Or Passwor is Woring", "erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           else if(_User.IsActive == false)
            {
                MessageBox.Show(" User Is Not Active contact wiht your admin", "erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            clsGloabelSettings.CurrentUser = _User;
            if(chkRememberMe.Checked)
            {
                SaveCredentials(txtUserName.Text, TxtPassword.Text);
            }
            else
            {
                string FilePath = Application.StartupPath + "\\credentials.txt";
                if (File.Exists(FilePath))
                {
                    File.Delete(FilePath);
                }
            }
            return true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_Login())
            {
                this.Hide();
                MinForm mainForm = new MinForm();
                mainForm.Show();
            }

     
            
        }

        private void frmLoginScrean_Load(object sender, EventArgs e)
        {
            _LoadCredentials();
        }
    }
}
