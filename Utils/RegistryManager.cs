using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Utils
{
    public class RegistryManager
    {
        const string userRoot = @"HKEY_CURRENT_USER";
        const string subkey = "byteshark";
        const string keyName = userRoot + "\\" + subkey;

        public static void SetRegistryUsername(string value)
        {
            RegistryKey key = Registry.CurrentUser;
            try
            {
                key.CreateSubKey("username");
                key.SetValue("username", value);

                key.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        public static string GetRegistryUsername()
        {
            RegistryKey key = Registry.CurrentUser;
            try
            {
                return key.GetValue("username").ToString();
            }
            catch
            {
                return null;
            }
        }
    }
}
