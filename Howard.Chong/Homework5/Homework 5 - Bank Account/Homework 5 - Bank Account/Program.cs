using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5___Bank_Account
{
    class BankAccount
    {
        private decimal bal;
        // Private Balance Field

        public BankAccount()
        {
            bal = 0;
        }

        public decimal Deposit(decimal amt)
        {
            return bal += amt;
        }
        //Deposit function in decimal amount

        public decimal Withdrawal(decimal amt)
        {
            return bal = bal - amt;
        }
        // Withdrawal Function

        public decimal Balance
        {
            get { return bal; }
        }
        // Balance Field
    }

    class Test
    {
        static void Main()
        {
            var acct = new BankAccount();
            acct.Deposit(200m);
            acct.Withdrawal(40m);

            Console.WriteLine("Balance {0:C}", acct.Balance);

            Console.ReadLine();
        }
    }
}
