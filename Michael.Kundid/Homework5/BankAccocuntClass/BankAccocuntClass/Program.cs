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

        private Decimal _balance;


        public void Deposit(Decimal amtchanged)
        {
            this._balance += amtchanged;
        }

        public void Withdrawal(Decimal amtchanged)
        {
            this._balance += amtchanged;
        }

        public Decimal GetBalance()
        {
            return this._balance;
        }
  
    }

    class Test
    {
        static void Main()
        {
            var acct = new BankAccount();

            acct.Deposit(200m);
            acct.Withdrawal(40m);

            Console.WriteLine("Balance {0:C}",acct.GetBalance());
            Console.ReadLine();
        }
    }

}

