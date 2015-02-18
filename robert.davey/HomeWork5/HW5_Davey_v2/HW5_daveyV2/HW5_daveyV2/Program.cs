using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_daveyV2
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new AccountClass();
            account.Deposit(200);
            account.Withdrawl(40);
            Console.WriteLine("$" + account.Balance());
        }
    }
}
