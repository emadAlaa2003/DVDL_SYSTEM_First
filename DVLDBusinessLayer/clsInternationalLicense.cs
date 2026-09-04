using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsInternationalLicense
    {
        public int InternationalLicenseID { set; get; }
        public int ApplicationID { set; get; }
        public int DriverID { set; get; }
        public int IssuedUsingLocalLicenseID { set; get; }
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public bool IsActive { set; get; }
        public int CreatedByUserID { set; get; }
        public int ApplicantPersonID { set; get; }

        public clsInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
        }
        public clsInternationalLicense() {
            this.InternationalLicenseID = 0;
            this.ApplicationID = 0;
            this.DriverID = 0;
            this.IssuedUsingLocalLicenseID = 0;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.IsActive = false;
            this.CreatedByUserID = 0;
        }
        public static clsInternationalLicense Find(int InternationalLicenseID)
        {
           
          int ApplicationID = 0;
            int DriverID = 0;
            int IssuedUsingLocalLicenseID = 0;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            bool IsActive = false;
            int  CreatedByUserID = 0;
            if(clsDataInternationalLicenses.FindInternationaLicensesByID(InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }
        public static clsInternationalLicense GetActiveInternationalLicenseByDriverID(int DriverID)
        {
            int InternationalLicenseID = -1;
            int ApplicationID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            bool IsActive = false;
            int CreatedByUserID = -1;

            if (clsDataInternationalLicenses.GetActiveInternationalLicenseInfoByDriverID(DriverID,
                ref InternationalLicenseID, ref ApplicationID, ref IssuedUsingLocalLicenseID,
                ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID,
                    IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }
        private bool _AddNewInternationalLicense()
        {
            clsApplication Application = new clsApplication();

            Application.ApplicantPersonID = this.ApplicantPersonID;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationTypeID = 6; 
            Application.ApplicationStatus = (int)clsApplication.enApplicationSatus.Completed; 
            Application.LastStatusDate = DateTime.Now;

     
            Application.PaidFees = clsApplactionType.FindApplactionTypeById(6).ApplicationTypeFees;

            Application.CreatedByUserID = this.CreatedByUserID;

            if (!Application.Save())
            {
                return false; 
            }

            this.ApplicationID = Application.applicationId;

            this.InternationalLicenseID = clsDataInternationalLicenses.AddNewInternationalLicense(
                this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID,
                this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);

            return (this.InternationalLicenseID > 0);
        }

        public bool Save()
        {
            return _AddNewInternationalLicense();
        }
        public static DataTable GetAllInternationalLicenses()
        {
            return clsDataInternationalLicenses.GetAllLicenses();
        }
        public static DataTable GetAllInternationalLicensesByPersonId(int PersonID)
        {
            return clsDataInternationalLicenses.GetAllInternationalLicensesByPersonId(PersonID);
        }
    }
}
