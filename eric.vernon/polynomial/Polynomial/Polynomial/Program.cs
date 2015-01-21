using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 0;
            double calc = 0;
            string formula = ("3x^3 - 5x^2 + 6");

            //need to add error checking at some point
            Console.Write("Please enter a whole number: ");
            string input = Console.ReadLine();

            num = Convert.ToDouble(input);

            calc = (3*Math.Pow(num, 3)) - (5*Math.Pow(num, 2)) + 6;

            Console.WriteLine("The solution to {0} using the number {1} is: {2}", formula, num ,calc);
            Console.ReadKey();

        }
    }
}
