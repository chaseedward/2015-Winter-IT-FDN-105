using System;


namespace HomeWork4
{
    internal class MinMaxArrayProgram
    {
        private static void Main(string[] args)
        {
            var arr = new[] {5, -2, 100, 12, 4, -5};
            var max = arr[0];
            var min = arr[0];
            foreach (var i in arr)
            {
                if (max <= i)
                {
                    max = i;
                }
                if (min >= i)
                {
                    min = i;
                }
            }
            Console.WriteLine("The Maximum number is " + max);
            Console.WriteLine("The Minimum number is " + min);
            Console.ReadLine();

        }            
        

    }
}