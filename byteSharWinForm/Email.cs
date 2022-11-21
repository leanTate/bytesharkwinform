using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace byteSharWinForm
{
    public partial class Email : TextBox
    {
        public Email()
        {
            InitializeComponent();
        }
        public bool isEmail()
        {
            string email = this.Text;
            string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";
            bool isEmailValid = Regex.IsMatch(email, emailPattern);
            return isEmailValid;
        }
    }
}
