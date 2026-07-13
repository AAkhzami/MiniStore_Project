using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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
                            orderid = (int)reader["OrderID"];
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
        public static DataTable GetAllOrders()
        {
            DataTable dt = new DataTable();
            string query = @"select * FROM Orders";

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
        public static void GetOrdersInformationAtDate(DateTime date, ref int totalOrders, ref decimal totalAmount)
        {
            string query = @"SP_AddNewUser";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@OrderDate", date.Date);
                SqlParameter totalOrdersParam = new SqlParameter("@TotalOrders", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                SqlParameter totalAmountParam = new SqlParameter("@TotalAmount", SqlDbType.Decimal)
                {
                    Direction = ParameterDirection.Output,
                    Precision = 10,
                    Scale = 2
                };
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    totalOrders = (int)(totalOrdersParam.Value ?? 0);
                    totalAmount = (decimal)(totalAmountParam.Value ?? 0);
                }
                catch (Exception ex)
                {
                    totalOrders = 0;
                    totalAmount = 0;
                }
            }
        }
    }
}
