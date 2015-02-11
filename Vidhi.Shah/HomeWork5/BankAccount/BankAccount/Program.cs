using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{

    class BankAccount
    {
        public Decimal Balance;

        public void Withdrawal(Decimal wd)
        {
            Balance = Balance - wd;
        }

        public void Deposit(Decimal dd)
        {
            Balance = Balance + dd;
        }

        public BankAccount()
        {
            Balance = 160;
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
