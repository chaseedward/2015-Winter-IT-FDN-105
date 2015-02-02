using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x < 6; x++)
            {
               Console.Write("{0,5}", x);

                for (int y = 1; y < 2; y++)
                {
                    Console.Write("{0,5}", x*2);
                    Console.Write("{0,5}", x*3);
                    Console.Write("{0,5}", x*4);
                    Console.Write("{0,5}", x*5);
                    Console.WriteLine(); 
                }
            }
            Console.ReadLine();
        }
    }
}
