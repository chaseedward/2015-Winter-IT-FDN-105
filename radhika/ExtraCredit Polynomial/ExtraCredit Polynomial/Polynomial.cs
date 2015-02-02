using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtraCredit_Polynomial
{
    class Polynomial
    {
        static void Main(string[] args)
        {
            Double x, y;
            Console.WriteLine("Input Value of x =");
            String r = Console.ReadLine();
            x = Convert.ToDouble(r);
            y= 3* Math.Pow(x,3)-5*Math.Pow(x,2) + 6;
            Console.WriteLine(y);
            Console.ReadLine();

        }
    }
}
