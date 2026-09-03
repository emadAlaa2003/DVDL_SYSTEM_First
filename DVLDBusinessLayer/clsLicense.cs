using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsLicense
    {
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public byte IssueReason { get; set; }
        public int CreatedByUserID { get; set; }
        public enum enIssueReason
        {
            FirstTime = 1, Renew = 2, ReplacementDamge = 3, ReplacementLost = 4
        };

        public clsLicense()
        {
            this.LicenseID = 0;
            this.ApplicationID = 0;
            this.DriverID = 0;
            this.LicenseClass = 0;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = 0;
            this.IsActive = true;
            this.IssueReason = 0;
            this.CreatedByUserID = 0;
        }
        public clsLicense(int licenseID, int applicationID, int driverID, int licenseClass, DateTime issueDate, DateTime expirationDate, string notes, decimal paidFees, bool isActive, byte issueReason, int createdByUserID)
        {
            LicenseID = licenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            LicenseClass = licenseClass;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = isActive;
            IssueReason = issueReason;
            CreatedByUserID = createdByUserID;
        }
        public static clsLicense Find(int LicenseID)
        {
            int ApplicationID = 0; int DriverID = 0; int LicenseClass = 0;
            DateTime IssueDate = DateTime.Now; DateTime ExpirationDate = DateTime.Now; string Notes = ""; decimal PaidFees = 0; bool IsActive = false;
            byte IssueReason = 0; int CreatedByUserID = 0;
            if (clsDataLicenses.FindLicensById(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass,
                ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            }
            return null;
        }
        public static clsLicense FindByAppID(int ApplicationID)
        {
            int LicenseID = 0; int DriverID = 0; int LicenseClass = 0;
            DateTime IssueDate = DateTime.Now; DateTime ExpirationDate = DateTime.Now; string Notes = ""; decimal PaidFees = 0; bool IsActive = false;
            byte IssueReason = 0; int CreatedByUserID = 0;
            if (clsDataLicenses.FindLicensByApppID(ref LicenseID, ApplicationID, ref DriverID, ref LicenseClass,
                ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            }
            return null;
        }
        private bool _AddNewLicense()
        {
            this.LicenseID = clsDataLicenses.AddNewLicens(this.ApplicationID, this.DriverID, this.LicenseClass,
                this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);
            return (this.LicenseID > -1);
        }
        public bool save()
        {
            if (_AddNewLicense())
            {
                return true;
            }
            return false;
        }
        public static DataTable GetAllLicenses()
        {
            return clsDataLicenses.GetAllLicenses();
        }
        public static DataTable GetAllLicensesByPersonID(int PersonId)
        {
            return clsDataLicenses.GetAllLicensesByPersonId(PersonId);
        }
    }

 }

