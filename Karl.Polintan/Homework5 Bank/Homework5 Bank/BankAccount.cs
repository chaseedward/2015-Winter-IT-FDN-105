using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_Bank
{
    public class BankAccount
    {
            /* TODO: create the balance property
             * TODO: create the deposit function
             * TODO: create the withdrawal function */

        private Double _balance;
      
        public void Deposit(double amount)
            {
                this._balance += amount;
            }

        public void Withdrawal(double amount)
            {
                this._balance -= amount;
            }

        public double GetBalance()
        {
            return this._balance;
        }
    }
    }
