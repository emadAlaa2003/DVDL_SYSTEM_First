using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDLWinForm_PresentationLayer.People
{
    public partial class frmPersonInfo : Form
    {
        int PersonId;
        public frmPersonInfo(int PersonID)
        {

            InitializeComponent();
            this.PersonId = PersonID;
        }

        private void frmPersonInfo_Load(object sender, EventArgs e)
        {
           ctrlPersonDetiels1.LoadPersonInfo(this.PersonId);
        }

        private void ctrlPersonDetiels1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
