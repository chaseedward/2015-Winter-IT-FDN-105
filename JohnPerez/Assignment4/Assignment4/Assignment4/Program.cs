using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to find the minimum and maximum number 
            //of an array of integers. Given an array of integers:

            int[] numbers = new int[] { 5, -2, 100, 12, 4, -5, 99999999 };
            Console.WriteLine("Max is {0}", numbers.Max()); //Finds the maximum in the array 
            Console.WriteLine("Min is {0}", numbers.Min()); //Finds the minimum in the array of integers
            Console.ReadLine();


        }
    }
}
