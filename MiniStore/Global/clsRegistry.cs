using Microsoft.Win32;
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

        public static bool WriteToRegistry(string userID, string password)
        {
            try
            {

                Registry.SetValue(_keyPath, "userID", userID, RegistryValueKind.String);
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
                    using (RegistryKey key = BaseKey.OpenSubKey(@"SOFTWARE\Code_Generator", true))
                    {
                        key.DeleteValue("userID");
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
            string userID = Registry.GetValue(_keyPath, "userID", null) as string;
            string password = Registry.GetValue(_keyPath, "password", null) as string;

            if (userID != null && password != null)
            {
                clsCurrentUser.CurrentUser.UserName = userID;
                clsCurrentUser.CurrentUser.Password = ComputeHash(password);
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
