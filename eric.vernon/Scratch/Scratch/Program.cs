// Arrays2.cs
using System;

class TestArrays
{
    static void Main()
    {
        // ******************************
        // Single-dimensional array
        //
        int[] numbers = new int[] { 10, 20, 30, 40, 50 };

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("numbers[{0}] = {1}", i, numbers[i]);
        }

        Console.WriteLine("Lower bound of numbers is {0}",
                          numbers.GetLowerBound(0));
        Console.WriteLine("Upper bound of numbers is {0}",
                          numbers.GetUpperBound(0));

        // ******************************
        // Multi-dimensional array
        // 5 rows and 4 columns
        //
        string[,] names = new string[5, 4];

        Console.WriteLine("Upper bound of first dim is {0}",
                          names.GetUpperBound(0));
        Console.WriteLine("Upper bound of second dim is {0}",
                          names.GetUpperBound(1));

        // ******************************
        // Array-of-arrays (jagged array)
        //
        byte[][] scores = new byte[5][];

        // Create the jagged array
        for (int i = 0; i < scores.Length; i++)
        {
            scores[i] = new byte[i + 3];
        }

        // Print length of each row
        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine("Length of row {0} is {1}", i, scores[i].Length);
        }

        // ******************************
        // arrays of objects
        //
        object[] objArray = new object[3];
        objArray[0] = 32;
        objArray[1] = "hello";
        objArray[2] = 4.3;
        for (int i = 0; i < objArray.Length; i++)
        {
            Console.WriteLine(objArray[i]);
        }

        Console.ReadLine();
    }
}