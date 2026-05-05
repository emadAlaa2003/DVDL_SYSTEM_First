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
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        enMode Mode = enMode.AddNew;
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int PersonId { get; set; }
        public bool IsActive { get; set; }


        public clsUser()
        {
            this.UserId = 0;
            this.UserName = "";
            this.UserPassword = "";
            this.PersonId = 0;
            this.IsActive = false;
            Mode = enMode.AddNew;
        }
        private clsUser(int UserId, int PersonId, string UserName, string UserPassword, bool IsActive)
        {
            this.UserId = UserId;
            this.PersonId = PersonId;
            this.UserName = UserName;
            this.UserPassword = UserPassword;
            this.IsActive = IsActive;
            Mode = enMode.Update;
        }
        private bool _AddNewUser()
        {
            this.UserId = clsUserData.AddNewUser(this.PersonId, this.UserName, this.UserPassword, this.IsActive);
            return (this.UserId != -1);
        }
        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.UserId, this.UserName, this.UserPassword, this.IsActive);
        }
        public static clsUser FindUserById(int UserId)
        {
            string UserNamw = "";
            string UserPassword = "";
            bool IsActive = false;
            int PersonId = 0;
            if (clsUserData.GetUserInfoByID(UserId, ref PersonId, ref UserNamw, ref UserPassword, ref IsActive))
            {
                return new clsUser(UserId, PersonId, UserNamw, UserPassword, IsActive);
            }
            return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewUser())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;

                    }
                case enMode.Update:
                    {
                        return _UpdateUser();
                    }
            }
            return false;
        }
        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }
        public static bool DeletUser(int UserId)
        {
            return clsUserData.DeleteUser(UserId);
        }
        public static bool IsUseExists(int UserID)
        {
            return clsUserData.IsUserExist(UserID);
        }
        public static bool IsUseExistsByPersonID(int personID)
        {
            return clsUserData.IsUserExistByPersonID(personID);
        }
        public static bool IsUseExistsByUserName(string UserName)
        {
            return clsUserData.IsUserExistByUserName(UserName);
        }
    }
}
