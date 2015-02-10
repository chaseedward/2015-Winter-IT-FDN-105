using System;

namespace BankAccountClass
{
    class BankAccount
    {
        //Balance field
        private Decimal _acctBalance;

        //Constructor
        public BankAccount()
        {
            _acctBalance = 0;
        }

        //Getter
        public Decimal AcctBalance
        {
            get { return _acctBalance; }
        }

        //Deposit function
        public void Deposit(Decimal depositAmt)
        {
            _acctBalance += depositAmt;
        }

        //Withdrawal function with a basic check to not allow overdrawing account
        public void Withdrawal(Decimal withdrawalAmt)
        {
            if (AcctBalance >= withdrawalAmt)
            {
                _acctBalance -= withdrawalAmt;
            }
        }
    }

    class Test
    {
        static void Main()
        {
            BankAccount acct = new BankAccount();

            acct.Deposit(200m);
            acct.Withdrawal(40m);
        
            Console.WriteLine("Balance {0:C}", acct.AcctBalance);

            Console.ReadLine();
        }
    }
}