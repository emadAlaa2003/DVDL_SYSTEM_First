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

namespace DVDLWinForm_PresentationLayer.licence
{
    public partial class frmLicenseHistory : Form
    {
        int _LocalAppId;
        private int _PersonID = -1;
        public frmLicenseHistory(int LocalAppId)
        {
            InitializeComponent();
            _LocalAppId = LocalAppId;
            clsLocalDrivingLicenseApplication objLocalApp = clsLocalDrivingLicenseApplication.Find(_LocalAppId);
            if (objLocalApp == null) return;
            _PersonID = objLocalApp.ApplicantPersonID;
        }
       

        public frmLicenseHistory(int PersonID, bool isPersonID) // ضفنا isPersonID بس عشان نفرقه عن الأول
        {
            InitializeComponent();
            _PersonID = PersonID;
        }
        private void _LoadData()
        {
            ctrlLicencesList1.LoadInfo(_PersonID);
            ctrlPersonCardWithFilter1.UpadetMode(_PersonID);

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
