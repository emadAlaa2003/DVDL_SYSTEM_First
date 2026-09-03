using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public  class clsLicenseClasses
    {

        public int ID { set; get; }
        public string ClassName { set; get; }
        public string Description { set; get; }
        public int MinimumAllowedAge { set; get; }
        public int DefaultValidityLength { set; get; }
        public double ClassFees { set; get; }

        public clsLicenseClasses()

        {
            this.ID = -1;
            this.ClassName = "";
            this.Description = "";
            this.DefaultValidityLength = 0;
            this.ClassFees = 0;
            this.MinimumAllowedAge = 0;

        }
        public clsLicenseClasses(int ID, string ClassName, string Description, int MinimumAllowedAge, int DefaultValidityLength, double ClassFees)
        {
            this.ID = ID;
            this.ClassName = ClassName;
            this.Description = Description;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
           
        }
        public static clsLicenseClasses Find(int ID)
        {

            string ClassName = ""; string Description = ""; int MinimumAllowedAge = 0; int DefaultValidityLength = 0; double ClassFees = 0;
           


            if (LicenseClassesData.GetLicenseClassesoByID(ID, ref ClassName, ref Description, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))

                return new clsLicenseClasses(ID,  ClassName,  Description,  MinimumAllowedAge,  DefaultValidityLength,  ClassFees);
            else
                return null;

        }
        public static clsLicenseClasses Find(string ClassName)
        {

            int  ID = 0; string Description = ""; int MinimumAllowedAge = 0; int DefaultValidityLength = 0; double ClassFees = 0;



            if (LicenseClassesData.GetLicenseClassesoByyName(ref ID,  ClassName, ref Description, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))

                return new clsLicenseClasses(ID, ClassName, Description, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;

        }
        public static DataTable GetAllLicenseClasses()
        {
            return LicenseClassesData.GetAllLicenseClasseso();

        }
    }
}
