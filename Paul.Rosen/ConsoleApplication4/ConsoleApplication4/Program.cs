using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMyAccount
{
    class BankAccount
    {
        private decimal acctbal = 0M;

        // public Constructor
        public BankAccount()
        {
        }
    
        // TODO: create the balance property
        public decimal Balance()
        {
            return acctbal;
        }

        // TODO: create the deposit function
        public void Deposit (decimal bigbuxin)
        {
            acctbal = (acctbal + bigbuxin);
        }

        // TODO: create the withdrawal function
        public void Withdrawal (decimal cashout)
        {
            acctbal = (acctbal - cashout);
        }
    }

    class Test
    {
        static void Main()
        {
            var acct = new BankAccount();

            acct.Deposit(200m);

            acct.Withdrawal(40m);

            //  Unfortunately I could not get this to run without open/close parenthesis after acct.Balance
            Console.WriteLine("Balance {0:C}", acct.Balance());
            
            Console.ReadLine();

        }
    }
}