using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp;
            int x;
            double val;

            Console.Write("Enter Value of X for which you would like the polynomial to be calculated : ");
            inp=Console.ReadLine();

            x = Convert.ToInt32(inp);

            val = (3*(Math.Pow(x, 3))) - (5*(Math.Pow(x, 2))) + 6;

            Console.WriteLine("Value of Polynomial 3X3 - 5X2+ 6 = {0}", val);

            Console.ReadLine();
        }
    }
}
