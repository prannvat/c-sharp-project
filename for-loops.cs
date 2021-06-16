using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Break: jumps out of the loop.
            //Continue: jumps to next iteration.#

            //The for loop has three, you have three statements:
            //the first is the the assigning of the variable, her 'i' has been set to 1.
            //Then you have a condition,
            //here the loop runs as long as 'i' is less than or equal to 10.
            //The third statement is an increment, 'i is increased by 1 each time the loop runs.
            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                   Console.WriteLine(i);
                }
                //what both these for loops do is print all the even numbers from 1 to 10,
                //the above in ascending order. the below in descending order.
            }


            //The for loop has three, you have three statements:
            //the first is the the assigning of the variable, her 'i' has been set to 10.
            //Then you have a condition,
            //here the loop runs as long as 'i' is more than or equal to 1.
            //The third statement is a decrement, 'i' is decreased by 1 each time the loop runs.

            for (var i = 10; i >=1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        } 
    }
}
