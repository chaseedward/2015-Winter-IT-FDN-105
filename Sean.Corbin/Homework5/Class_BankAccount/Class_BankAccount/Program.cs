using System;
//using System.Collections.Generic;
//using System.Dynamic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//Create a BankAccount class that has a private balance field,
//a public Deposit function that takes a decimal amount,
//and public Withdrawal function that takes a decimal amount.

namespace Class_BankAccount
{
    internal class BankAccount
    {
        //The property of the class
        //create the balance property
        //Resharper suggested name of _balance
        private decimal _balance;

        //create the deposit function
        public void Deposit(decimal amount)
        {
            _balance += amount;
        }

        //withdrawal function
        public void Withdrawl(decimal amount)
        {
            _balance -= amount;
        }

        //had to add this or acct.Balance would not resolve below
        public decimal Balance()
        {
            return _balance;
        }

    }

    class Test
    {
        private static void Main()
        {
            var acct = new BankAccount();

            acct.Deposit(200m);
            acct.Withdrawl(40m);

            Console.WriteLine("Balance {0:C}", acct.Balance());
            Console.ReadLine();
        }
    }
}
