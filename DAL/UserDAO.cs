using BE.DTO;
using BE.entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UserDAO
    {
        ConectionDB connect = ConectionDB.Instance;

        public bool updateData(DataTable tb, int dni)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter($"select * from Users where dni = {dni}", connect.sqlConnection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.UpdateCommand = builder.GetUpdateCommand();
                adapter.Update(tb);
                return true;
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                return false;
            }
        }

        public DataTable GetUserIntable (int dni)
        {
            DataTable dt = new DataTable();
                try
                {
                    connect.OpenConnection();
                SqlCommand cmd = new SqlCommand($"select * from Users where dni = {dni}", connect.sqlConnection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    connect.CloseConnection();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return dt;
        }
        public User getUser(string mail) {
            User user = new User();
            try
            {
                SqlDataReader reader = null;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = $"SELECT * FROM users WHERE email = '{mail}'";
                sqlCmd.Connection = connect.sqlConnection;
                connect.OpenConnection();
                reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    user.id = Convert.ToInt32(reader.GetValue(0));
                    user.userName = reader.GetValue(1).ToString();
                    user.lastName = reader.GetValue(2).ToString();
                    user.mail = reader.GetValue(3).ToString();
                    user.password = reader.GetValue(4).ToString();
                    user.dni = Convert.ToInt32(reader.GetValue(5));
                    user.celphone = Convert.ToInt32(reader.GetValue(6));
                    user.cbu = Convert.ToInt32(reader.GetValue(7));
                    user.saldo = Convert.ToInt32(reader.GetValue(8));
                    user.cardnumber = Convert.ToInt32(reader.GetValue(9));
                }
                connect.CloseConnection();
                reader.Close();
                reader = null;
                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return user;
        }
        public User Login(string mail)
        {
            User user = new User();
            try
            {
                SqlDataReader reader = null;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = $"SELECT * FROM users WHERE email = '{mail}'";
                sqlCmd.Connection = connect.sqlConnection;
                connect.OpenConnection();
                reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    user.id = Convert.ToInt32(reader.GetValue(0));
                    user.userName= reader.GetValue(1).ToString();
                    user.lastName = reader.GetValue(2).ToString();
                    user.mail = reader.GetValue(3).ToString();
                    user.password= reader.GetValue(4).ToString();
                    user.dni = Convert.ToInt32(reader.GetValue(5));
                    user.celphone = Convert.ToInt32(reader.GetValue(6));
                    user.cbu = Convert.ToInt32(reader.GetValue(7));
                    user.saldo = Convert.ToInt32(reader.GetValue(8));
                    user.cardnumber = Convert.ToInt32(reader.GetValue(9));
                }
                connect.CloseConnection();
                reader.Close();
                reader = null;
                return user;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return user;
        }
        public bool Register(RegisterDto user,int cbu,int card) {
            try {
                connect.OpenConnection();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = $"insert into users(username,pass,lastname,email,cel,dni,saldo,cbu,cardnumber) values('{user.userName}','{user.password}','{user.lastName}','{user.mail}',{user.celphone},{user.dni},0,{cbu},{card})";
                sqlCmd.Connection = connect.sqlConnection;
                sqlCmd.ExecuteNonQuery();
                connect.CloseConnection();
                return true;
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return false; 
            }
        }
    }
}
