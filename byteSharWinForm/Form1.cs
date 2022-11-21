using BLL;
using BLL.Controllers;
using BE.DTO;
using ByteCard.Controllers;
using System.Runtime.InteropServices;
using Lenguage;
using Utils;

namespace byteSharWinForm
{
    public partial class Form1 : Form
    {
        CamController camController;
        EventLogger logger = new EventLogger();


        public Form1()
        {
            InitializeComponent();
            camController = new CamController(pictureBox3, pictureBox2, fileSystemWatcher1);
            passwordtxt.PasswordChar = '*';
            camController.LoadDispositives();
            SelectLanguage.SelectedIndex = 0;
        }
        public Form1(int l)
        {
            InitializeComponent();
            camController = new CamController(pictureBox3, pictureBox2, fileSystemWatcher1);
            passwordtxt.PasswordChar = '*';
            camController.LoadDispositives();
            SelectLanguage.SelectedIndex = l;
        }

        private void getLanguage() {
            languageController languageController = new();
            languageController.ChangeLanguage(SelectLanguage.SelectedItem.ToString());
            label1.Text = res.email;
            label2.Text = res.pasword;
            LoginBtn.Text = res.signin;
            guna2Button1.Text = res.register;
            this.Refresh();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            
            if (emailtxt.Text == "" || emailtxt.isEmail() == false || passwordtxt.Text == "")
            {
                MessageBox.Show(res.log1);
                logger.Log(res.log1);
            }
            else {
                AuthController auth = new AuthController();
                LoginDto log = new LoginDto();
                log.mail = emailtxt.Text;
                log.password = passwordtxt.Text;
                camController.TakePhoto(log);
                camController.CloseCam();
                UserDto myusr = auth.Login(log);
                RegistryManager.SetRegistryUsername(myusr.userName);
                logger.Log($"{log.mail} {DateTime.Now.ToString("hh.mm")} {DateTime.Now.ToLongDateString()}");
                if (myusr != null)
                {
                    Loader loaderFrm = new Loader(myusr);
                    loaderFrm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(res.log2);
                    logger.Log(res.log2);
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
            camController.CloseCam();
            Form2 newform = new Form2(SelectLanguage.SelectedItem.ToString(), SelectLanguage.SelectedIndex);
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

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getLanguage();
        }
    }
}