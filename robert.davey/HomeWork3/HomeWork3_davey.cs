using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            //inefficent 

           var x = 1;var x2 = 2;var x3 = 3;var x4 = 4;var x5 = 5;
           Console.WriteLine("{0}  {1}  {2}  {3}  {4}\n{5}  {6}  {7}  {8}  {9}\n{10}  {11}  {12}  {13} {14}\n{15}  {16}  {17} {18} {19}\n{20}  {21} {22} {23} {24}", x, ++x, ++x, ++x, ++x, x2, x2 * 2, x2 * 3, x2 * 4, x2 * 5, x3, x3 * 2, x3 * 3, x3 * 4, x3 * 5, x4, x4 * 2, x4 * 3, x4 * 4, x4 * 5, x5, x5 * 2, x5 * 3, x5 * 4, x5 * 5);



        }
    }
}
