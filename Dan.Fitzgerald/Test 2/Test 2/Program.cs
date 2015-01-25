using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int suma = 0;
            int a;
           

            for (a = 1; a < 6; a++)
            {
                suma = 1 + a;

                if (suma > 6)
                {
                    break;
                }
            }
            
            

           

                Console.WriteLine("{0}",a);
        }

                Console.ReadLine();

    }
}
