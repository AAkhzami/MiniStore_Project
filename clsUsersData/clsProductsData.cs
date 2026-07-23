using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace MiniStoreDB_DataAccess_Layer
{
    public class clsProductsData

    {
        public static bool GetProductsInfoByID(int productid, ref string name, ref int categoryid, ref decimal price, ref int stockquantity, ref bool isactive, ref int createdbyuserid)
        {
            bool isFound = false;
            string query = @"select * from Products
                            where ProductID = @ProductID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductID", productid);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            if (reader["Name"] != DBNull.Value)
                                name = (string)reader["Name"];
                            else
                                name = null;
                            categoryid = (int)reader["CategoryID"];
                            price = (decimal)reader["Price"];
                            stockquantity = (int)reader["StockQuantity"];
                            isactive = (bool)reader["IsActive"];
                            if (reader["CreatedByUserID"] != DBNull.Value)
                                createdbyuserid = (int)reader["CreatedByUserID"];
                            else
                                createdbyuserid = 0;

                        }
                    }
                }
                catch (Exception ex)
                {
                    isFound = false;
                }
            }
            return isFound;
        }
        public static int? AddNewProducts(string name, int categoryid, decimal price, int stockquantity, bool isactive, int createdbyuserid)
        {
            int? recordId = null;
            string query = @"Insert into Products
                            (Name,CategoryID,Price,StockQuantity,IsActive,CreatedByUserID)
                            Values (@Name,@CategoryID,@Price,@StockQuantity,@IsActive,@CreatedByUserID)
                            select SCOPE_IDENTITY()";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@CategoryID", categoryid);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@StockQuantity", stockquantity);
                command.Parameters.AddWithValue("@IsActive", isactive);
                command.Parameters.AddWithValue("@CreatedByUserID", createdbyuserid);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int newID))
                    {
                        recordId = newID;
                    }
                }
                catch (Exception ex)
                {
                    recordId = null;
                }
            }
            return recordId;
        }
        public static bool UpdateProductsInfoByID(int productid, string name, int categoryid, decimal price, int stockquantity, bool isactive, int createdbyuserid)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Products
                            Set 
                            Name = @Name,
                            CategoryID = @CategoryID,
                            Price = @Price,
                            StockQuantity = @StockQuantity,
                            IsActive = @IsActive,
                            CreatedByUserID = @CreatedByUserID
                            where ProductID = @ProductID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductID", productid);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@CategoryID", categoryid);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@StockQuantity", stockquantity);
                command.Parameters.AddWithValue("@IsActive", isactive);
                command.Parameters.AddWithValue("@CreatedByUserID", createdbyuserid);

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return rowsAffected > 0;
        }
        public static bool DeleteProductsByID(int productid)
        {
            int rowsAffected = 0;
            string query = @"DELETE FROM Products where ProductID = @ProductID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductID", productid);

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return rowsAffected > 0;
        }
        public static DataTable GetAllProducts()
        {
            DataTable dt = new DataTable();
            string query = @"select * FROM v_ProductsInfo";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
            return dt;
        }
        public static async Task<DataTable> GetReportOfProducts()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT * FROM [dbo].[GetReportOfProducts] ()";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
            return dt;
        }
        public static async Task<DataTable> GetProductsInformationPerPage(int PageNumber, int ProductsPerPage)
        {
            DataTable dt = new DataTable();
            string query = @"SELECT * FROM [dbo].[ProductsPagination] (@PageNumber, @ProductsPerPage)";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PageNumber", PageNumber);
                command.Parameters.AddWithValue("@ProductsPerPage", ProductsPerPage);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
            return dt;
        }
        public static int GetLowStockProductsCount()
        {
            int count = 0;
            string query = @"SELECT [dbo].[GetLowStockProducts] ()";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    count = (int)command.ExecuteScalar();


                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
            return count;
        }
        public static async Task<DataTable> GetProductStockLogsByID(int ProductID)
        {
            DataTable dt = new DataTable();
            string query = @"SELECT * FROM [dbo].[GetProductStockLogs] (@ProductID)";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductID", ProductID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
            return dt;
        }
    }
}
