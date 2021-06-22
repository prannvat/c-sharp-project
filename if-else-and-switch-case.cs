using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_and_switch_case
{

    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    class Program
    {
        static void Main(string[] args)
        {
            var hour = 10;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning!");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon!");
            }
            else
            {
                Console.WriteLine("It's evening");
            }

            bool isGoldCustomer = true;
            // float price;
            // if (isGoldCustomer)
            //     price = 199.95f;
            // else
            //    price = 29.95f

            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);
            //This is a shortcut to write if/else statement. The ? is 'then' and ":" is else.

            var season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season.");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's a perfect time to go to the beach .");
                    break;
                case Season.Spring:
                case Season.Winter:
                    Console.WriteLine("The weather is nice, but summer is better");
                    break;
     //the above two cases: the spring and winter are formatted like this.
     //This is because if you have two or more cases that have the same statements, the code can look identical.
     //This can be coonfusaing hence you can format it like this so the one statement is applied to both conditions.
                default:
                    Console.WriteLine("I don't understand this season.");
                    break;
                    //the above switch case uses the 'season' enum

            
            }
                   

        }
    }
}
