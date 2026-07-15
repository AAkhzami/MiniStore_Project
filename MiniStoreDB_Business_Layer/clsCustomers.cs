using MiniStoreDB_DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace MiniStoreDB_Business_Layer
{
    public class clsCustomers
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int? CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public int CreatedByUserID { get; set; }

        public clsCustomers()
        {
            this.CustomerID = 0;
            this.CustomerName = null;
            this.PhoneNumber = null;
            this.CreatedByUserID = 0;
            Mode = enMode.AddNew;
        }
        private clsCustomers(int customerid, string customername, string phonenumber, int createdbyuserid)
        {
            this.CustomerID = customerid;
            this.CustomerName = customername;
            this.PhoneNumber = phonenumber;
            this.CreatedByUserID = createdbyuserid;
            Mode = enMode.Update;
        }

        public static clsCustomers Find(int CustomerID)
        {
            string CustomerName = null;
            string PhoneNumber = null;
            int CreatedByUserID = 0;

            bool IsFound = clsCustomersData.GetCustomersInfoByID(CustomerID, ref CustomerName, ref PhoneNumber, ref CreatedByUserID);
            if (IsFound)
            {
                return new clsCustomers(CustomerID, CustomerName, PhoneNumber, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewCustomers()
        {
            this.CustomerID = clsCustomersData.AddNewCustomers(this.CustomerName, this.PhoneNumber, this.CreatedByUserID);
            return (this.CustomerID != null);
        }

        private bool _UpdateCustomers()
        {
            return clsCustomersData.UpdateCustomersInfoByID(this.CustomerID ?? -1, this.CustomerName, this.PhoneNumber, this.CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCustomers())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateCustomers();
            }
            return false;
        }

        public static bool DeleteCustomers(int CustomerID)
        {
            return clsCustomersData.DeleteCustomersByID(CustomerID);
        }

        public static DataTable GetAllCustomers()
        {
            return clsCustomersData.GetAllCustomers();
        }
        
        public static int GetCustomersCount()
        {
            return clsCustomersData.GetCustomersCount();
        }
        public static bool IsPhoneNumberExist(string phonenumber)
        {
            return clsCustomersData.IsPhoneNumberExist(phonenumber);
        }
    }
}
