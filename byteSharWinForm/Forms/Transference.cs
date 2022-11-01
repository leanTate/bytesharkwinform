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
    public partial class Transference : Form
    {
        User user = new User();
        public Transference(User userd)
        {
            InitializeComponent();
            user = userd;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            transactionDto transaction = new();
            transaction.cash = user.saldo;
            transaction.destinatary = Convert.ToInt32(destinatary.Text);
            transaction.origin = user.cbu;
            transaction.amount = Convert.ToInt32(amount.Text);
            HomeController actions = new();
            bool log = actions.Transaction(transaction);
            MessageBox.Show(log.ToString());
        }
    }
}
