using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//sean notes: Homework week 3
namespace Multiplication_Table
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //sean notes: the increment operator (++) increments its operand by 1
            //sean notes: Start loops - outer most loop will do rows and inner most loop columns
            for (int x = 1; x < 6; x++)
            {
                for (int y = 1; y < 6; y++)
                {
                    //sean notes: first int is empty string at position | second int is number spaces between columns | left-aligned (a negative integer) or right-aligned (a positive integer) 
                    Console.Write("{0,-6}", (x*y));
                }
                //sean notes: this is for a new line
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
