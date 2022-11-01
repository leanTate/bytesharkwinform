using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Validator
    {
        public bool ValidateCBU(string cbu)
        {
            ConectionDB connect = ConectionDB.Instance;
                string newcbu="";
            try
            {
                SqlDataReader reader = null;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = $"SELECT cbu FROM users WHERE cbu = '{cbu}'";
                sqlCmd.Connection = connect.sqlConnection;
                connect.OpenConnection();
                reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    newcbu = reader.GetValue(0).ToString();
                }
                connect.CloseConnection();
                if (newcbu != "")
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
