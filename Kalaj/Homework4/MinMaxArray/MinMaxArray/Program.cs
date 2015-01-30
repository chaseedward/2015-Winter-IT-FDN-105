using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxArray
{
    internal class MinMaxArrayClass
    {
        private static void Main()
        {
            int[] numbers = new int[] {5, -2, 100, 12, 4, -5};
            int max = numbers.Max();
            int min = numbers.Min();

            Console.WriteLine("Minimum number in array is {0}", min);
            Console.WriteLine("Maximum number in array is {0}", max);
            Console.ReadLine();
        }
    }
}