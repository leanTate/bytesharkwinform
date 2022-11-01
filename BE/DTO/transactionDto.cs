using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.DTO
{
    public class transactionDto
    {
        public int cash { get; set; }
        public int amount { get; set; }
        public int destinatary { get; set; }
        public int origin { get; set; } 
    }
}