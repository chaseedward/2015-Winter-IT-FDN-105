using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class TestMain
    {
        static void Main()
        {
            var acct = new BankAccount();
            acct.Deposit(200.00);
            acct.Withdrawal(40.00);
            Console.WriteLine("Balance {0:C}", acct.Balance());
            Console.ReadLine();
        }
    }
}
