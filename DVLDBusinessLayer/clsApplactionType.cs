using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public  class clsApplactionType
    {
        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeName { get; set; }
        public decimal ApplicationTypeFees { get; set; }
        //public clsApplactionType()
        //{
        //    this.ApplicationTypeID = 0;
        //    this.ApplicationTypeName = "";
        //}
        public clsApplactionType(int ApplicationTypeID,string ApplicationTypeName, decimal ApplicationTypeFees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeName = ApplicationTypeName;
            this.ApplicationTypeFees = ApplicationTypeFees;
        }
        public static clsApplactionType FindApplactionTypeById(int ApplicationTypeID)
        {
            string ApplicationTypeName="";
            decimal ApplicationTypeFees=0;
            if(clsDataApplactionTypes.FindApplactionTypeByID(ApplicationTypeID,ref  ApplicationTypeName,ref ApplicationTypeFees))
            {
                return new clsApplactionType(ApplicationTypeID, ApplicationTypeName, ApplicationTypeFees);
            }
            return null;
        }
        public static DataTable GetAllApplactionTypes()
        {
            return clsDataApplactionTypes.GetAllApplactinType();
        }
        public bool _UpdateApplactionType()
        {
            return clsDataApplactionTypes.UpdateApplactinType(this.ApplicationTypeID,this.ApplicationTypeName,this.ApplicationTypeFees);
        }
        public bool Save()
        {
            return _UpdateApplactionType();
        }
    }
}
