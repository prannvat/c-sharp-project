using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Prannvat";
            var lastName = "Singh";

            var fullName = firstName + " " + lastName;
            //here we have concatenated the first two strings to give fullName string.

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            //used the .format .

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);
            //this displays the values in the 'names' array
            // it combines the values in the array using the seperator that is the ",".

            var text = "Hi Prannvat\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3";
            //as you need to use dobule backslash to represent a backlash, it can become very unreadable
            //hence yoyu can use verbatim string.
            // "\n is used for a new line.
            Console.WriteLine(text);
            var text2 = @"Hi Prannvat
Look into the following paths
c:\folder1\folder2
c:\folder3";
            Console.WriteLine(text2);
            //with verbatim string, you simply add an @ befor ethe string,m then you don't need the \n,
            // or the dobles backslash, you cna just use a new line by pressing enter like normal, 
            //and for the backslash, you only need to type one, not two.
            //this makes the code much more readable.
            //henec when you need to use new lines or backslashes etc, use verbatim string.
        }
    }
}
