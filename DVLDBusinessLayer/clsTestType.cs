using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsTestType
    {
        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public decimal TestFees { get; set; }

        private clsTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestFees = TestFees;
        }
        private bool _UpdateTestType()
        {
            return clsDataTestType.UpdateTestType(this.TestTypeID, this.TestTypeTitle, this.TestTypeDescription, this.TestFees);
        }
        public static clsTestType FindTestTypeById(int TestTypeID)
        {
            string TestTypeTitle = "";
            string TestTypeDescription = "";
            decimal TestFees = 0;
            if (clsDataTestType.FindTestTypeById(TestTypeID, ref TestTypeTitle, ref TestTypeDescription, ref TestFees))
            {
                return new clsTestType(TestTypeID, TestTypeTitle, TestTypeDescription, TestFees);
            }
            return null;
        }
        public bool Save()
        {
            return _UpdateTestType();
        }
        public static DataTable GetAllTestTypes()
        {
            return clsDataTestType.GetAllTestTypes();
        }
    }
}
