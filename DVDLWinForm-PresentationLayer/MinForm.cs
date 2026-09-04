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
using DVDLWinForm_PresentationLayer.Drivers;
using DVDLWinForm_PresentationLayer.InternationalLicenses;
using DVDLWinForm_PresentationLayer.localDrivingLicenseApplication;
using DVDLWinForm_PresentationLayer.Login;
using DVDLWinForm_PresentationLayer.People;
using DVDLWinForm_PresentationLayer.Test;
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

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestTypes frm= new frmTestTypes();
            frm.ShowDialog();
        }

     

        private void localDrivingLiceneseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListLocalDrivingLicenseApplactions frm = new frmListLocalDrivingLicenseApplactions();
            frm.ShowDialog();
        }

        private void TmsiDrivers_Click(object sender, EventArgs e)
        {
            frmListDrivers frm = new frmListDrivers();
            frm.ShowDialog();
        }

        private void localLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditeLocalDrivingApp frm = new frmAddEditeLocalDrivingApp(-1);
            frm.ShowDialog();
        }

        private void internationalLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewInterationalLicenseApplication frm = new frmNewInterationalLicenseApplication();
            frm.ShowDialog();
        }

        private void interntionalLicensesApplictonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInterntionalLicesesApplictions frm = new frmInterntionalLicesesApplictions();
            frm.ShowDialog();
        }
    }
}
