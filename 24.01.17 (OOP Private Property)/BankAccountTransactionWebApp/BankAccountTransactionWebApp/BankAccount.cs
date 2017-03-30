using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankAccountTransactionWebApp
{
    [Serializable]
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public double AccountBalance  { get; set; }


        public string DepositeAmount(double amount)
        {
            if (amount < 0)
            {
                return "Deposite failed!";
            }
            AccountBalance += amount;
            return "Deposite Succeed!!";
        }

        public string WithdrawAmount(double amount)
        {
            if (amount < 0 || amount > amount)
            {
                return "Withdraw failed!";
            }

           // account1.WithdrawAmount(amount);
            AccountBalance -= amount;
            return "Withdraw successfull!";
            
        }

        public string AccountInfo()
        {
            return CustomerName + ", " + "Your account number: " + AccountNumber + " and it's balance: " +
                   AccountBalance + " taka";

        }

    }
}