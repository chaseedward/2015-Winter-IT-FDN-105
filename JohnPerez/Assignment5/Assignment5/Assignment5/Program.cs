using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BankAccount

{
    private double Balance; // TODO: create the balance property

    public void Deposit(double x)
        {
            Balance += x; // TODO: create the deposit function
        }
    public void Withdrawal(double x)
        {
            Balance -= x; // TODO: create the deposit function
        }
 public double newBalance()
 {return Balance;}
}
class Test
{

    static void Main()
    {

        var acct = new BankAccount();



        acct.Deposit(200);

        acct.Withdrawal(40);



        Console.WriteLine("Balance {0:C}", acct.newBalance());

        Console.ReadLine();

    }

}

