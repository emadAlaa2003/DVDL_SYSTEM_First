using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDLWinForm_PresentationLayer.User
{
    public partial class frmUserDetiels : Form
    {
        public frmUserDetiels(int userID)
        {
            InitializeComponent();
            ctrlUserDetiels1.UserDetiels_Load(userID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
