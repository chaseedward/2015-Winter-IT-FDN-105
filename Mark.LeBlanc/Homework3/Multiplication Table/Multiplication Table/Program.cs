using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 5; i++)
            {
                for (var j = 1; j <= 5; j++)
                {
                    Console.Write("{0,-5}", (i*j));
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
