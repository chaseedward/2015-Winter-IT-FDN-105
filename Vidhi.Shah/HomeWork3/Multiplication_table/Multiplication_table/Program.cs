using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            string val;

            for (i = 1; i <= 5; i++)
            {
                for(j=1;j<=5;j++)
                {
                    val = Convert.ToString(i*j);
                    Console.Write("{0,-5}", val);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
