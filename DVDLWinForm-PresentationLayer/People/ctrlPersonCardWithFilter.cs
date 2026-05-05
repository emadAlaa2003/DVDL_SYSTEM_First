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
namespace DVDLWinForm_PresentationLayer.People
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
   

            public event Action<int> onFindClick;

            protected virtual void FindClick(int personID)

            {

                Action<int> handlar = onFindClick;

                if (handlar != null)

                {

                    handlar(personID);

                }

            }
            public ctrlPersonCardWithFilter()
               {
                 InitializeComponent();
                }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cmbFindby.SelectedIndex = 1;
        }
        private bool _findPerson()
        {
            
            clsPerson person;
            if (string.IsNullOrWhiteSpace(txtFind.Text))
            {
                MessageBox.Show("plesee enter value", "erorr", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbFindby.Text == "Person ID")
            {
                if (int.TryParse(txtFind.Text.Trim(), out int PersonID))
                {
                    person = clsPerson.FindByID(PersonID);
                }
                else
                {
                    MessageBox.Show("plese enter valid value", "erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; 
                }
            }
            else
            {
                person = clsPerson.FindByNationalNo(txtFind.Text);
            }
            if (person != null)
            {
                ctrlPersonDetiels1.LoadPersonInfo(person.PersonID);
                if (onFindClick != null)
                {
                    onFindClick(person.PersonID);
                }
                return true; 
            }
            else
                return false;
            return false;
        }
        private void btnFindPerson_Click(object sender, EventArgs e)
        {

            if (!_findPerson())
            {
                MessageBox.Show("Person Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cmbFindby.Text == "Person ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void cmbFindby_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFind.Text = "";
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frm= new frmAddNewPerson(-1);
            frm.DataBack += frmAddNewPerson_DataBack;
            frm.ShowDialog();

        }
        private void frmAddNewPerson_DataBack(object sender, int personID)
        {

            cmbFindby.SelectedIndex = cmbFindby.FindString("Person ID");

            txtFind.Text = personID.ToString();

            btnFindPerson.PerformClick();
        }

        public void UpadetMode(int PersonID)
        {
            grbFilter.Enabled = false;
            ctrlPersonDetiels1.LoadPersonInfo(PersonID);
        }
    }
}
