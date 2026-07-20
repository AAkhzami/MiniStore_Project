using Microsoft.Win32;
using MiniStoreDB_Business_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MiniStore.Global
{
    internal class clsRegistry
    {
        static string _keyPath = @"HKEY_CURRENT_USER\SOFTWARE\MiniStore";

        public static bool WriteToRegistry(string userName, string password)
        {
            try
            {

                Registry.SetValue(_keyPath, "userName", userName, RegistryValueKind.String);
                Registry.SetValue(_keyPath, "password", password, RegistryValueKind.String);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public static bool _DeleteDataFromWRegisty()
        {
            try
            {
                using (RegistryKey BaseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey key = BaseKey.OpenSubKey(@"\SOFTWARE\MiniStore", true))
                    {
                        key.DeleteValue("userName");
                        key.DeleteValue("password");
                        return true;
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            { return false; }
            catch (Exception) { return false; }
        }
        public static bool LoadDataFromRegistry()
        {
            string userName = Registry.GetValue(_keyPath, "userName", null) as string;
            string password = Registry.GetValue(_keyPath, "password", null) as string;

            if (userName != null && password != null)
            {
                string HashingPassword = ComputeHash(password);
                clsUsers user = clsUsers.Find(clsUsers.IsValidUser(userName, HashingPassword));
                clsCurrentUser.CurrentUser = user;
                return true;
            }
            else
            {
                return false;
            }
        }
        static string ComputeHash(string input)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

    }
}
