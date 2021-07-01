using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_time
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);
            Console.WriteLine("Tomorrow:" + tomorrow);
            Console.WriteLine("Yesterday:" + yesterday);



            Console.WriteLine(now.ToLongDateString());
            //returns this: 01 July 2021
            Console.WriteLine(now.ToShortDateString());
            //returns this: 01/07/2021
            Console.WriteLine(now.ToLongTimeString());
            //returns this: 13:37:03
            Console.WriteLine(now.ToShortTimeString());
            //returns this: 13:37
            Console.WriteLine(now.ToString());
            //returns this: 01/07/2021 13:39:56
            //seeing all the values that are retuned, it is very self explananatory what all the .To methods do.
            //You can also format the dateTime to how you wnat it using the specified formatting strings, thaat you enter in the .To brackets.

        }
    }
}
