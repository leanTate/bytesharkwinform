using BE.entities;
using BE.DTO;
using ByteCard.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace byteSharWinForm.Forms
{
    public partial class Balance : Form
    {
        User usr;
        public Balance(User user)
        {
            InitializeComponent();
            HomeController actions = new();
            usr = actions.GetData(user.mail);
            lblUserCard.Text = $"{usr.userName} {user.lastName}";
            lblSaldo.Text = $"{usr.saldo}$";
            lblCardNumber.Text = $"{user.cardnumber}";
            labelCBU.Text = $"CBU:{user.cbu}";
            dgvtransferences.DataSource = null;
            dgvtransferences.DataSource=actions.GetTransferences(usr.cbu,user.dni);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = actions.GetTransferencesForMe(usr.cbu, user.dni);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = actions.GetDeposits(usr.cbu);
        }
    }
}
