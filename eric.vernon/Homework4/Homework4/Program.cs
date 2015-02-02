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

            //brute force method sorting the array
            int[] num = { 5, -2, 100, 12, 4, -5 };
            
            int maxnum = 0;
            int minnum = 0;
            int temp = 0; //temp var for sort
            int len = num.Length; //length of array for use later

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length - 1; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        temp = num[j + 1];
                        num[j + 1] = num[j];
                        num[j] = temp;
                    }
                }
            }

            for (int k = 0; k < num.Length; k++)
            {
                Console.Write(num[k] + " ");
            }
            Console.WriteLine();
            minnum = num[0];
            maxnum = num[len - 1];
            Console.WriteLine("Min number in array is {0}", minnum);
            Console.WriteLine("Max number in array is {0}", maxnum);

            Console.ReadLine();
        }
    }
}
