using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStoreDB_DataAccess_Layer
{
    public class clsUsersData
    {
        public static bool GetUsersInfoByID(int userid, ref string username, ref string fullName, ref string password, ref DateTime createdat, ref bool isactive)
        {
            bool isFound = false;
            string query = @"select * from Users
                            where UserID = @UserID and IsDeleted = 0";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userid);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            username = (string)reader["UserName"];
                            fullName = (string)reader["FullName"];
                            password = (string)reader["Password"];

                            if (reader["CreatedAt"] != DBNull.Value)
                                createdat = (DateTime)reader["CreatedAt"];
                            else
                                createdat = DateTime.Now;
                            isactive = (bool)reader["IsActive"];

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
        public static int? AddNewUsers(string username, string fullName, string password, bool isactive)
        {
            int? recordId = null;
            string query = @"SP_AddNewUser";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserName", username);
                command.Parameters.AddWithValue("@FullName", fullName);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@IsActive", isactive);
                SqlParameter outputIdParam = new SqlParameter("@NewUserID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputIdParam);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    recordId = command.Parameters["@NewUserID"].Value as int?;
                }
                catch (Exception ex)
                {
                    recordId = null;
                }
            }
            return recordId;
        }
        public static bool UpdateUsersInfoByID(int userid, string username, string fullName, string password, DateTime createdat, bool isactive)
        {
            int rowsAffected = 0;
            string query = "SP_UpdateUser";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", userid);
                command.Parameters.AddWithValue("@UserName", username);
                command.Parameters.AddWithValue("@FullName", fullName);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@IsActive", isactive);

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
        public static bool DeleteUsersByID(int userid)
        {
            int rowsAffected = 0;
            string query = @"DELETE FROM Users where UserID = @UserID and IsDeleted = 0;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userid);

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
        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            string query = @"select * FROM Users where IsDeleted = 0;";

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
        public static int IsValidUser(string username, string password)
        {
            int? userID = null;
            string query = @"select UserID from Users where UserName = @UserName and Password = @Password and IsDeleted = 0";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", username);
                command.Parameters.AddWithValue("@Password", password);
                try
                {
                    connection.Open();
                    userID = (int?)command.ExecuteScalar();

                }
                catch (Exception ex)
                {
                    userID = null;
                }
            }
            return userID ?? -1;
        }
        public static bool IsUserNameExist(string username)
        {
            bool exist = false;
            string query = @"select 1 from Users where UserName = @UserName";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", username);

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

    }
}
