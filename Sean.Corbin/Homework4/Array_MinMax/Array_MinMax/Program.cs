using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            //sean notes - Declare and set array element values
            //sean notes - the following also works - var array = new int[] {7, 5, -2, 100, 12, 4, -5, 50, 99, 35, 25};
            int[] array = new int[] { 7, 5, -2, 100, 12, 4, -5, 50, 99, 35, 25 };

            //sean notes - declare int
            int maximum;
            int minimum;

            //sean notes
            minimum = maximum = array[0];

            //sean notes - iterate through the array to compare the integers
            foreach (int i in array)
            {
                if (i > maximum)
                {
                    maximum = i;
                }
                if (i < minimum)
                {
                    minimum = i;
                }
            }

            Console.WriteLine("The Minimum integer from the array = {0}", minimum);
            Console.WriteLine("The Maximum integer from the array = {0}", maximum);
            Console.ReadLine();

        }
    }
}
