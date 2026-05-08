using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DVLDDataAccessLayer;
namespace DVLDBusinessLayer
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }
        public clsPerson()
        {
            this.PersonID = 0;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gendor = 0;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = 1;
            this.ImagePath = "";
            Mode = enMode.AddNew;
        }
        private clsPerson(int PersonID,  string NationalNo,  string FirstName,  string SecondName
                                    ,  string ThirdName,  string LastName,  DateTime DateOfBirth,  byte Gendor
                                   ,  string Address,  string Phone,  string Email,  int NationalityCountryID,  string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;

            Mode = enMode.Update;
        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonDataAccess.AddNewPerson(this.NationalNo, this.FirstName, this.SecondName
                                    , this.ThirdName, this.LastName, this.DateOfBirth, this.Gendor
                                   , this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
            return (this.PersonID != -1);
        }
        private bool _UpdatePerson()
        {
            return clsPersonDataAccess.UpdatePerson(this.PersonID, this.NationalNo, this.FirstName, this.SecondName
                                    , this.ThirdName, this.LastName, this.DateOfBirth, this.Gendor
                                   , this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePerson();
            }
            return false;
        }

        public static clsPerson FindByID(int PersonID)
        {
            string NationalNo = ""; string FirstName = ""; string SecondName = ""; string ThirdName = "";
            string LastName = ""; DateTime DateOfBirth = DateTime.Now; byte Gendor = 1; string Address = "";
            string Phone = ""; string Email = ""; int NationalityCountryID = 0; string ImagePath = "";

            if (clsPersonDataAccess.GetPersonInfoById(PersonID, ref NationalNo, ref FirstName, ref SecondName
                                    , ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor
                                   , ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(PersonID,  NationalNo,  FirstName,  SecondName
                                      ,  ThirdName,  LastName,  DateOfBirth,  Gendor
                                     ,  Address,  Phone,  Email,  NationalityCountryID,  ImagePath);
            }
            else
            {
                return null;
            }


        }

        public static clsPerson FindByNationalNo(string NationalNo)
        {
          
           int PersonID=0; string FirstName = ""; string SecondName = ""; string ThirdName = "";
            string LastName = ""; DateTime DateOfBirth = DateTime.Now; byte Gendor = 1; string Address = "";
            string Phone = ""; string Email = ""; int NationalityCountryID = 0; string ImagePath = "";

            if (clsPersonDataAccess.GetPersonInfoByNationalNo(ref PersonID,  NationalNo, ref FirstName, ref SecondName
                                    , ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor
                                   , ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(PersonID,  NationalNo,  FirstName,  SecondName
                                      ,  ThirdName,  LastName,  DateOfBirth,  Gendor
                                     ,  Address,  Phone,  Email,  NationalityCountryID,  ImagePath);
            }
            else
            {
                return null;
            }


        }
        public static DataTable GetAllPeople()
        {
            return clsPersonDataAccess.GetAllPeople();
        }
        public static DataTable GetAllPeopleView()
        {
            return clsPersonDataAccess.GetAllPeopleViewList();
        }
        public static bool DeletePerson(int PersonID)
        {
            return clsPersonDataAccess.DeletPerson(PersonID);
        }

        public static bool IsPersonExist(int PersonID)
        {
            return clsPersonDataAccess.IsPersonExist(PersonID);
        }
        public static bool IsPersonExist(string NationalNo)
        {
            return clsPersonDataAccess.IsPersonExist(NationalNo);
        }
    }
}
