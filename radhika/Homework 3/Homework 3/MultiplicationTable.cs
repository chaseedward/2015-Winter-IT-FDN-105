using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            for (Int32 x = 1; x <= 5; x++)
            {
                for (Int32 y = 1; y <= 5; y++)
                {
                    Int32 z = x*y;
                    Console.Write(z + "\t");
                }
                Console.Write("\n"); // Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
