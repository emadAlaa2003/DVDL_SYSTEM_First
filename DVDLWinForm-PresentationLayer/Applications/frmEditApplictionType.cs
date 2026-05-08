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

namespace DVDLWinForm_PresentationLayer.Applications
{
    public partial class frmEditApplictionType : Form
    {
        private int _AppId;
        private clsApplactionType _AppType;
        public frmEditApplictionType(int Id)
        {
            InitializeComponent();
            this._AppId = Id;
        }

        private void frmEditApplictionType_Load(object sender, EventArgs e)
        {
            _AppType=clsApplactionType.FindApplactionTypeById(this._AppId);
            txtFees.Text=_AppType.ApplicationTypeFees.ToString();
            txtTitle.Text = _AppType.ApplicationTypeName;
            lblID.Text = _AppId.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _AppType.ApplicationTypeFees= decimal.Parse(txtFees.Text);
            _AppType.ApplicationTypeName = txtTitle.Text;
            if (_AppType.Save())
            {
                MessageBox.Show(".ApplicationType Save Successfully","sussess",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else {
                MessageBox.Show(".ApplicationType Save Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
