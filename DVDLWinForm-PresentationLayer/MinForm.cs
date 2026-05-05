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
using DVDLWinForm_PresentationLayer.User;

namespace DVDLWinForm_PresentationLayer
{
    public partial class MinForm : Form
    {
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
    }
}
