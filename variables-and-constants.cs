using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables_and_constants
{
    class Program
    {
        static void Main(string[] args)
        {

            //The keyword 'var' can be used intead of all these datatypes and the c# compiler automatically detects datatype for you, 
            //it will detect integral numbers as integer instead of byte but usually that is fine.      
            byte number = 2;        
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Prannvat";
            bool isWorking = false;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);



        }
    }
}
