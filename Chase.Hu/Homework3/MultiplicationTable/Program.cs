using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 6; i++)
            {
               Console.Write("{0,5}", i);

                for (int j = 1; j < 2; j++)
                {
                    Console.Write("{0,5}", i*2);
                    Console.Write("{0,5}", i*3);
                    Console.Write("{0,5}", i*4);
                    Console.Write("{0,5}", i*5);
                    Console.WriteLine(); 
                }
            }
            Console.ReadLine();
        }
    }
}