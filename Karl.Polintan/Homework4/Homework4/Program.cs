using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            //establishing the elements of the array.
            int[] numbers = new int[] {5, -2, 100, 12, 4, -5};

            //declare max/min
            int MaxNumber = numbers.Max();
            int MinNumber = numbers.Min();

            //write min/max
            Console.WriteLine("Max={0}", MaxNumber);
            Console.WriteLine("Min={0}", MinNumber);


            Console.ReadLine();
        }
    }
}
