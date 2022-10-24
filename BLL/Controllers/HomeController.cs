using BE.DTO;
using System.Reflection.Metadata;
using DAL;
using Security;

namespace ByteCard.Controllers;
    public class HomeController 
    {
         Actions actions = new Actions();

        public bool Transaction(transactionDto request)
        {
            return actions.Transaction(request) ? true : false;  
        }
        
        public bool Deposit(DepositDto request)
        {
            return actions.Deposit(request) ? true : false;
        }
    }

