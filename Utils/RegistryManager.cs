using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            RegistryKey key = Registry.CurrentUser.OpenSubKey(subkey, true);

            key.CreateSubKey("username");
            key.SetValue("username", value);

            key.Close();

        }
        public static string GetRegistryUsername()
        {
            return Registry.GetValue(keyName, "username", "no hay nada aca").ToString();
        }
    }
}
