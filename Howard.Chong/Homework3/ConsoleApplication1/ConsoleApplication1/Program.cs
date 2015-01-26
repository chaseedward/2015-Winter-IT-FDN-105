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
            // Setting up Columns numbering from 1-5
            for (int column = 1; column < 6; column++)
            {
                // Setting up Rows numbering from 1-5
                for (int row = 1; row < 6; row++)
                {
                    // Creating spacing and multiplying the row and column to fill in the multiplication table
                    Console.Write("{0,-5}", row * column);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
