using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.DTO
{
    public class DepositDto
    {
        public int origin = 010;
        public int amount { get; set; }
        public string destinatary { get; set; } = string.Empty;
    }
}
