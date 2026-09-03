using System;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVDLWinForm_PresentationLayer.licence
{
    public partial class frmLicenceInfo : Form
    {
        int _LicenseID = -1;

        public frmLicenceInfo(int LicenseID) 
        {
            InitializeComponent();
            this._LicenseID = LicenseID;
        }

        private void _LoadInfo()
        {
            if (_LicenseID == -1)
            {
                return;
            }

            clsLicense license = clsLicense.Find(_LicenseID);

            if (license == null)
            {
                MessageBox.Show("No License found with this ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlLoadLesoinInfo1.LoadLesoinInfo(_LicenseID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLicenceInfo_Load(object sender, EventArgs e)
        {
            _LoadInfo();
        }
    }
}