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
using Lenguage;
using Utils;

namespace byteSharWinForm.Forms
{
    public partial class Transference : Form
    {
        User user = new User();
        EventLogger logger = new EventLogger();
        public Transference(User userd)
        {
            HomeController actions = new();
            InitializeComponent();
            user = actions.GetData(userd.mail);
            amountL.Text = res.amount;
            TransferBtn.Text = res.transfer;
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

            logger.Log($"{user.userName} realizo una transferencia de ${transaction.amount} al CBU {transaction.destinatary}");
            MessageBox.Show(log ? res.tbok : res.tbnotok);
        }
    }
}
