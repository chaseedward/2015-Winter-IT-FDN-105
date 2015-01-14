using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dog
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 2;

            // Single if statements
            if (x == y)
            {
                Console.WriteLine("x is equal to y");
            }

            if (x != y)
            {
                Console.WriteLine("x is not equal to y");
            }

            if (x > 5)
            {
                Console.WriteLine("x is greater than 5");
            }

            if (x >= 5)
            {
                Console.WriteLine("x is greater than or equal to 5");
            }

            if (y < 2)
            {
                Console.WriteLine("y is less than 2");
            }

            if (y <= 2)
            {
                Console.WriteLine("y is less than or equal to 2");
            }

            // if-else statements
            if (x == 5)
            {
                Console.WriteLine("x is equal to y");
            }
            else
            {
                Console.WriteLine("x is not equal to y");
            }

            if (x > 5)
            {
                Console.WriteLine("x is greater than 5");
            }
            else if (x > 4)
            {
                Console.WriteLine("x is greater than 4");
            }
            else if (x > 3)
            {
                Console.WriteLine("x is greater than 3");
            }
            else
            {
                Console.WriteLine("x is less than or equal to 3");
            }

            // compound statements
            if (x > 1 && y > 1)
            {
                Console.WriteLine("x is greater than 1 AND y is greater than 1");
            }

            if (x > 5 || y < 4)
            {
                Console.WriteLine("x is greater than 5 OR y is less than 4");
            }

            if ((x > 2 && y < 3) || x == 2)
            {
                Console.Write(" (x is greater than 2 AND y is less than 3)");
                Console.WriteLine(" OR (x is equal to 2)");
            }

            // switch
            switch (x)
            {
                case 1:
                    {
                        Console.WriteLine("x is 1");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("x is 2");
                        break;
                    }
                case 3:
                case 4:
                    {
                        Console.WriteLine("x is 3 or 4");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("x is not 1 or 2 or 3 or 4");
                        break;
                    }
            }

        }
    }
}
