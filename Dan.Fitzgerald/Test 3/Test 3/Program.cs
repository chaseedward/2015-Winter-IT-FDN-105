using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int suma = 0;
            int a;
            int sumb = 0;
            int b;

             
            {
                
            }
            (a = 1; a < 6; a++)
            {
                suma = 1 + a;

                if (suma > 6)
                {
                    break;
                }

                if (suma == 7)
                {
                    continue;
                }

            Parallel.For(b = 1; b < 12; b++)
            {
                sumb = 2 + b;

                if (sumb > 11)
                {
                    break;
                }

                if (sumb == 12)
                {
                    continue;
                }

                    Console.WriteLine("{0}  {1}", a, b);
                }

                Console.ReadLine();
            }
        }
    }
}