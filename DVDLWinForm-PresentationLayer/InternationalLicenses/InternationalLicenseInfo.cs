using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDLWinForm_PresentationLayer.InternationalLicenses
{
    public partial class frmInternationalLicenseInfo : Form
    {
        int _intLeconseID=-1;
        public frmInternationalLicenseInfo(int intLeconseID)
        {
            InitializeComponent();
            _intLeconseID=intLeconseID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            if (_intLeconseID == -1)
            {
                return;
            }
            ctrlInternationalLicensesInfo1.LoadLicenseInfo(_intLeconseID);
        }
    }
}
