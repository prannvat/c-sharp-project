using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeSpan = new TimeSpan(1,2,3);
            // TimeSpan(1,2,3); this takes hours, minutes, seconds in the bracket. It can take more.
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration:" + duration);
            //The above is a way of using DateTime to crate a TimeSpan.

            //Properties:
            Console.WriteLine("Minutes" + timeSpan.Minutes);
            Console.WriteLine("Minutes" + timeSpan.TotalMinutes);
            //Minutes property returns the minutes component of object
            //TotalMinutes returns total minutes of objects which is 1 hour two minutes which is 62 minutes and three seconds.

            //Add:
            Console.WriteLine("Add example:" + timeSpan.Add(TimeSpan.FromMinutes(8)));
            //This adds 8 minutes to original timeSpan.

            //Subtract:
            Console.WriteLine("Add example:" + timeSpan.Subtract(TimeSpan.FromMinutes(8)));
            //This subtracts 8 minutes to original timeSpan.

            //ToString:
            //If you want to convert TimeSpan into string, you simply call the ToString method.
            Console.WriteLine("ToString: " + timeSpan.ToString());

            //Parse:
            //Converting from string to TimeSpan by using Parse method.
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:02"));






        }
    }
}
