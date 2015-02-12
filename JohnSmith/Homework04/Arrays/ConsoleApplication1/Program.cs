using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, -2, 100, 12, 4, -5 };
            int lowest = numbers[0],
                highest = numbers[0];
            foreach (int x in numbers)
            {
                if (x > highest)
                {
                    highest = x;
                }
                if (x < lowest)
                {
                    lowest = x;
                }
            }
            Console.WriteLine("Max = " + highest);
            Console.WriteLine("Min = " + lowest);
            var foo = Console.ReadLine();
        }
    }
}
