using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using users;

namespace report
{
    public partial class Form1 : Form
    {
        List<BE.entities.User> list = new List<BE.entities.User>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserDAO usr = new UserDAO();
            list = usr.getUsers();
            bindingSource1.DataSource = list;
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            UserDAO usr = new UserDAO();
            list = usr.getUsers();
            bindingSource1.DataSource = list.Select(user => new User
            {
                userName = user.userName,
                cbu = user.cbu,
                cardnumber = user.cardnumber,
                lastName = user.lastName,
                mail = user.mail,
                celphone = user.celphone,
                dni = user.dni,
                id = user.id,
                password = user.password,
                saldo = user.saldo
            });
            this.reportViewer1.RefreshReport();
        }
    }
}