using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassProject_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read in a date and output it

            // dd/mm/yyyy
            // mm/dd/yyyy
            // yyyy/mm/dd
            // dd-mmm-yyyy
            // Month: 02 or Feb
            // Day: 13
            // Year: 2013

            // * yyyy/mm/dd
            Console.WriteLine("Enter today's date (format yyyy/mm/dd):");
            var dateString = Console.ReadLine();

            // HardMode
            //var yearString = dateString.Substring(0, 4);
            //var monthString = dateString.Substring(5, 2);
            //var dayString = dateString.Substring(8, 2);

            //var intYear = int.Parse(yearString);
            //var intMonth = int.Parse(monthString);
            //var intDay = int.Parse(dayString);

            //var dateTime = new DateTime(intYear, intMonth, intDay);
           
            // Lucky (if formatting is correct)
            //DateTime dateTime = DateTime.Parse(dateString);
            
            //option 3: format is bad
            var pieces = dateString.Split('/');

            if (pieces[0].Length == 2)
            {
                pieces[0] = "20" + pieces[0];
            }            
            var intYear = int.Parse(pieces[0]);
            var intMonth = int.Parse(pieces[1]);
            var intDay = int.Parse(pieces[2]);

            var dateTime = new DateTime(intYear, intMonth, intDay);
            Console.WriteLine(dateTime.ToShortDateString());
            Console.ReadLine();
        }
    }
}
