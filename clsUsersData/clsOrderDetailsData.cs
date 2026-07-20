using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace MiniStoreDB_DataAccess_Layer
{
    public class clsOrderDetailsData

    {
        public static bool GetOrderDetailsInfoByID(int detailid, ref int orderid, ref int productid, ref int quantity, ref decimal priceperunit)
        {
            bool isFound = false;
            string query = @"select * from OrderDetails
                            where DetailID = @DetailID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DetailID", detailid);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            orderid = (int)reader["OrderID"];
                            productid = (int)reader["ProductID"];
                            if (reader["Quantity"] != DBNull.Value)
                                quantity = (int)reader["Quantity"];
                            else
                                quantity = 0;
                            if (reader["PricePerUnit"] != DBNull.Value)
                                priceperunit = (decimal)reader["PricePerUnit"];
                            else
                                priceperunit = 0;

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
        public static int? AddNewOrderDetails(int orderid, int productid, int quantity, decimal priceperunit)
        {
            int? recordId = null;
            string query = @"Insert into OrderDetails
                                (OrderID,ProductID,Quantity,PricePerUnit)
                                Values (@OrderID,@ProductID,@Quantity,@PricePerUnit)
                                select SCOPE_IDENTITY()";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@OrderID", orderid);
                command.Parameters.AddWithValue("@ProductID", productid);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@PricePerUnit", priceperunit);

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
        public static bool UpdateOrderDetailsInfoByID(int detailid, int orderid, int productid, int? quantity, decimal priceperunit)
        {
            int rowsAffected = 0;
            string query = @"UPDATE OrderDetails
                            Set 
                            OrderID = @OrderID,
                            ProductID = @ProductID,
                            Quantity = @Quantity,
                            PricePerUnit = @PricePerUnit
                            DetailID = @DetailID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DetailID", detailid);
                command.Parameters.AddWithValue("@OrderID", orderid);
                command.Parameters.AddWithValue("@ProductID", productid);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@PricePerUnit", priceperunit);

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
        public static bool DeleteOrderDetailsByID(int detailid)
        {
            int rowsAffected = 0;
            string query = @"DELETE FROM OrderDetails where DetailID = @DetailID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DetailID", detailid);

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
        public static async Task<DataTable> GetAllOrderDetails()
        {
            DataTable dt = new DataTable();
            string query = @"select * FROM OrderDetails";

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
        public static async Task<DataTable> GetOrdersDetailForCustomer(int customerID)
        {
            DataTable dt = new DataTable();
            string query = @"SELECT * FROM [dbo].[GetOrdersDetailForCustomer] (@CustomerID)";


            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", customerID);

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
