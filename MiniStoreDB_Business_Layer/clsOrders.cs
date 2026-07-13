using MiniStoreDB_DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace MiniStoreDB_Business_Layer
{
    public class clsOrders
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int? OrderID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int CreatedByUserID { get; set; }

        public clsOrders()
        {
            this.OrderID = 0;
            this.CustomerID = 0;
            this.OrderDate = DateTime.Now;
            this.TotalAmount = 0;
            this.CreatedByUserID = 0;
            Mode = enMode.AddNew;
        }
        private clsOrders(int orderid, int customerid, DateTime orderdate, decimal totalamount, int createdbyuserid)
        {
            this.OrderID = orderid;
            this.CustomerID = customerid;
            this.OrderDate = orderdate;
            this.TotalAmount = totalamount;
            this.CreatedByUserID = createdbyuserid;
            Mode = enMode.Update;
        }

        public static clsOrders Find(int OrderID)
        {
            int CustomerID = 0;
            DateTime OrderDate = DateTime.Now;
            decimal TotalAmount = 0;
            int CreatedByUserID = 0;

            bool IsFound = clsOrdersData.GetOrdersInfoByID(OrderID, ref CustomerID, ref OrderDate, ref TotalAmount, ref CreatedByUserID);
            if (IsFound)
            {
                return new clsOrders(OrderID, CustomerID, OrderDate, TotalAmount, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewOrders()
        {
            this.OrderID = clsOrdersData.AddNewOrders(this.CustomerID, this.OrderDate, this.TotalAmount, this.CreatedByUserID);
            return (this.OrderID != null);
        }

        private bool _UpdateOrders()
        {
            return clsOrdersData.UpdateOrdersInfoByID(this.OrderID ?? -1, this.CustomerID, this.OrderDate, this.TotalAmount, this.CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewOrders())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateOrders();
            }
            return false;
        }

        public static bool DeleteOrders(int OrderID)
        {
            return clsOrdersData.DeleteOrdersByID(OrderID);
        }

        public static DataTable GetAllOrders()
        {
            return clsOrdersData.GetAllOrders();
        }
        public static void GetOrdersInformationAtDate(DateTime date, ref int totalOrders, ref decimal totalAmount)
        {
            clsOrdersData.GetOrdersInformationAtDate(date, ref totalOrders, ref totalAmount);
        }

    }
}
