using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MiniStoreDB_DataAccess_Layer
{
    public class clsCustomersData

    {
        public static bool GetCustomersInfoByID(int customerid, ref string customername, ref string phonenumber, ref int createdbyuserid)
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
                            customerid = (int)reader["CustomerID"];
                            customername = (string)reader["CustomerName"];
                            phonenumber = (string)reader["PhoneNumber"];
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
        public static int? AddNewCustomers(string customername, string phonenumber, int createdbyuserid)
        {
            int? recordId = null;
            string query = @"Insert into Customers
                        (CustomerName,PhoneNumber,CreatedByUserID)
                        Values (@CustomerName,@PhoneNumber,@CreatedByUserID)
                        select SCOPE_IDENTITY()";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerName", customername);
                command.Parameters.AddWithValue("@PhoneNumber", phonenumber);
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
        public static bool UpdateCustomersInfoByID(int? customerid, string customername, string phonenumber, int createdbyuserid)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Customers
                            Set 
                            CustomerName = @CustomerName,
                            PhoneNumber = @PhoneNumber,
                            CreatedByUserID = @CreatedByUserID
                            CustomerID = @CustomerID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", customerid);
                command.Parameters.AddWithValue("@CustomerName", customername);
                command.Parameters.AddWithValue("@PhoneNumber", phonenumber);
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
            string query = @"select * FROM Customers";

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
    }
}
