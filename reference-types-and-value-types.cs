using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reference_types_and_value_types
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            //Here, the value of 'b' is assigned to 'a'(hence 10),
            //but then the value of 'b' is increased by one.
            //The value of 'a' however remains 10, because integers are value types,
            //so when we copy value types to another variable,
            //a COPY of that value is taken and stored in the target location in memory.
            //Hence the value of 'a' doesn't change as 'b' is assigned a copy of that value.
            //Thus they act independently and seperately.
            Console.WriteLine(string.Format("a: {0}, b: {1}",a, b));
            //THE ABOVE SHOWS US HOW VALUE TYPES WORK.

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            //Here, the array 'array1' is assigned to another variable called 'array2'.
            //When you then change the value of 'array2', in this instance, 
            //the index value of 0 has been changed from 1 to 0,
            //the index value of 0 on 'array1' also changes to 0.
            //this happens because arrays are examples of reference types and both variables in the stack,
            //they refer to the same address in the heap, hence when one is changed, the other also changes.
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));
            //THE ABOVE SHOWS US HOW REFERENCE TYES ACT.

            //

        }
    }
}
