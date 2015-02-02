using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, -2, 100, 12, 4, -5 };
            int big, small;
            big = small = 0;

            foreach (int n in numbers)
            {
                if (n > big) big = n;
                if (n < small) small = n;
            }
            Console.WriteLine("Max number in numbers: {0}", big);
            Console.WriteLine("Minimum number in numbers: {0}", small);
            Console.ReadLine();
        }
    }
}
