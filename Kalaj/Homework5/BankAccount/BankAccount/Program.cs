using System;


namespace BankAccount
{
    class BankAccount
    {

        // The private balance field
        private decimal _balance;

        // Deposit function
        public void Deposit(decimal amount)
        {
            _balance += amount;
        }

        // Withdrawal function
        public void Withdrawal(decimal amount)
        {
            _balance -= amount;
        }

        //ability to view the balance publicly
        public decimal Balance()
        {
            return _balance;
        }
    }

    class Test
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
