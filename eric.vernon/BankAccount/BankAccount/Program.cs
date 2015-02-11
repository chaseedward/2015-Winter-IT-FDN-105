using System;


namespace BankAccount
{
    class BankAccount
    {
        private decimal balance;
       // private decimal amount;
        
        public BankAccount()
        {
            balance = 0;
        }

        //create the deposit function
        public decimal Deposit(decimal amount)
        {
            return balance += amount;
        }

        //create the withdrawal function
        public decimal Withdrawal(decimal amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("You have overdrawn your account by {0}", balance - amount);
            }
            return  balance = balance - amount;
        }

        // create the balance field
        public decimal Balance
        {
            get { return balance; }
        }
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
