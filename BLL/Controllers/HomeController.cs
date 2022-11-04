using BE.DTO;
using System.Diagnostics;
using System.Reflection.Metadata;
using DAL;
using Security;
using BE.entities;
using System.Data;

namespace ByteCard.Controllers;
    public class HomeController 
    {
        Actions actions = new();

    public bool updateData(DataTable tb, int dni) {
        UserDAO actions = new();
        return actions.updateData(tb, dni);
    }
            public DataTable getUserinTable(int dni){
            UserDAO actions = new();
            return actions.GetUserIntable(dni);
            }
        public bool Transaction(transactionDto request)
        {
        Validator validator = new();
        if (request.cash >= request.amount && validator.ValidateCBU(request.destinatary.ToString()) == true)
            {
                return actions.Transaction(request);
            }
            return false;
        }
        
        public bool Deposit(DepositDto request)
        {
            return actions.Deposit(request) ? true : false;
        }
        public User GetData(string mail)
        {
        UserDAO data = new();
        return data.getUser(mail);
        }
        public DataTable GetTransferences(int cbu,int dni)
        {
        return actions.transferences(cbu,dni);
        }
    public DataTable GetTransferencesForMe(int cbu, int dni)
    {
        return actions.transferencesForMe(cbu, dni);
    }
    public DataTable GetDeposits(int cbu) {
        return actions.Deposits(cbu);
    }
    
    public void OpenCalculator()
        {
        string calc = "calc.exe";
        Process.Start(calc);
        }
    }

