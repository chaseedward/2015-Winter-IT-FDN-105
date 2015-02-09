using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //var numbers = new int[] { 5, -2, 100, 12, 4, -5, 5, -2, 100, 12, 4, -5, 5, -2, 100, 12, 4, -5 };
            //var numbers = new int[] { 5, -2, 100, 12, 4, -5, 5, -2, 100, 12, 4, -5 };
            var numbers = new int[] {5, -2, 100, 12, 4, -5};
            
            //Print array contents to console
            foreach (var t in numbers)
            {
                Console.Write("{0,-5}", t);
            }

            Console.WriteLine();

            var stillGoing = true;  //While loop condition

            //Bubble sort
            while (stillGoing)
            {
                //Set while loop exit condition. If no swaps happen we're done.
                stillGoing = false;

                //Iterate over array, comparing and swapping
                for (var i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        var swapHolder = numbers[i + 1]; //Hold int to swap
                        numbers[i + 1] = numbers[i]; //Move larger number forward in array
                        numbers[i] = swapHolder; //Move smaller number back in array
                        stillGoing = true; //Keep iterating over array
                    }
                }
                
                //Print array contents to console only if we are still iterating over array
                if (stillGoing)
                {
                    foreach (var t in numbers)
                    {
                        Console.Write("{0,-5}", t);
                    }
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}
