using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3];
            //you need to use the 'new' keyword to allocate memory to the array.
            numbers[0] = 1;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            // when run. the other index values have not been assigned,
            //so are assigned to default value of 0, if it was boolean, the default valuse is false.

            var names = new string[3] { "Jack", "Mary", "John" };
            //this is called object initialisiation and this is the syntax
            //you can assign values like this too.


    
        }
    }
}
