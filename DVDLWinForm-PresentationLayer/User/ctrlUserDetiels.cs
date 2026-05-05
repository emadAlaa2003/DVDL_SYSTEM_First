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
    public partial class ctrlUserDetiels : UserControl
    {
        public ctrlUserDetiels()
        {
            InitializeComponent();
        }

        private void ctrlUserDetiels_Load(object sender, EventArgs e)
        {

        }
        public void UserDetiels_Load(int UserID)
        {
            clsUser user = clsUser.FindUserById(UserID);
            if (user != null)
            {
                ctrlPersonDetiels1.LoadPersonInfo(user.PersonId);
                lblUserName.Text = user.UserName;
                lblUserID.Text = user.UserId.ToString();
                lblIsActive.Text = user.IsActive.ToString();

            }
            return;


        }
    }
}
