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

namespace DVDLWinForm_PresentationLayer.Test
{
    public partial class frmUpdateTestType : Form
    {
        private int _TestID;
        private clsTestType _TestType;
        public frmUpdateTestType(int TestID)
        {
            InitializeComponent();
            this._TestID = TestID;
        }

        private void frmUpdateTestType_Load(object sender, EventArgs e)
        {
            _TestType=clsTestType.FindTestTypeById(this._TestID);
            if (_TestType != null)
            {
                txtTitle.Text = _TestType.TestTypeTitle;
                txtFees.Text = _TestType.TestFees.ToString();
                txtDescription.Text = _TestType.TestTypeDescription;
                lblID.Text = _TestID.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _TestType.TestFees = decimal.Parse(txtFees.Text);
            _TestType.TestTypeTitle = txtTitle.Text;
            _TestType.TestTypeDescription = txtDescription.Text;
            if (_TestType.Save())
            {
                MessageBox.Show(".TestType Save Successfully", "sussess", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(".TestType Save Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
