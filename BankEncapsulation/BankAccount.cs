using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {
      
        }

        private double balance = 0;

        //Deposit method Encapsulation
        public void Deposit(double amount)
        {
            balance = amount;
        }

        //Get Balance Method
        public string GetBalance()
        {
            return $"${balance}";
        }


    }
}
