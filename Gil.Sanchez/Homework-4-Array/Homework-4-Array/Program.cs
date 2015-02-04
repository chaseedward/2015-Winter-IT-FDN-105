using System;
using System.Linq;

namespace Homework_4_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null) throw new ArgumentNullException("args");

            int[] numbers = new int[] {5, -2, 100, 12, 4, -5, 10, -10, -400, 1000 }; //The Array is declared with numbers
            int minimo = numbers.Min();
            int maximo = numbers.Max();

            Console.WriteLine("The minimum number in the Array is {0}\n" +
                              "The maximum number in the Array is {1}", minimo, maximo);
            Console.ReadLine();                             //The (\n) creates a new line for the maximum

           
            //Here is another way to get the Minimum and the Maximum of Any Array you imput into the program

            /*Console.Write("How many numbers do you want to store in array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];


            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number {0}:  ", i + 1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = numbers[0];
            int max = numbers[0];

            for (int i = 0; i < n; i++)
            {
                if (min > numbers[i]) min = numbers[i];
                if (max < numbers[i]) max = numbers[i];
            }
            Console.WriteLine("The minimum for the Array is: {0}", min);
            Console.WriteLine("The maximum for the Array is: {0}", max);
            Console.ReadKey(); */
        }
    }
}
