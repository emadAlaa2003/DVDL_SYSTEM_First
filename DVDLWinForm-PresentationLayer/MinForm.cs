using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVDLWinForm_PresentationLayer.Applications;
using DVDLWinForm_PresentationLayer.Login;
using DVDLWinForm_PresentationLayer.People;
using DVDLWinForm_PresentationLayer.User;

namespace DVDLWinForm_PresentationLayer
{
    public partial class MinForm : Form
    {
        //git test
        public MinForm()
        {
            InitializeComponent();
        }

        private void TmsiPeople_Click(object sender, EventArgs e)
        {
            frmPeopleList form = new frmPeopleList();
            form.ShowDialog();
        }

        private void TmsiUsers_Click(object sender, EventArgs e)
        {
            frmUsersList form = new frmUsersList();
            form.ShowDialog();
        }

        private void adddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginScrean form = new frmLoginScrean();
            form.ShowDialog();
        }

        private void MinForm_FormClosed(object sender, FormClosedEventArgs e)
        {
    
            Application.Exit();
        
          }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetiels frm =new frmUserDetiels(clsGloabelSettings.CurrentUser.UserId);
             frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGloabelSettings.CurrentUser.UserId);
            frm.ShowDialog();
        }

        private void singOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGloabelSettings.CurrentUser = null;
            Application.Restart();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApplicationTypes frm = new frmApplicationTypes();
            frm.ShowDialog();
        }
    }
}
