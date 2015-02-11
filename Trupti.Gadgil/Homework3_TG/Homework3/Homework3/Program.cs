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
            int x = 1;
            for (int row = 0; row < 5; row++)
            {
                int y = 1;
                for (int col = 0; col < 5; col++)
                {
                    Console.Write("{0,5} ",y*x);
                    y += 1;
                }
                Console.WriteLine();
                x += 1;
            }
                
            Console.ReadLine();
        }
    }
}
