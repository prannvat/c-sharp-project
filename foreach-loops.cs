using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Prannvat Singh";
            for ( var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
                //The for loop above is used to output each character in the string 'name' by itself on a new line.
                //Below, I will use a foreach loop to do the same thing and explain why it is more clean to use.
            }

            foreach (var character in name)
            {
                Console.WriteLine(character);
                //with the 'foreach', you don't have to worry abput a counter variable like the 'i',
                //that is used with the for loop.
                //With the foreach, we have a variable called 'character'.
                //With each step of the iteration, the 'character variable holds one charcter of the string,
                //in this case the string is the variable 'name'. This makes it easier,
                //as you don't have to compare a variable(like 'i) using the 'name.Length'.
                //Also you don't need to increment anything.
                //THEREFORE, WHENEVER WE HAVE AN INNUMERABLE OBJECT e.g string, array, list,
                //IT IS BETTER TO USE THE foreach loop.
            }

            var numbers = new int[] { 1, 2, 3, 4 };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
                //just another example of why foreach is better for innumerable objects.
            }


        }
    }
}
