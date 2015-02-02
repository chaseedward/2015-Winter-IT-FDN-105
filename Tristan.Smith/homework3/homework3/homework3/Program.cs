using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int x=5,y=5;    // The amount of rows and columns.
                            // Change it up to make the table bigger or smaller!

            for (i = 1; i < y + 1; i++)
            {
                for (j = 1; j < x + 1; j++)
                {
                    Console.Write("{0,4}",j*i);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
