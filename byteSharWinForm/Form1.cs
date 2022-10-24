using BLL;
using BE.DTO;
using ByteCard.Controllers;
using System.Runtime.InteropServices;

namespace byteSharWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            AuthController auth = new AuthController();
            LoginDto log = new LoginDto();
            log.mail = emailtxt.Text;
            log.password = passwordtxt.Text;
            UserDto user= new UserDto(); 
            bool myusr=auth.Login(log);
            /* if(myusr)
            {
            Loader loaderFrm = new Loader();
            loaderFrm.Show();
            this.Hide();
            }*/

            Loader loaderFrm = new Loader();
            loaderFrm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            emailtxt.Focus();

        }

        private void emailtxt_TextChanged(object sender, EventArgs e)
        {

        }

        //Mover Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}