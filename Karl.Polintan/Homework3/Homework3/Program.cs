using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var x = 1; x <= 4; x++) // column variable, only runs to 4 so console write line works for row 5.
            {
                for (var y = 1; y <= 5; y++) // row variable.
                {
                    Console.Write("{0,-3}", (x*y));

                }
                Console.WriteLine();
            }
            Console.WriteLine("{0,-2} {1,-2} {2,-2} {3,-2} {4,-2}", 5, 10, 15, 20, 25);
            // added WriteLine from in class, just for variety.

            Console.ReadLine();
        }
    }
}
