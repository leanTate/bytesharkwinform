using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace byteSharWinForm
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PBStart.Value++;
            if (PBStart.Value == 99)
            {
                timer1.Stop();
                Dashboard dashboardFrm = new Dashboard();
                dashboardFrm.Show();
                this.Hide();

            }
        }

        private void Loader_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panelLoader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Mover Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    }
}
