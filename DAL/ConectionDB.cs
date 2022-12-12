using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using BE;
using System.IO;
using System.Xml;
using System.Diagnostics;
using System.Data.SqlTypes;

namespace DAL
{
    internal sealed class ConectionDB
    {
        private static ConectionDB _instance = null;
        public SqlConnection sqlConnection;
        private ConectionDB()
        {
            string file = AppContext.BaseDirectory + "XMLFile1.xml";
            StreamReader readeri = new StreamReader(file);
            XmlTextReader reader = new XmlTextReader(readeri);
            while(reader.Read()) {
                if (reader.Value != "") {
                    sqlConnection = new SqlConnection(reader.Value.ToString());
                }
            }
        }
        public static ConectionDB Instance
        {
            get
            {
                if (_instance == null) _instance = new ConectionDB();

                return _instance;
            }
        }
        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
    }
}
