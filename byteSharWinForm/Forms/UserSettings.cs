using BE.entities;
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
using Lenguage;

namespace byteSharWinForm.Forms
{
    public partial class UserSettings : Form
    {
        DataTable usertable;
        User usr;
        public UserSettings(User user)
        {
            HomeController actions = new();
            InitializeComponent();
            nameL.Text = res.usr;
            lastnameL.Text = res.lstName;
            cellL.Text = res.cellphone;
            mailL.Text = res.email;
            SaveBtn.Text = res.save;
            applybtn.Text = res.apply;
            usr = user;
            usertable = actions.getUserinTable(user.dni);
            nametxt.Text = usertable.Rows[0][1].ToString();
            textBox1.Text = usertable.Rows[0][2].ToString();
            textBox2.Text = usertable.Rows[0][6].ToString();
            textBox3.Text = usertable.Rows[0][3].ToString();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            usertable.Rows[0][1] = nametxt.Text;
            usertable.Rows[0][2] = textBox1.Text;
            usertable.Rows[0][6] = textBox2.Text;
            usertable.Rows[0][3] = textBox3.Text;
            MessageBox.Show(res.saveone);
            applybtn.Enabled = true;
        }

        private void applybtn_Click(object sender, EventArgs e)
        {
            HomeController actions = new();
            actions.updateData(usertable, usr.dni);
            MessageBox.Show(res.savetwo);
            applybtn.Enabled = false;
        }
    }
}
