using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;
namespace DVLDBusinessLayer
{
    public class clsApplication
    {
        public enum enAppMode { Add = 0, Update = 1 };

        public enAppMode AppMode = enAppMode.Add;
        public enum enApplicationSatus {New=1, Cancelled=2 ,Completed=3 };

        public int applicationId { set; get; }
        public int ApplicantPersonID { set; get; }
        public DateTime ApplicationDate { set; get; }

        public int ApplicationTypeID { set; get; }

        public byte ApplicationStatus { set; get; }
        public DateTime LastStatusDate { set; get; }
        public decimal PaidFees { set; get; }
        public int CreatedByUserID { set; get; }

        public clsApplication()
        {
            AppMode = enAppMode.Add;
            this.applicationId = 0;
            this.ApplicantPersonID = 0;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = 0;
            this.ApplicationStatus = 0;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = 0;
        }
        protected clsApplication(int applicationId, int applicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus, decimal PaidFees, int CreatedByUserID)
        {
            AppMode = enAppMode.Update;
            this.applicationId = applicationId;
            this.ApplicantPersonID = applicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = ApplicationDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
        }
        public static clsApplication FindApplicationById(int applicationId)
        {
            int applicantPersonID = 0; DateTime ApplicationDate = DateTime.Now; int ApplicationTypeID = 0; byte ApplicationStatus = 0;
            decimal PaidFees = 0; int CreatedByUserID = 0; DateTime LastStatusDate = DateTime.Now;
            if (clsDataApplications.FindApplicationByID(applicationId, ref applicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {
                return new clsApplication(applicationId, applicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, PaidFees, CreatedByUserID);
            }
            return null;
        }
        public static clsApplication FindApplicationByPersonId(int PersonnId)
        {
            int applicationId = 0; DateTime ApplicationDate = DateTime.Now; int ApplicationTypeID = 0; byte ApplicationStatus = 0;
            decimal PaidFees = 0; int CreatedByUserID = 0; DateTime LastStatusDate = DateTime.Now;
            if (clsDataApplications.FindApplicationByPersonID(ref applicationId,  PersonnId, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {
                return new clsApplication(applicationId, PersonnId, ApplicationDate, ApplicationTypeID, ApplicationStatus, PaidFees, CreatedByUserID);
            }
            return null;
        }
        private bool _AddNewApplication()
        {
            this.applicationId = clsDataApplications.AddApplication(ApplicantPersonID, ApplicationDate, ApplicationTypeID
                                , ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            return (applicationId != -1);
        }
        private bool _UpdateApplication()
        {
            return clsDataApplications.UpdateApplication(applicationId, ApplicantPersonID, ApplicationDate, ApplicationTypeID
                                , ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
        }
        public virtual bool Save()
        {
            switch (AppMode)
            {
                case enAppMode.Add:
                    {
                        if (_AddNewApplication())
                        {
                            AppMode = enAppMode.Update;
                            return true;
                        }
                    }
                    break;

                case enAppMode.Update: return _UpdateApplication(); break;


            }
            return false;
        }
        public static bool DeleteApplication(int applicationId)
        {
            return clsDataApplications.DeletApplication(applicationId);
        }
        public static DataTable GetAllApplications()
        {
            return clsDataApplications.GetAllApplications();
        }
        public static bool ChangeStatues(int applicationId, byte NewStatus)
        {
            return clsDataApplications.ChangeStatues(applicationId, NewStatus,DateTime.Now);
        }
    }
}
