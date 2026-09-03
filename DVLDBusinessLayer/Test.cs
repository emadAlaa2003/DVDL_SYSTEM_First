using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsTest
    {
        public int TestID { set; get; }
        public int TestAppointmentID { set; get; }
        public string Notes { set;get; }
        public bool TestResult { set; get; }
        public int CreatedByUserID { set; get; }
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public clsTest() { 
            this.TestID = 1;
            this.TestAppointmentID = 1;
            this.Notes = "";
            this.TestResult = false;
            this.CreatedByUserID = 0;
            Mode = enMode.AddNew;
        }
        public clsTest(int testID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserId)
        {
            this.TestID = testID;
            this.TestAppointmentID = TestAppointmentID;
            this.Notes = Notes;
            this.TestResult = TestResult;
            this.CreatedByUserID = CreatedByUserId;
            Mode = enMode.Update;
        }

        public static clsTest Find(int testID) { 
            int TestAppointmentID = 0;
            string Notes = "";
            bool TestResult = false;
            int CreatedByUserID = 0;

            if(ClsDataTest.FindTest(testID,ref TestAppointmentID,ref TestResult,ref Notes,ref CreatedByUserID))
            {
                return new clsTest(testID,TestAppointmentID,TestResult,Notes,CreatedByUserID);
            }
            return null;
        
        }

        private bool _AddTest()
        {
            this.TestID=ClsDataTest.AddTest(TestAppointmentID,TestResult,Notes,CreatedByUserID);
            return (this.TestID > 0);
        }
        private bool _UpdateTest()
        {
            return (ClsDataTest.UpdateTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID));
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddTest())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                    }
                    break;
                case enMode.Update:
                    if (_UpdateTest())
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }
        public static bool DeletTest(int testId)
        {
            return ClsDataTest.DeletTest(testId);
        }
        public static int GetTestTrilCount(int LocalDrivingLicenseApplicationID, int TestTypeID, bool TestResult)
        {
            return ClsDataTest.GetTestTrilCount(LocalDrivingLicenseApplicationID, TestTypeID, TestResult);
        }
    }
}
