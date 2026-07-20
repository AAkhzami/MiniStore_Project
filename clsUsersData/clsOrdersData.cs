using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace MiniStoreDB_DataAccess_Layer
{
    public class clsOrdersData

    {
        public static bool GetOrdersInfoByID(int orderid, ref int customerid, ref DateTime orderdate, ref decimal totalamount, ref int createdbyuserid)
        {
            bool isFound = false;
            string query = @"select * from Orders
                            where OrderID = @OrderID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@OrderID", orderid);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            customerid = (int)reader["CustomerID"];
                            orderdate = (DateTime)reader["OrderDate"];
                            totalamount = (decimal)reader["TotalAmount"];
                            createdbyuserid = (int)reader["CreatedByUserID"];

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
        public static int? AddNewOrders(int customerid, DateTime orderdate, decimal totalamount, int createdbyuserid)
        {
            int? recordId = null;
            string query = @"Insert into Orders
                        (CustomerID,OrderDate,TotalAmount,CreatedByUserID)
                        Values (@CustomerID,@OrderDate,@TotalAmount,@CreatedByUserID)
                        select SCOPE_IDENTITY()";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", customerid);
                command.Parameters.AddWithValue("@OrderDate", orderdate);
                command.Parameters.AddWithValue("@TotalAmount", totalamount);
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
        public static bool UpdateOrdersInfoByID(int orderid, int customerid, DateTime orderdate, decimal totalamount, int createdbyuserid)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Orders
                            Set 
                            CustomerID = @CustomerID,
                            OrderDate = @OrderDate,
                            TotalAmount = @TotalAmount,
                            CreatedByUserID = @CreatedByUserID
                            OrderID = @OrderID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@OrderID", orderid);
                command.Parameters.AddWithValue("@CustomerID", customerid);
                command.Parameters.AddWithValue("@OrderDate", orderdate);
                command.Parameters.AddWithValue("@TotalAmount", totalamount);
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
        public static bool DeleteOrdersByID(int orderid)
        {
            int rowsAffected = 0;
            string query = @"DELETE FROM Orders where OrderID = @OrderID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@OrderID", orderid);

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
        public static async Task<DataTable> GetAllOrders()
        {
            DataTable dt = new DataTable();
            string query = @"select * FROM Orders";

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

        public static int GetTotalOrdersAtDate(DateTime date)
        {
            int Count = 0;
            string query = @"SP_GetTotalOrdersAtDate";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Date", date);
                SqlParameter outputIdParam = new SqlParameter("@TodayOrders", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputIdParam);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Count = (int)command.Parameters["@TodayOrders"].Value;
                }
                catch (Exception ex)
                {
                    Count = 0;
                }
            }
            return Count;
        }
        public static decimal GetTotalSalesAtDate(DateTime date)
        {
            decimal Sales = 0;
            string query = @"SP_GetTotalSalesAtDate";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Date", date);
                SqlParameter outputIdParam = new SqlParameter("@TodaySales", SqlDbType.Decimal)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputIdParam);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Sales = (decimal)command.Parameters["@TodaySales"].Value;
                }
                catch (Exception ex)
                {
                    Sales = 0;
                }
            }
            return Sales;
        }
        public static async Task<DataTable> GetBillInfo(int orderID)
        {
            DataTable dt = new DataTable();
            string query = @"select * from GetBillInfo (@OrderID);";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@OrderID", orderID);
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
