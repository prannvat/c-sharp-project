using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_class
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var buffer = new char[10];
            for (var i = 0; i < 10; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));
            //A few blocks of code below, we can see we use the ASCII values 97-122 to use alphabets.
            //For someone tha doesn't know this we use the above.
            //We know that alphabet has 26 letters and as the 'a' is a character,internally it is stored as a number
            //Which is the ASCII value 97.
            //hence the adding of '0,26' makes it simple for everyone to read and also uses the number value of the alphabet.


            var password = new string(buffer);
            Console.WriteLine(password);
            for (var i = 0; i < 10; i++)
                Console.WriteLine(random.Next(1, 10));
            for (var i = 0; i < 10; i++)
                Console.WriteLine((char)random.Next(97, 122));
            //Pretty self explanatory, the random class above generates random numbers between 1 and 10 10 times.
            //It generatres 10 numbes because it is in a for loop that runs 10 times.


        }
    }
}
