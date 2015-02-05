using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int column, row;
            Console.WriteLine("An Array Using Nested Loops:");
            for (row = 1; row < 6; row++)
            {
                for (column = 1; column < 6; column++)
                {
                    Console.Write("{0,-3}", row*column);
                   
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
            Console.Write("Press [Enter] to Continue: ");
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("An Array Using a Single Loop:");
            for (row = 1; row < 6; row++)
            {
                Console.WriteLine("{0,-3}{1,-3}{2,-3}{3,-3}{4,-3}", row, row * 2, row * 3, row * 4, row * 5);
            }
            Console.WriteLine(" ");
            Console.Write("Press [Enter] to Continue: ");
            Console.ReadLine();
            Console.WriteLine(" ");
        }
    }
}
