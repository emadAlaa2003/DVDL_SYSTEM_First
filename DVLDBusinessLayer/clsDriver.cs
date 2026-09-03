using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsDriver
    {
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }

        public clsDriver()
        {
            this.DriverID = 0;
            this.PersonID = 0;
            this.CreatedByUserID = 0;
            this.CreatedDate = DateTime.Now;
        }

        public clsDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;
        }

        public static clsDriver Find(int DriverID)
        {
            int PersonID = 0;
            int CreatedByUserID = 0;
            DateTime CreatedDate = DateTime.Now;
            if(ClsDateDriver.FindDriverById(ref DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
            {
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            return null;
        }
        public static clsDriver FindByPersonID(int PersonID)
        {
            int DriverID = 0;
            int CreatedByUserID = 0;
            DateTime CreatedDate = DateTime.Now;
            if (ClsDateDriver.FindByPersonID(ref DriverID,  PersonID, ref CreatedByUserID, ref CreatedDate))
            {
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            return null;
        }
        private bool _AddNewDriver()
        {

            this.DriverID = ClsDateDriver.AddNewDriver(this.PersonID, this.CreatedByUserID, this.CreatedDate);
            return (this.DriverID > -1);
        }
        public bool save()
        {
            if (_AddNewDriver())
            {
                return true;
            }
            return false;
        }
        public static DataTable GetAllDrivers()
        {
            return ClsDateDriver.GetAllDriver();
        }
        public static bool DeleteDriver(int DriverID)
        {
            return ClsDateDriver.DeleteDriver(DriverID);
        }
    }
}
