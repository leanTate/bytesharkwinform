using System;
using System.Collections.Generic;
using System.ComponentModel;
using BLL;
using ByteCard;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ByteCard.Controllers;
using BE.DTO;
using BE.entities;

namespace byteSharWinForm.Forms
{
    public partial class Deposit : Form
    {
        User user = new User();
        public Deposit(User userp)
        {
            InitializeComponent();
            user = userp;
        }


        private void LoginBtn_Click_1(object sender, EventArgs e)
        {
            DepositDto deposit = new();
            deposit.destinatary = user.cbu;
            deposit.origin = user.cbu;
            deposit.amount = Convert.ToInt32(amount.Text);
            HomeController actions = new();
            bool log = actions.Deposit(deposit);
            MessageBox.Show(log ? "el depocito se realizo correctamente" : "el depocito no se realizo correctamente");

        }
    }
}
