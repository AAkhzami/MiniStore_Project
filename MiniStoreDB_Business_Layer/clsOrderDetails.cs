using MiniStoreDB_DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
namespace MiniStoreDB_Business_Layer
{
    public class clsOrderDetails
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int? DetailID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal PricePerUnit { get; set; }

        public clsOrderDetails()
        {
            this.DetailID = 0;
            this.OrderID = 0;
            this.ProductID = 0;
            this.Quantity = 0;
            this.PricePerUnit = 0;
            Mode = enMode.AddNew;
        }
        private clsOrderDetails(int detailid, int orderid, int productid, int quantity, decimal priceperunit)
        {
            this.DetailID = detailid;
            this.OrderID = orderid;
            this.ProductID = productid;
            this.Quantity = quantity;
            this.PricePerUnit = priceperunit;
            Mode = enMode.Update;
        }

        public static clsOrderDetails Find(int DetailID)
        {
            int OrderID = 0;
            int ProductID = 0;
            int Quantity = 0;
            decimal PricePerUnit = 0;

            bool IsFound = clsOrderDetailsData.GetOrderDetailsInfoByID(DetailID, ref OrderID, ref ProductID, ref Quantity, ref PricePerUnit);
            if (IsFound)
            {
                return new clsOrderDetails(DetailID, OrderID, ProductID, Quantity, PricePerUnit);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewOrderDetails()
        {
            this.DetailID = clsOrderDetailsData.AddNewOrderDetails(this.OrderID, this.ProductID, this.Quantity, this.PricePerUnit);
            return (this.DetailID != null);
        }

        private bool _UpdateOrderDetails()
        {
            return clsOrderDetailsData.UpdateOrderDetailsInfoByID(this.DetailID ?? -1, this.OrderID, this.ProductID, this.Quantity, this.PricePerUnit);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewOrderDetails())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateOrderDetails();
            }
            return false;
        }

        public static bool DeleteOrderDetails(int DetailID)
        {
            return clsOrderDetailsData.DeleteOrderDetailsByID(DetailID);
        }

        public static async Task<DataTable> GetAllOrderDetails()
        {
            return await clsOrderDetailsData.GetAllOrderDetails();
        }
        public static async Task<DataTable> GetOrdersDetailForCustomer(int customerID)
        {
            return await clsOrderDetailsData.GetOrdersDetailForCustomer(customerID);
        }

    }
}
