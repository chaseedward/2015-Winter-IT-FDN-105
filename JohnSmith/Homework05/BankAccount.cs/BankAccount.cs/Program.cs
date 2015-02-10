using System;

namespace BankAccount.cs
{
    class BankAccount
    {
        // Create a BankAccount class that has a private balance field, 
        // a public Deposit function that takes a decimal amount, 
        // and public Withdrawal function that takes a decimal amount.
        // TODO: create the balance property
        private decimal _balance;

        // TODO: create the deposit function
        public void Deposit(decimal amount)
        {
            _balance += amount;
        }

        // TODO: create the withdrawal function
        public void Withdrawal(decimal amount)
        {
            _balance -= amount;
        }

        // TODO:  add this to the assignment directions
        public decimal Balance()
        {
            return _balance;
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
