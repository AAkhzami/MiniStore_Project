using MiniStoreDB_DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStoreDB_Business_Layer
{
    public class clsUsers
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int? UserID { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }

        public clsUsers()
        {
            this.UserID = 0;
            this.UserName = null;
            this.FullName = null;
            this.Password = null;
            this.CreatedAt = DateTime.Now;
            this.IsActive = false;
            Mode = enMode.AddNew;
        }
        private clsUsers(int userid, string username, string fullName, string password, DateTime createdat, bool isactive)
        {
            this.UserID = userid;
            this.UserName = username;
            this.FullName = fullName;
            this.Password = password;
            this.CreatedAt = createdat;
            this.IsActive = isactive;
            Mode = enMode.Update;
        }

        public static clsUsers Find(int UserID)
        {
            string UserName = null, fullName = null, Password = null;
            DateTime CreatedAt = DateTime.Now;
            bool IsActive = false;

            bool IsFound = clsUsersData.GetUsersInfoByID(UserID, ref UserName,ref fullName, ref Password, ref CreatedAt, ref IsActive);
            if (IsFound)
            {
                return new clsUsers(UserID, UserName, fullName, Password, CreatedAt, IsActive);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewUsers()
        {
            this.UserID = clsUsersData.AddNewUsers(this.UserName, this.FullName, this.Password, this.IsActive);
            return (this.UserID != null);
        }

        private bool _UpdateUsers()
        {
            return clsUsersData.UpdateUsersInfoByID(this.UserID ?? -1, this.UserName, this.FullName, this.Password, this.CreatedAt, this.IsActive);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUsers())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateUsers();
            }
            return false;
        }

        public static bool DeleteUsers(int UserID)
        {
            return clsUsersData.DeleteUsersByID(UserID);
        }

        public static async Task<DataTable> GetAllUsers()
        {
            return await clsUsersData.GetAllUsers();
        }

        public static int IsValidUser(string username, string password)
        { 
            return clsUsersData.IsValidUser(username, password);
        }
        public static bool IsUserNameExist(string username)
        {
            return clsUsersData.IsUserNameExist(username);
        }
    }
}
