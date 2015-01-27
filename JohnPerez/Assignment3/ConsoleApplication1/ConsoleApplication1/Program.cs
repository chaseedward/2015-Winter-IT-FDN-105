using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int column = 1; column < 6; column++) //sets up columns
            {
                for (int row = 1; row < 6; row++) //sets up rows
                { Console.Write("{0,-3}", row * column); } // creates table by multiplying row and column with spacing
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
        
    }
  
}
