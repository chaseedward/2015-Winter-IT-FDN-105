using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int factorial = 0;

            for (int i = num; i <= 0; i++)
            {
                factorial = factorial + (num * (num - i));
                Console.WriteLine(factorial.ToString());
            }

            Console.WriteLine("{0}!     =     {1}", num.ToString(), factorial);
            Console.ReadLine();

        }
    }
}
