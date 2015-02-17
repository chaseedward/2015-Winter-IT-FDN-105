using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Spliting this question into multiple sentences:

 //1. Create a BankAccount class
 //2. Add a member variable named "balance" whose visibility is "private"
 //3. Add a member function called "deposit" whose visibility is "public"
 //4. Add a member function called "withdraw" whose visibility is "public
namespace Homework5
{
    class BankAccount 
    {
        decimal Balance; 
        public void Deposit(decimal x)
        {
           Balance -= x;
        }
        public void Withdrawal(decimal x)
        {
            Balance += x;
        }
        public decimal Getbalance()
        {
            return Balance;
        }
}

class Test

{

 static void Main()

 {

 var acct = new BankAccount();

 

 acct.Deposit(200);

 acct.Withdrawal(40);



 Console.WriteLine("Balance {0:C}", acct.Getbalance());

 Console.ReadLine();

 }

}

}