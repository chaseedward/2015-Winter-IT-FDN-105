using System;

namespace Homework_5_BankAccount
{
    class Program
    {
        private const double Balance = 0;
        private const double Deposit = 200;
        private const double Withdraw = 40;

        public double GetBalance()
        {
            return Deposit-Withdraw;
        }

        public double GetDeposit()
        {
            return Balance + Deposit;
        }

        public double GetWithdraw()
        {
            return Balance - Withdraw;
        }

        private static void Main(string[] args)

        {
            Program acc = new Program();
            Console.WriteLine("Your Balance is:$ "  + acc.GetBalance());
            Console.WriteLine("Your Deposit is:  " + acc.GetDeposit());
            Console.WriteLine("Your Withdraw is: " + acc.GetWithdraw());
            Console.ReadKey();
        }
    }
}

