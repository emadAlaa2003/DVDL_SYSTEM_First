using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using DVDLWinForm_PresentationLayer.People;
using DVLDBusinessLayer;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace DVDLWinForm_PresentationLayer.User
{
    public partial class frmUsersList : Form
    {
       private DataTable _dtAllUsers;
        public frmUsersList()
        {
            InitializeComponent();
        }
        private void _RefrchUserList()
        {
            DataTable dt = clsUser.GetAllUsers();
            dgvUsersList.AutoGenerateColumns = false;
            dgvUsersList.DataSource = dt;
            lblNumberOfRecord.Text = dt.Rows.Count.ToString();
        }
        private void frmUsersList_Load(object sender, EventArgs e)
        {
            _dtAllUsers = clsUser.GetAllUsers();
            _RefrchUserList();
            cmbFilterType.SelectedIndex = 0;
            txtFilterValue.Visible = false;
        }
        private string _GetFiltetTypeName()
        {
            string FilterType;
            switch (cmbFilterType.Text)
            {

                case "Person ID": FilterType = "PersonID"; break;
                case "User ID": FilterType = "UserID"; break;
                case "Full Name": FilterType = "FullName"; break;
                case "User Name": FilterType = "UserName"; break;
                case "Is Active": FilterType = "IsActive"; break;
                default: FilterType = "None"; break;
            }
            return FilterType;
        }
        private void _Filter()
        {
            string ColmName = _GetFiltetTypeName();

            if (ColmName == "None")
            {
                dgvUsersList.DataSource = _dtAllUsers;
                lblNumberOfRecord.Text = dgvUsersList.Rows.Count.ToString();
                return;
            }

            DataRow[] ResultRows;

            if (ColmName == "IsActive")
            {
                if (cmbAsActive.Text == "Active")
                {
                    ResultRows = _dtAllUsers.Select("[" + ColmName + "] = true");
                }
                else if (cmbAsActive.Text == "Not Active")
                {
                    ResultRows = _dtAllUsers.Select("[" + ColmName + "] = false");
                }
                else
                {
                    ResultRows = _dtAllUsers.Select();
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtFilterValue.Text))
                {
                    dgvUsersList.DataSource = _dtAllUsers;
                    lblNumberOfRecord.Text = dgvUsersList.Rows.Count.ToString();
                    return;
                }

                if (ColmName == "PersonID" || ColmName == "UserID")
                {
                    if (int.TryParse(txtFilterValue.Text.Trim(), out int id))
                    {
                        ResultRows = _dtAllUsers.Select("[" + ColmName + "] = " + id);
                    }
                    else
                    {
                        ResultRows = new DataRow[0];
                    }
                }
                else
                {
                    ResultRows = _dtAllUsers.Select("[" + ColmName + "] LIKE '%" + txtFilterValue.Text.Trim() + "%'");
                }
            }

            if (ResultRows.Length > 0)
            {
                DataTable dtFilterdPeople = ResultRows.CopyToDataTable();
                dgvUsersList.DataSource = dtFilterdPeople;
                lblNumberOfRecord.Text = dgvUsersList.Rows.Count.ToString();
            }
            else
            {
                dgvUsersList.DataSource = _dtAllUsers.Clone();
                lblNumberOfRecord.Text = "0";
            }
        }
        private void cmbFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            if (cmbFilterType.Text == "None") { 
                txtFilterValue.Visible = false;
                cmbAsActive.Visible = false;

            }
            else if(cmbFilterType.Text =="Is Active")
            {
                txtFilterValue.Visible = false;
                cmbAsActive.Visible = true;
            }
            else
            {
                txtFilterValue.Visible = true;
                cmbAsActive.Visible = false;
            }
            
            
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _Filter();
        }

        private void cmbAsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Filter();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAdd_UpdateUser frm = new frmAdd_UpdateUser(-1);
            frm.ShowDialog();
            _RefrchUserList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsersList.CurrentRow == null || dgvUsersList.CurrentRow.IsNewRow)
                return;
            frmUserDetiels frm = new frmUserDetiels((int)dgvUsersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefrchUserList();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd_UpdateUser frm = new frmAdd_UpdateUser(-1);
            frm.ShowDialog();
            _RefrchUserList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd_UpdateUser frm = new frmAdd_UpdateUser((int)dgvUsersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefrchUserList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUser UserToDelete = clsUser.FindUserById((int)dgvUsersList.CurrentRow.Cells[0].Value);
            if (dgvUsersList.CurrentRow == null || dgvUsersList.CurrentRow.IsNewRow)
                return;
            if (MessageBox.Show("Are you sure you want to delete User [" + dgvUsersList.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsUser.DeletUser((int)dgvUsersList.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User Deleted Successfully.","Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
  
                    _RefrchUserList();
                }

                else
                    MessageBox.Show("User is not deleted.","Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword((int)dgvUsersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefrchUserList();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Text = "This feature is not implemented yet.", caption: "Not Implemented", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
        }

        private void callPhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Text = "This feature is not implemented yet.", caption: "Not Implemented", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
        }
    }
    }

