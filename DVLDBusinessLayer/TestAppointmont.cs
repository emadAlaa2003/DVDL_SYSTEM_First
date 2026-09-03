using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;
namespace DVLDBusinessLayer
{
    public class clsTestAppointmont
    {
        public int appointmentID { set; get; }
        public int TestTypeID { set; get; }
        public int LocalDrivingLicenseApplicationID { set; get; }
        public DateTime AppointmentDate { set; get; }
        public decimal PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public bool IsLocked { set; get; }
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public clsTestAppointmont()
        {
            this.appointmentID = 0;
            this.TestTypeID = 0;
            this.LocalDrivingLicenseApplicationID = 0;
            this.CreatedByUserID = 0;
            this.IsLocked = true;
            this.AppointmentDate = new DateTime(
                DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            this.PaidFees = 0;
            Mode = enMode.AddNew;
        }
        public clsTestAppointmont(int appointmentID, int testTypeID, int localDrivingLicenseApplicationID, DateTime appointmentDate, decimal paidFees, int createdByUserID, bool isLocked)
        {
            this.appointmentID = appointmentID;
            TestTypeID = testTypeID;
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            AppointmentDate = appointmentDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            IsLocked = isLocked;
            Mode = enMode.Update;
        }
        public static clsTestAppointmont Find(int appointmentID)
        {
            int TestTypeID = 0;
            int LocalDrivingLicenseApplicationID = 0;
            DateTime AppointmentDate = new DateTime();
            decimal PaidFees = 0;
            int CreatedByUserID = 0;
            bool IsLocked = true;
            if (clsDataTestAppointmont.FindTestAppointmentById(appointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked))
            {
                return new clsTestAppointmont(appointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked);
            }
            return null;
        }
        private bool _AddTestAppointment()
        {
            this.appointmentID = clsDataTestAppointmont.AddTestAppointment(TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked);
            return (appointmentID > 0);
        }
        private bool _UpdateTestAppointment()
        {
            return (clsDataTestAppointmont.UpdateTestAppointment(appointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked));
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddTestAppointment())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                    }
                    break;
                case enMode.Update:
                    if (_UpdateTestAppointment())
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }
        public static DataTable GetAllTestAppointmonts()
        {
            return clsDataTestAppointmont.GetAppointments();
        }
        public static DataTable GetAllTestAppointmontsByLocalAppId(int localApp, int TestTypeID)
        {
            return clsDataTestAppointmont.GetAppointmentsByLocalAppID(localApp,  TestTypeID);
        }
        public static bool IsThereActiveAppointment(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsDataTestAppointmont.IsThereActiveAppointment(LocalDrivingLicenseApplicationID, TestTypeID);
        }
    }
}
