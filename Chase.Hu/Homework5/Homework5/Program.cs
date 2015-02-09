using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
// File: BankAccount.cs
    class BankAccount
    {
        private double balanceField;// TODO: create the balance field
        public void Deposit(double x) // TODO: create the deposit function
            {
                balanceField -= x;
            }
        public void Withdrawal(double x) // TODO: create the withdrawal function
        {
            balanceField += x;    
        }
        public double getBalanceField()
        {
            return balanceField;
        }
    }

    class Test
    {
        static void Main()
        {
            BankAccount acct = new BankAccount();
        
            acct.Deposit(200);
            acct.Withdrawal(40);
        
           Console.WriteLine("Balance {0:C}", acct.getBalanceField());

            Console.ReadLine();
        }
    }
}