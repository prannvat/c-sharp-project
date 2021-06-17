using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
            //the above and below code blcons do the same thing, one is a for loop, one is a while loop.
            //Pretty self-explanatory pieces of code.
            var n = 0;
            while (n <= 10)
            {
                if (n % 2 == 0)
                    Console.WriteLine(n);
                n++;
            }
               
            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    break;
                Console.WriteLine("@Echo: " + input);
                

                
            }
        }
    }
}
