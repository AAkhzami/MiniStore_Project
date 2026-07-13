using MiniStoreDB_DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace MiniStoreDB_Business_Layer
{
    public class clsProducts
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int? ProductID { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public clsProducts()
        {
            this.ProductID = 0;
            this.Name = "";
            this.CategoryID = 0;
            this.Price = 0;
            this.StockQuantity = 0;
            this.IsActive = false;
            this.CreatedByUserID = 0;
            Mode = enMode.AddNew;
        }
        private clsProducts(int productid, string name, int categoryid, decimal price, int stockquantity, bool isactive, int createdbyuserid)
        {
            this.ProductID = productid;
            this.Name = name;
            this.CategoryID = categoryid;
            this.Price = price;
            this.StockQuantity = stockquantity;
            this.IsActive = isactive;
            this.CreatedByUserID = createdbyuserid;
            Mode = enMode.Update;
        }

        public static clsProducts Find(int ProductID)
        {
            string Name = null;
            int CategoryID = 0;
            decimal Price = 0;
            int StockQuantity = 0;
            bool IsActive = false;
            int CreatedByUserID = 0;

            bool IsFound = clsProductsData.GetProductsInfoByID(ProductID, ref Name, ref CategoryID, ref Price, ref StockQuantity, ref IsActive, ref CreatedByUserID);
            if (IsFound)
            {
                return new clsProducts(ProductID, Name, CategoryID, Price, StockQuantity, IsActive, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewProducts()
        {
            this.ProductID = clsProductsData.AddNewProducts(this.Name, this.CategoryID, this.Price, this.StockQuantity, this.IsActive, this.CreatedByUserID);
            return (this.ProductID != null);
        }

        private bool _UpdateProducts()
        {
            return clsProductsData.UpdateProductsInfoByID(this.ProductID ?? -1, this.Name, this.CategoryID, this.Price, this.StockQuantity, this.IsActive, this.CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewProducts())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateProducts();
            }
            return false;
        }

        public static bool DeleteProducts(int ProductID)
        {
            return clsProductsData.DeleteProductsByID(ProductID);
        }

        public static DataTable GetAllProducts()
        {
            return clsProductsData.GetAllProducts();
        }
        public static int GetLowStockProductsCount()
        {
            return clsProductsData.GetLowStockProductsCount();
        }
        public static async Task<DataTable> GetReportOfProducts()
        {
            return await clsProductsData.GetReportOfProducts();
        }
        public static async Task<DataTable> GetProductsInformationPerPage(int pageNumber, int pageSize)
        {
            return await clsProductsData.GetProductsInformationPerPage(pageNumber, pageSize);
        }
    }
}
