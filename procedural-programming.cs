using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procedural_programming
{
     internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's your name? ");
            var userName = Console.ReadLine();
            var reversed = ReverseName(userName);
            Console.WriteLine("Reversed name: " + reversed);

            
        }

        public static string ReverseName(string userName)
        {
            var array = new char[userName.Length];
            for (var i = userName.Length; i > 0; i--)
                array[userName.Length - i] = userName[i - 1];

            return new string(array);
            
        }
    }
}
