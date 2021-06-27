using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };
            // Length ~ Returns the size of the array
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf() ~ Use this method to find position of element in the array
            var index = Array.IndexOf(numbers, 9);
            // So the above finds the index value of 9 in the array.
            Console.WriteLine("Index of 9 :" + index);

            // Clear() ~ sets values you want in array to 0.
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            // Copy() ~ Copies array values that you wnat to copy into another array.
            var another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of Copy()");
            foreach (var n in another)
               Console.WriteLine(n);

            // Sort() ~ Sorts array.
            Array.Sort(numbers);
            Console.WriteLine("Effects of Sort(): ");
            foreach (var n in numbers)
                Console.WriteLine(n);

            // Reverse() ~ Reverses array, inverts it, from end to to start.
            Array.Reverse(numbers);
            Console.WriteLine("Effcets of Reverse(): ");
            foreach (var n in numbers)
                Console.WriteLine(n);

        }
    }
}
