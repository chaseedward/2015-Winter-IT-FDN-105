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
            int[] numbers = { 5, -2, 100, 12, 4, -5 };
            int max = numbers.Max();
            int min = numbers.Min();

            Console.WriteLine("Min number in array is {0}", min);
            Console.WriteLine("Max number in array is {0}", max);
            Console.WriteLine();

            //brute force method
            int[] num = { 5, -2, 100, 12, 4, -5 };
            int len = num.Length;
            int maxnum = 0;
            int minnum = 0;

            for (int i = 0; i < len; i++)
            {
                for (int j = 1; j < len - 1; j++)
                {
                    if (num[i] < num[j])
                    {
                        minnum = num[i];
                    }
                    //I have a bug here that I can't figure out. 
                    if (num[i] > num[j])
                    {
                        maxnum = num[i];
                    }
                }
                    
            }

            Console.WriteLine("Min number in array is {0}", minnum);
            Console.WriteLine("Max number in array is {0}", maxnum);

            Console.ReadLine();
        }
    }
}
