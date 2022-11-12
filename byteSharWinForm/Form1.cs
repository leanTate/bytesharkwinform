using BLL;
using BLL.Controllers;
using BE.DTO;
using ByteCard.Controllers;
using System.Runtime.InteropServices;

namespace byteSharWinForm
{
    public partial class Form1 : Form
    {
        CamController camController;
        public Form1()
        {
            InitializeComponent();
            camController = new CamController(pictureBox3, pictureBox2,fileSystemWatcher1);
            passwordtxt.PasswordChar = '*';
            camController.LoadDispositives();
            camController.init();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (emailtxt.Text == "" || passwordtxt.Text == "")
            {
                MessageBox.Show("Complete los campos");
            }
            else {
                AuthController auth = new AuthController();
                LoginDto log = new LoginDto();
                log.mail = emailtxt.Text;
                log.password = passwordtxt.Text;
                camController.TakePhoto(log);
                UserDto myusr = auth.Login(log);
                if (myusr != null)
                {
                    Loader loaderFrm = new Loader(myusr);
                    loaderFrm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2();
            newform.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            camController.CloseCam();
        }

        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            camController.GetFiles();
        }
    }
}