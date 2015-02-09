using System;
using System.Security.Cryptography.X509Certificates;

namespace Homework_5
{
    public class BankAccount
    {
        private Double balance;

        public void Deposit(double amount)
        {
            this.balance += amount;
        }

        public void Withdrawal(double amount)
        {
            if (this.balance >= amount)
            {
                this.balance -= amount;
            }
            else
            {
                this.balance = -1.0;
            }
        }

        public double Balance()
        {
            return this.balance;
        }
    }
}