using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using BE.entities;
using BE.DTO;
using System.Runtime.InteropServices;

namespace DAL
{
    public class Actions
    {
        public DataTable Deposits(int cbu)
        {
            try
            {
                ConectionDB connect = ConectionDB.Instance;
                connect.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter($"select operation,amount,(select username from users where cbu={cbu}) as receptor from Deposits as D inner join users as u on receptor=cbu where receptor={cbu};", connect.sqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public DataTable transferencesForMe(int cbu, int dni)
        {
            try
            {
                ConectionDB connect = ConectionDB.Instance;
                connect.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter($"select receptor=(select username from users where dni={dni}),valor,username as emisor from transactions as t inner join users as u on cbu_emisor=cbu where cbu_receptor={cbu};", connect.sqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public DataTable transferences(int cbu,int dni)
        {
            try
            {
                ConectionDB connect = ConectionDB.Instance;
                connect.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter($"select emisor=(select username from users where dni={dni}),valor,username as receptor from transactions as t inner join users as u on cbu_receptor=cbu where cbu_emisor={cbu};",connect.sqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public bool Transaction(transactionDto req) {
            try {
                ConectionDB connect = ConectionDB.Instance;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = $"UPDATE users set saldo+={req.amount} where cbu={req.destinatary}";
                sqlCmd.Connection = connect.sqlConnection;
                connect.OpenConnection();
                sqlCmd.ExecuteNonQuery();
                sqlCmd.CommandText = $"UPDATE users set saldo-={req.amount} where cbu={req.origin}";
                sqlCmd.ExecuteNonQuery();
                connect.CloseConnection();
                TransactionLogs(req);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        internal bool TransactionLogs(transactionDto req){ 
            try
            {
                ConectionDB connect = ConectionDB.Instance;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = $"insert into transactions(cbu_emisor,valor,cbu_receptor) values('{req.origin}',{req.amount},'{req.destinatary}')";
                sqlCmd.Connection = connect.sqlConnection;
                connect.OpenConnection();
                sqlCmd.ExecuteNonQuery();
                connect.CloseConnection();

                return true;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        internal bool DepositLogs(DepositDto req)
        {
            try
            {
                ConectionDB connect = ConectionDB.Instance;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = $"insert into Deposits(operation,amount,receptor) values('Deposito',{req.amount},'{req.destinatary}')";
                sqlCmd.Connection = connect.sqlConnection;
                connect.OpenConnection();
                sqlCmd.ExecuteNonQuery();
                connect.CloseConnection();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool Deposit(DepositDto req) {
            try
            {
                ConectionDB connect = ConectionDB.Instance;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = $"Deposit";
                sqlCmd.Parameters.AddWithValue("@amount", req.amount);
                sqlCmd.Parameters.AddWithValue("@cbu", req.destinatary);
                sqlCmd.Connection = connect.sqlConnection;
                connect.OpenConnection();
                sqlCmd.ExecuteNonQuery();
                connect.CloseConnection();
                DepositLogs(req);
                return true;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public UserDto GetData(string mail)
        {
            UserDto user = new UserDto();
            try
            {
                ConectionDB connect = ConectionDB.Instance;
                SqlDataReader reader = null;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = $"SELECT* FROM users WHERE email = '{mail}'";
                sqlCmd.Connection = connect.sqlConnection;
                connect.OpenConnection();
                reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    user.userName = reader.GetValue(1).ToString();
                    user.lastName = reader.GetValue(2).ToString();
                    user.mail = reader.GetValue(3).ToString();
                    user.dni = Convert.ToInt32(reader.GetValue(5));
                    user.celphone = Convert.ToInt32(reader.GetValue(6));
                    user.cbu = Convert.ToInt32(reader.GetValue(7));
                    user.saldo = Convert.ToInt32(reader.GetValue(8));
                }
                connect.CloseConnection();
                reader = null;
                reader.Close();
                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return user;
        }
    }
}
