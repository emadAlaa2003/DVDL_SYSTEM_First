using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsLocalDrivingLicenseApplication : clsApplication
    {
        public int LocalDrivingLicenseApplicationID { set; get; }
        public int LicenseClassID { set; get; }


        public clsLocalDrivingLicenseApplication() : base()
        {
            this.LocalDrivingLicenseApplicationID = 0;
            this.LicenseClassID = 0;
        }

        public clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int LicenseClassID, int ApplicationID, int applicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus, decimal PaidFees, int CreatedByUserID)
            : base(ApplicationID, applicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, PaidFees, CreatedByUserID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.LicenseClassID = LicenseClassID;

        }

        public static clsLocalDrivingLicenseApplication Find(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = 0; int LicenseClassID = 0;
            if (clsDataLocalDrivingApplication.FindLocalDrivingApplication(LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID))
            {
                clsApplication app = clsApplication.FindApplicationById(ApplicationID);
                if (app != null)
                {
                    return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, LicenseClassID, ApplicationID, app.ApplicantPersonID, app.ApplicationDate, app.ApplicationTypeID, app.ApplicationStatus, app.PaidFees, app.CreatedByUserID);
                }
            }

            return null;

        }
        public static clsLocalDrivingLicenseApplication FindByAppId(int ApplicationID)
        {
            int LocalDrivingLicenseApplicationID = 0; int LicenseClassID = 0;
            if (clsDataLocalDrivingApplication.FindApplicationID(ref LocalDrivingLicenseApplicationID,  ApplicationID, ref LicenseClassID))
            {
                clsApplication app = clsApplication.FindApplicationById(ApplicationID);
                if (app != null)
                {
                    return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, LicenseClassID, ApplicationID, app.ApplicantPersonID, app.ApplicationDate, app.ApplicationTypeID, app.ApplicationStatus, app.PaidFees, app.CreatedByUserID);
                }
            }

            return null;

        }
        private bool _AddNewLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseApplicationID = clsDataLocalDrivingApplication.AddLocalDrivingLicenseApplication(this.LicenseClassID, this.applicationId);
            return this.LocalDrivingLicenseApplicationID > -1;
        }
        private bool _UpdateLocalDrivingLicenseApplication()
        {
            return clsDataLocalDrivingApplication.updateLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID, this.applicationId, this.LicenseClassID);
        }
        public override bool Save()
        {
            enAppMode ModeBeforSave = this.AppMode;
            if (!base.Save())
            {

                return false;
            }
            switch (ModeBeforSave)
            {
                case enAppMode.Add:
                    {
                        if (_AddNewLocalDrivingLicenseApplication())
                        {
                            AppMode = enAppMode.Update;
                            return true;
                        }
                        else
                        {
                            clsApplication.DeleteApplication(this.applicationId);
                            return false;
                        }
                    }
                    break;

                case enAppMode.Update: return _UpdateLocalDrivingLicenseApplication(); break;


            }
            return false;
        }
        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = 0; int LicenseClassID = 0;
            if (clsDataLocalDrivingApplication.FindLocalDrivingApplication(LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID))
            {
                if (clsDataLocalDrivingApplication.DeleteeLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID))
                {
                    return clsApplication.DeleteApplication(ApplicationID);
                }
            }
            return false;

        }
        public static DataTable GetAllLocalDrivingLicenseApplications() {
            return clsDataLocalDrivingApplication.GetAllLocalDrivingLicenseApplications();
        
        }
        public static int GetCountOfPassedTest(int LocalDrivingLicenseApplicationID) {

            return clsDataLocalDrivingApplication.GetCountPassedTest(LocalDrivingLicenseApplicationID); 
        }
        public static bool ChangeStatues(int LocalAppId, byte statues)
        {
            clsLocalDrivingLicenseApplication localApp = clsLocalDrivingLicenseApplication.Find(LocalAppId);
            if(clsLocalDrivingLicenseApplication.Find(LocalAppId) != null)
            {
                return clsApplication.ChangeStatues(localApp.applicationId, statues);
            }
            return false;
        }
        public static bool IsThereAnActiveApplicationForThisClass(int PersonID, int LicenseClassID)
        {
            return clsDataLocalDrivingApplication.IsThereAnActiveApplicationForThisClass(PersonID, LicenseClassID);
        }
    }
}
