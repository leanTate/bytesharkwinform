using BE.DTO;
using BLL;
using Lenguage;
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
        int index;
        public Form2(string lang, int indx)
        {
            InitializeComponent();
            emailL.Text = res.email;
            passL.Text = res.pasword;
            usrNameL.Text = res.usr;
            dniL.Text = res.dni;
            cellL.Text = res.cellphone;
            lstNameL.Text = res.lstName;
            guna2Button1.Text = res.register;
            this.Refresh();
            index = indx;
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
                MessageBox.Show(res.rok);
                Form1 newform = new Form1();
                newform.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(res.rnotok);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(index);
            this.Close();
            form1.Show();
        }
    }
}
