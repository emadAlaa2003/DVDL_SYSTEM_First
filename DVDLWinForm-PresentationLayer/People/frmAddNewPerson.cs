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

namespace DVDLWinForm_PresentationLayer.People
{
    public partial class frmAddNewPerson : Form
    {
        public delegate void DataBackEventHandler(object sender, int personID);
        public event DataBackEventHandler DataBack;
        int PersonID;
        public frmAddNewPerson(int PersonID)
        {
            InitializeComponent();
            this.PersonID = PersonID;
        }

        private void frmAddNewPerson_Load(object sender, EventArgs e)
        {
            ctrlAdd_UpdatePerson1.LoadPersonInfo(PersonID);
            if (PersonID != -1)
            {
                lblTitel.Text = "Update Person";
                this.Text = "Update Person";
                lblPersonId.Text = PersonID.ToString();
            }

        }

        private void ctrlAdd_UpdatePerson1_onSavedClick(int obj)
        {
            PersonID = obj;
            lblTitel.Text = "Update Person";
            this.Text = "Update Person";

            lblPersonId.Text = PersonID.ToString();
            ctrlAdd_UpdatePerson1.LoadPersonInfo(PersonID);

            
    
        }

        private void ctrlAdd_UpdatePerson1_onCloseClick(int obj)
        {
            this.Close();
            if (PersonID != -1)
            {
                DataBack?.Invoke(this, PersonID);


            }
        }
    }
}
