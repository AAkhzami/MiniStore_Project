using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MiniStoreDB_DataAccess_Layer
{
    public class clsCustomersData

    {
        public static bool GetCustomersInfoByID(int customerid, ref string customername, ref string phonenumber, ref int createdbyuserid, ref bool isActive)
        {
            bool isFound = false;
            string query = @"select * from Customers
            where CustomerID = @CustomerID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", customerid);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            customername = (string)reader["CustomerName"];
                            phonenumber = (string)reader["PhoneNumber"];
                            createdbyuserid = (int)reader["CreatedByUserID"];
                            isActive = (bool)reader["IsActive"];
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
        public static bool GetCustomersInfoByPhoneNumber(string phonenumber, ref int customerid, ref string customername, ref int createdbyuserid, ref bool isActive)
        {
            bool isFound = false;
            string query = @"select * from Customers
            where PhoneNumber = @PhoneNumber";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PhoneNumber", phonenumber);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            customerid = (int)reader["CustomerID"];
                            customername = (string)reader["CustomerName"];
                            createdbyuserid = (int)reader["CreatedByUserID"];
                            isActive = (bool)reader["IsActive"];

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

        public static int? AddNewCustomers(string customername, string phonenumber, int createdbyuserid, bool isActive)
        {
            int? recordId = null;
            string query = @"Insert into Customers
                        (CustomerName,PhoneNumber,CreatedByUserID, IsActive)
                        Values (@CustomerName,@PhoneNumber,@CreatedByUserID,@IsActive)
                        select SCOPE_IDENTITY()";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerName", customername);
                command.Parameters.AddWithValue("@PhoneNumber", phonenumber);
                command.Parameters.AddWithValue("@CreatedByUserID", createdbyuserid);
                command.Parameters.AddWithValue("@IsActive", isActive);

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
        public static bool UpdateCustomersInfoByID(int? customerid, string customername, string phonenumber, bool isActive)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Customers
                            Set 
                            CustomerName = @CustomerName,
                            PhoneNumber = @PhoneNumber,
                            IsActive = @IsActive
                            where CustomerID = @CustomerID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", customerid);
                command.Parameters.AddWithValue("@CustomerName", customername);
                command.Parameters.AddWithValue("@PhoneNumber", phonenumber);
                command.Parameters.AddWithValue("@IsActive", isActive);

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
        public static bool DeleteCustomersByID(int customerid)
        {
            int rowsAffected = 0;
            string query = @"DELETE FROM Customers where CustomerID = @CustomerID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", customerid);

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
        public static DataTable GetAllCustomers()
        {
            DataTable dt = new DataTable();
            string query = @"select * FROM Customers where IsActive = 1";

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
        public static int GetCustomersCount()
        {
            int rowsAffected = 0;
            string query = @"select count(*) as Counter from Customers";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    rowsAffected = (int)command.ExecuteScalar();


                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
            return rowsAffected;
        }
        public static bool IsPhoneNumberExist(string phonenumber)
        {
            bool exist = false;
            string query = @"select 1 from Customers where PhoneNumber = @PhoneNumber and IsActive = 1";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PhoneNumber", phonenumber);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    exist = reader.HasRows;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return exist;
        }
        public static bool GetCustomerStatistics(int CustomerID, ref int OrderCount, ref decimal TotalSpent, ref int ProductsPurchased, ref int LastPurchase, ref DateTime LastPusrchaseDate)
        {
            bool isFound = false;
            string query = @"SELECT * FROM [dbo].[GetCustomerStatistics] (@CustomerID)";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", CustomerID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            if (reader["OrdersCount"] != System.DBNull.Value)
                                OrderCount = (int)reader["OrdersCount"];
                            else
                                OrderCount = 0;

                            if(reader["TotalSpent"] != System.DBNull.Value)
                                TotalSpent = (decimal)reader["TotalSpent"];
                            else
                                TotalSpent = 0;

                            if(reader["ProductsPurchased"] != System.DBNull.Value)
                                ProductsPurchased = (int)reader["ProductsPurchased"];
                            else
                                ProductsPurchased= 0;

                            if (reader["LastPurchase"] != System.DBNull.Value)
                                LastPurchase = (int)reader["LastPurchase"];
                            else
                                LastPurchase = 0;

                            if (reader["LastPurchaseDate"] != System.DBNull.Value)
                                LastPusrchaseDate = (DateTime)reader["LastPusrchaseDate"];
                            else
                                LastPusrchaseDate = DateTime.Now;
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
    }
}
