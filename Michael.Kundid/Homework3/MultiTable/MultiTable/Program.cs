using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MultiTable
{
    class Program
    {
        private static void Main(string[] args)
        {
            int a;
            int x;
            for (x = 1; x <= 5; x++)
            {
                Console.WriteLine("\n");
                for (a = 1; a <= 5; a++)
                {
                    Console.Write("{0,5}",x*a);
                }
            }
            Console.ReadLine();
        }
        }

        }
 
