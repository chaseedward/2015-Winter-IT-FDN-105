using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class BankAccount
    {
        private decimal balance;

        public decimal Balance
        {
            get
            {
                return decimal.Round(balance, 2, MidpointRounding.AwayFromZero);
            }
        }

        public void Deposit(decimal money)
        {
            balance += money;
        }

        public void Withdrawal(decimal money)
        {
            balance -= money;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var acct = new BankAccount();

            acct.Deposit(200m);

            acct.Withdrawal(40m);

            Console.WriteLine("Balance {0:C}", acct.Balance);

            Console.ReadLine();
        }
    }
}
