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
        public string destinatary { get; set; } = string.Empty;
        public string origin { get; set; } = string.Empty;
        public string token { get; set; } = string.Empty;
    }
}