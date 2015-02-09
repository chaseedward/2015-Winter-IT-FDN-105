using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = new int[] {5, -2, 100, 12, 4,-5};
            int minimum = myarray[0];
            int maximum = minimum;
            int ptr;


// Solution #1: Copy the cell contents
            for (ptr=1; ptr<myarray.Length; ptr++)
            {
                if (minimum > myarray[ptr])
                {
                    minimum = myarray[ptr];
                }
                if (maximum < myarray[ptr])
                {
                    maximum = myarray[ptr];
                }
            }
            Console.WriteLine ("Solution #1: Copy the cell contents");
            Console.WriteLine ("Min = {0,-4}", minimum);
            Console.WriteLine ("Max = {0,-4}", maximum);
            Console.Write ("Press [Return] to continue: ");
            Console.ReadLine ();
            Console.WriteLine(" ");
            

// Solution #2: Copy the cell pointer
            minimum = 0;
            maximum = 0;
            for (ptr = 1; ptr < myarray.Length; ptr++)
            {
                if (myarray[minimum] > myarray[ptr])
                {
                    minimum = ptr;
                }
                if (myarray[maximum] < myarray[ptr])
                {
                    maximum = ptr;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Solution #2: Copy the cell pointer");
            Console.WriteLine("Min = {0,-4}", myarray[minimum]);
            Console.WriteLine("Max = {0,-4}", myarray[maximum]);
            Console.Write("Press [Return] to continue: ");
            Console.ReadLine();
            Console.WriteLine(" ");


// Solution #3: Use the methods
            Console.WriteLine(" ");
            Console.WriteLine("Solution #3: Use the methods");
            Console.WriteLine("Min = {0,-4}", myarray.Min());
            Console.WriteLine("Max = {0,-4}", myarray.Max());
            Console.Write("Press [Return] to continue: ");
            Console.ReadLine();


        }
    }
}
