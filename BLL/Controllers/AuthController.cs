using BE;
using BE.DTO;
using BE.entities;
using DAL;
using Security;

namespace ByteCard.Controllers
{
    public class AuthController
    {
        public bool Register(RegisterDto usr)
        {
            string hashpass = HashService.hashPass(usr.password);
            UserDAO userDAO = new UserDAO();
            usr.password = hashpass;
            int cbu = new Random().Next(100000000, 999999999);
            return userDAO.Register(usr,cbu) ? true : false;
        }

        public bool Login(LoginDto request)
        {
            string hashpass = HashService.hashPass(request.password);
            UserDAO userDAO = new UserDAO();
            User SQLresponse = userDAO.Login(request.mail);
            UserDto user = new UserDto();
            user.mail = SQLresponse.mail;
            user.userName = SQLresponse.userName;
            user.lastName = SQLresponse.lastName;
            user.celphone = SQLresponse.celphone;
            user.dni = SQLresponse.dni;
            user.saldo = SQLresponse.saldo;
            user.cbu = SQLresponse.cbu;
            bool log = SQLresponse.mail == request.mail && SQLresponse.password == hashpass ? true : false;
            MessageBox.Show(log.ToString());
            return log ? true : false; 
        }
    }
}
