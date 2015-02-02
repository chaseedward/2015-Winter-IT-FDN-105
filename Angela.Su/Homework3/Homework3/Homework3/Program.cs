using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        public static void Main(string[] args)
        {
            for (int x = 1; x < 6; x++) {
                for (int y = 1; y < 6; y++)
                {
                    Console.Write(x * y + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
