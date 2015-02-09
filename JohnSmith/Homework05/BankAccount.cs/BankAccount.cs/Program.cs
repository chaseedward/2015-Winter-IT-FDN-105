using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.cs
{
    class BankAccount
    {
        // Create a BankAccount class that has a private balance field, 
        // a public Deposit function that takes a decimal amount, 
        // and public Withdrawal function that takes a decimal amount.
        // TODO: create the balance property
        private decimal balance;

        // TODO: create the deposit function
        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        // TODO: create the withdrawal function
        public void Withdrawal(decimal amount)
        {
            balance -= amount;
        }

        // TODO:  add this to the assignment directions
        public decimal Balance()
        {
            return balance;
        }

    }

    class Program
    {
        static void Main()
        {
            var acct = new BankAccount();

            acct.Deposit(200m);
            acct.Withdrawal(40m);
            
            Console.WriteLine("Balance {0:C}", acct.Balance());
            Console.ReadLine();
        }
    }
}
