using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccocuntClass
{
    class BankAccount
    {
        //TODO: create the balance property
        //TODO: Create the deposit function
        //TODO: Create the Withdrawal Function
        public decimal Balance = 0;
        private decimal withdrawal = 0;
        private decimal deposit = 0;

        public void Deposit(decimal @decimal)
        {
            
        }

        public void Withdrawal(decimal @decimal)
        {
            
        }
    }

    class Test
    {
        static void Main()
        {
            var acct = new BankAccount();

            acct.Deposit(200m);
            acct.Withdrawal(40m);

            Console.WriteLine("Balance {0:C}",acct.Balance);
        }
    }

}

