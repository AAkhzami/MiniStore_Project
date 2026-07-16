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
        public bool IsActive { get; set; }

        public clsCustomers()
        {
            this.CustomerID = 0;
            this.CustomerName = null;
            this.PhoneNumber = null;
            this.CreatedByUserID = 0;
            this.IsActive = true;
            Mode = enMode.AddNew;
        }
        private clsCustomers(int customerid, string customername, string phonenumber, int createdbyuserid, bool isActive)
        {
            this.CustomerID = customerid;
            this.CustomerName = customername;
            this.PhoneNumber = phonenumber;
            this.CreatedByUserID = createdbyuserid;
            this.IsActive = isActive;
            Mode = enMode.Update;
        }

        public static clsCustomers Find(int CustomerID)
        {
            string CustomerName = null;
            string PhoneNumber = null;
            int CreatedByUserID = 0;
            bool isActive = true;
            bool IsFound = clsCustomersData.GetCustomersInfoByID(CustomerID, ref CustomerName, ref PhoneNumber, ref CreatedByUserID, ref isActive);
            if (IsFound)
            {
                return new clsCustomers(CustomerID, CustomerName, PhoneNumber, CreatedByUserID, isActive);
            }
            else
            {
                return null;
            }
        }
        public static clsCustomers Find(string PhoneNumber)
        {
            int CustomerID = -1;
            string CustomerName = null;
            int CreatedByUserID = 0;
            bool isActive = true;
            bool IsFound = clsCustomersData.GetCustomersInfoByPhoneNumber(PhoneNumber,ref CustomerID, ref CustomerName, ref CreatedByUserID, ref isActive);
            if (IsFound)
            {
                return new clsCustomers(CustomerID, CustomerName, PhoneNumber, CreatedByUserID, isActive);
            }
            else
            {
                return null;
            }
        }
        private bool _AddNewCustomers()
        {
            this.CustomerID = clsCustomersData.AddNewCustomers(this.CustomerName, this.PhoneNumber, this.CreatedByUserID, this.IsActive);
            return (this.CustomerID != null);
        }

        private bool _UpdateCustomers()
        {
            return clsCustomersData.UpdateCustomersInfoByID(this.CustomerID ?? -1, this.CustomerName, this.PhoneNumber, this.IsActive);
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
        public static bool GetCustomerStatistics(int CustomerID, ref int OrderCount, ref decimal TotalSpent, ref int ProductsPurchased, ref int LastPurchase, ref DateTime LastPusrchaseDate)
        {
            if (clsCustomersData.GetCustomerStatistics(CustomerID, ref OrderCount, ref TotalSpent, ref ProductsPurchased, ref LastPurchase, ref LastPusrchaseDate))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
