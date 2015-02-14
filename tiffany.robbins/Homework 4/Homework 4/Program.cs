using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]numbers = new int[]{3, 5, 35, 27, 4, 99, 67 };

            int Max = numbers.Max();
            int Min = numbers.Min();

            Console.WriteLine("Maximum Number of the Array is {0}", Max);
            Console.WriteLine("Minimum Number of the Array is {0}", Min);

            Console.ReadLine();
        }
    }
}
