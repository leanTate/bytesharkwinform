using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.entities
{
    public class User
    {
        public int id { get; set; }
        public string userName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public string mail { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public int dni { get; set; }
        public int celphone { get; set; }
        public int saldo { get; set; }
        public int cbu { get; set; }
        public int cardnumber { get; set; }

    }
}
