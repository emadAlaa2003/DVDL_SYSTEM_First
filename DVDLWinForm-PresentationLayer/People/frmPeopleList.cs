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
using System.IO;
namespace DVDLWinForm_PresentationLayer.People
{
    public partial class frmPeopleList : Form
    {
        private DataTable _dtAllPeople ;

        public frmPeopleList()
        {
            InitializeComponent();
        }
        private void _RefreashPeopleList()
        {
            dgvAllPeople.DataSource = clsPerson.GetAllPeopleView();
            lblNumberOfRecord.Text = dgvAllPeople.Rows.Count.ToString() ;
        }

        private string _NameHandel()
        {
            string ColmName = "";
            switch (cmbFilterType.Text)
            {
                case "Person Id": ColmName = "PersonID"; break;
                case "National No": ColmName = "NationalNo"; break;
                case "First Name": ColmName = "FirstName"; break;
                case "Second Name": ColmName = "SecondName"; break;
                case "Third Name": ColmName = "ThirdName"; break;
                case "Last Name": ColmName = "LastName"; break;
                case "Gendor": ColmName = "Gendor"; break;
                case "Phone": ColmName = "Phone"; break;
                case "Email": ColmName = "Email"; break;
                default: ColmName = "None"; break;
            }
            return ColmName;
        }
        private void _Filter()
        {
            string searchValue = txtFilterValue.Text.Trim();
            if (txtFilterValue.Text == "")
            {
                _RefreashPeopleList();
                return;
            }
            if (cmbFilterType.Text == "None" || string.IsNullOrWhiteSpace(txtFilterValue.Text))
            {
                _dtAllPeople.DefaultView.RowFilter = "";
                lblNumberOfRecord.Text = dgvAllPeople.Rows.Count.ToString();
                return;
            }

            string ColmName = _NameHandel();

            DataRow[] ResultRows;

            if (ColmName == "PersonID")
            {
                if (int.TryParse(txtFilterValue.Text.Trim(), out int id))
                {
                    ResultRows = _dtAllPeople.Select("[" + ColmName + "] = " + id);
                }
                else
                {
                    ResultRows = new DataRow[0]; 
                }
            }
            else if (ColmName == "Gendor")
            {
                // المعاملة الخاصة للجيندر (المطابقة التامة للنصوص)
                string genderInput = searchValue.ToLower();

                if (genderInput.StartsWith("m") || genderInput == "0")
                    ResultRows = _dtAllPeople.Select("[" + ColmName + "] = 'Male'");
                else if (genderInput.StartsWith("f") || genderInput == "1")
                    ResultRows = _dtAllPeople.Select("[" + ColmName + "] = 'Female'");
                else
                    ResultRows = new DataRow[0];
            }
            else
            {
            
                ResultRows = _dtAllPeople.Select("[" + ColmName + "] LIKE '%" + txtFilterValue.Text.Trim() + "%'");
            }

            if (ResultRows.Length > 0)
            {
                DataTable dtFilterdPeople = ResultRows.CopyToDataTable();
                dgvAllPeople.DataSource = dtFilterdPeople;
                lblNumberOfRecord.Text = dgvAllPeople.Rows.Count.ToString();
            }
            else
            {
                dgvAllPeople.DataSource = _dtAllPeople.Clone();
                lblNumberOfRecord.Text = "0";
            }
        }


        private void frmPeopleList_Load(object sender, EventArgs e)
        {
            _dtAllPeople = clsPerson.GetAllPeopleView();
            _RefreashPeopleList();

            cmbFilterType.SelectedIndex = 0;
            txtFilterValue.Visible=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frm=new frmAddNewPerson(-1);
            frm.ShowDialog();
            _RefreashPeopleList();
        }

        private void tsmiAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson(-1);
            frm.ShowDialog();
            _RefreashPeopleList();
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson((int)dgvAllPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreashPeopleList();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            clsPerson PersonToDelete = clsPerson.FindByID((int)dgvAllPeople.CurrentRow.Cells[0].Value);
            if (dgvAllPeople.CurrentRow == null || dgvAllPeople.CurrentRow.IsNewRow)
                return;
            if (MessageBox.Show("Are you sure you want to delete Person [" + dgvAllPeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsPerson.DeletePerson((int)dgvAllPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.","Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (PersonToDelete.ImagePath != "")
                    {
                        try
                        {
                            if (File.Exists(PersonToDelete.ImagePath))
                            {
                                File.Delete(PersonToDelete.ImagePath);
                            }
                        }
                        catch (Exception ex)
                        {
                            // نكتفي بتسجيل الخطأ أو تجاهله هنا لأن الأهم هو حذف السجل
                            // وغالباً لن يضرب خطأ لأننا استخدمنا Deep Copy في العرض
                        }
                    }
                        _RefreashPeopleList();
                }

                else
                    MessageBox.Show("Person is not deleted.", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiShowDetils_Click(object sender, EventArgs e)
        {
            if (dgvAllPeople.CurrentRow == null || dgvAllPeople.CurrentRow.IsNewRow)
                return;
            frmPersonInfo frm = new frmPersonInfo((int)dgvAllPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreashPeopleList();
        }

        private void cmbFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";

            if (cmbFilterType.Text != "None")
            {
                txtFilterValue.Visible = true;
          
            }
            else
            {
                txtFilterValue.Visible = false;
       
            }
            _RefreashPeopleList();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _Filter();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterType.Text == "Person Id")
            {
      
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            frmFindPeron frm= new frmFindPeron();
            frm.ShowDialog();
            _RefreashPeopleList();

        }

        private void tsmiSendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Text = "This feature is not implemented yet.", caption: "Not Implemented", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

        }

        private void tsmiPhoneCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Text = "This feature is not implemented yet.", caption: "Not Implemented", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

        }
    }
}
