using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Reflection.Metadata;

namespace DAL
{
    public class Validator
    {
        public bool validateToken(string mail){
            string response = "";
            try { 
                ConectionDB connect = ConectionDB.Instance;
                SqlDataReader reader = null;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = $"SELECT * FROM users WHERE email = '{mail}'";
                sqlCmd.Connection = connect.sqlConnection;
                connect.OpenConnection();
                reader = sqlCmd.ExecuteReader();
                while (reader.Read()) { 
                    response = reader.GetValue(3).ToString();
                }
                connect.CloseConnection();
                return response != "" ? true : false;
            }
            catch(Exception ex) {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
