using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write the array elements. Will use the example numbers from homework plus some extra numbers.
            int[] NumberArray = new int[] { 5, -2, 100, 12, 4, -5, 99, 3, -4, 0, 23, -1, 50 };

            // Declare and set the Maximum and Minimum int
            int MaxNumber = NumberArray.Max();
            int MinNumber = NumberArray.Min();

            // Write the Max and Min numbers in the array
            Console.WriteLine("Maximum number in the array is {0}", MaxNumber);
            Console.WriteLine("Minimum number in the array is {0}", MinNumber);

            Console.ReadLine();
        }
    }
}
