using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace in_class_project_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that allows the user to enter a number.
            // The program will determine if the number that the user entered 
            // is in the array. 
            int[] numbers = {8, 15, 22, -2, 99, 47};

            Console.WriteLine("Enter a number:");
            var userString = Console.ReadLine();

            var userNumber = int.Parse(userString);

            foreach (int number in numbers)
            {
                if (userNumber == number)
                {
                    Console.WriteLine("You win");
                }
            }

            Console.ReadLine();
        }
    }
}
