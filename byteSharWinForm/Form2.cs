using BE.DTO;
using BLL;
using ByteCard.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace byteSharWinForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AuthController actions = new AuthController();
            RegisterDto reg = new();
            reg.userName = rgName.Text;
            reg.lastName = rgLastName.Text;
            reg.mail = rgEmail.Text;
            reg.password = rgPassword.Text;
            reg.dni = Convert.ToInt32(rgDNI.Text);
            reg.celphone = Convert.ToInt32(rgCel.Text);
            bool log = actions.Register(reg);
            if (log)
            {
                MessageBox.Show("Usuario registrado con exito");
                Form1 newform = new Form1();
                newform.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al registrar usuario,ingrese otra contrasenia");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }
    }
}
