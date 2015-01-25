using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PolynomialExtraCredit_davey
{
    class Program
    {
        static void Main(string[] args)
        {
            //extra credit polynomial assignment 
            //evaluate 3x3 - 5x2 + 6 for any value of x
            double x;
            Double answer;
            string xstring;

            Console.WriteLine("Enter value for x");
            xstring = Console.ReadLine();

            x = Convert.ToDouble(xstring);
            answer = 3*Math.Pow(x,3) - 5*Math.Pow(x, 2) + 6;

            Console.WriteLine("The answer is {0}",answer);
            Console.WriteLine("you soooo smart");

        }
    }
}
