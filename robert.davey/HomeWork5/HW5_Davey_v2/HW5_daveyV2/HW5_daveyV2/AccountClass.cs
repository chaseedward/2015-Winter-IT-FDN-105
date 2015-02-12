using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_daveyV2
{
    class AccountClass
    {
        private double balance;


        //deposit function, cashmoney is input
        public void Deposit(double cashmoney)
        {
            this.balance += cashmoney;

        }

        //withdrawl function, cashmoney is input
        public void Withdrawl(double cashmoney)
        {
            this.balance -= cashmoney;
        }

        public double Balance()
        {
            return this.balance;
        }
    }
}
