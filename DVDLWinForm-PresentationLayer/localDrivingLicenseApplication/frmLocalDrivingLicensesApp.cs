using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDLWinForm_PresentationLayer.localDrivingLicenseApplication
{
    public partial class frmLocalDrivingLicensesAppInfo : Form
    {
        private int _AppId = 0;
        public frmLocalDrivingLicensesAppInfo(int localID)
        {
            InitializeComponent();
            _AppId = localID;
        }

        private void frmLocalDrivingLicensesAppInfo_Load(object sender, EventArgs e)
        {
            ctrlAppLocalDetiels1.LoadInfo(_AppId);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
