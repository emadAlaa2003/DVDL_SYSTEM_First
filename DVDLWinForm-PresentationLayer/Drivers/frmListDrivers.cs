using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVDLWinForm_PresentationLayer.licence;
using DVLDBusinessLayer;

namespace DVDLWinForm_PresentationLayer.Drivers
{
    public partial class frmListDrivers : Form
    {
        private DataTable _dtAllDrivers;

        public frmListDrivers()
        {
            InitializeComponent();
        }
        private void _RefrchDriversList()
        {
            _dtAllDrivers = clsDriver.GetAllDrivers();

            dataGridView1.DataSource = _dtAllDrivers; // اربط الجريد بالمتغير العام
            lblNumberOfRecord.Text = _dtAllDrivers.Rows.Count.ToString();
        }
        private string _GetFilterColumnName() 
        {
            string FilterType;
            switch (cmbFilterType.Text)
            {
                case "Person ID": FilterType = "PersonID"; break;
                case "Driver ID": FilterType = "DriverID"; break;
                case "Full Name": FilterType = "FullName"; break;
                case "Active License": FilterType = "NumberOfActiveLicenses"; break;
                default: FilterType = "None"; break;
            }
            return FilterType;
        }

        private void _Filter()
        {
            string ColmName = _GetFilterColumnName();

            if (ColmName == "None" || string.IsNullOrWhiteSpace(txtFilterValue.Text))
            {
                _dtAllDrivers.DefaultView.RowFilter = ""; 
                lblNumberOfRecord.Text = dataGridView1.Rows.Count.ToString();
                return;
            }

            string filterValue = txtFilterValue.Text.Trim();

            if (ColmName == "PersonID" || ColmName == "DriverID" || ColmName == "NumberOfActiveLicenses")
            {
                if (int.TryParse(filterValue, out int id))
                {
                    _dtAllDrivers.DefaultView.RowFilter = $"[{ColmName}] = {id}";
                }
                else
                {
                    _dtAllDrivers.DefaultView.RowFilter = "1 = 0"; 
                }
            }
            else 
            {
                _dtAllDrivers.DefaultView.RowFilter = $"[{ColmName}] LIKE '%{filterValue}%'";
            }

            // تحديث عدد السجلات بعد الفلترة
            lblNumberOfRecord.Text = dataGridView1.Rows.Count.ToString();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _Filter();
        }

        private void frmListDrivers_Load(object sender, EventArgs e)
        {
            _RefrchDriversList();
        }

        private void showLiesonseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
                return;
            frmLicenseHistory frm = new frmLicenseHistory((int)dataGridView1.CurrentRow.Cells[1].Value,true);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
