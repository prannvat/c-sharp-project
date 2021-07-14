using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings_advance
{
    class Program
    {
        static void Main(string[] args)
        {
              
            var fullName = "Prannvat Singh ";
            //                            ^
            //Notice that the above has a whitespace in the string.(^ indicates where)
            //Trim() = Gets rid of whitespace at the beginning or end of a string.
            Console.WriteLine("Trim: '{0}'", fullName.Trim());

            //ToUpper() = "PRANNVAT SINGH ":
            Console.WriteLine("ToUpper: '{0}'", fullName.ToUpper());

            //ToLower() = "prannvat singh ":
            Console.WriteLine("ToLower: '{0}'", fullName.ToLower());

            Console.WriteLine("Trim & ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);
            //In the above, we have created two substrings of the string fullName to split the first and last name.
            //There is an easier way to do the abpve, that is by using the split method:
            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            fullName.Replace("Prannvat", "Pavi");
            fullName.Replace("a", "A");
            Console.WriteLine(fullName);
            //An error has been made above.
            //The .Replace method has been used in an attemp to replace parts of the string with a different set of charcters.
            //However, when you try to display the string after the changes, the string doesn't change.
            //This is because strings are immutable hence cannot be modified, however like we have done everywhere else above,
            //they can be copied and a new copy of that string can be modified.
            //Hence what we have to do is this:
            Console.WriteLine(fullName.Replace("Prannvat", "Pavi"));  //This returns "Pavi Singh"
            Console.WriteLine(fullName.Replace("a", "A"));            //This returns "PrAnnvAt Singh"

            //Checking if string actually has anything in it (useful for real world code e.g if you are programming a form that needs to be filled etc.):

            if (String.IsNullOrEmpty(""))
                Console.WriteLine("Invalid");
            //The above works and as the string is empty, the invalid message is returned.
            //However down below this does not work:
            if (String.IsNullOrEmpty(" "))
                Console.WriteLine("Invalid");
            //If you notice, there is a space in the string in this case, so even though we know that that is invalid, according to the programme, the string is not null or empty.
            //In this case, we can use the below:
            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");
            //This checks if the string is null or whitespace.



            //Conversion:

            var str = "25";
            var age = (Convert.ToInt32(str));  //Pretty self-explanatory. It would be practical to use ToByte in this case instead of ToInt32 because int is 4 bytes and we only need 1 byte for age.(No one is older that 250)
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C")); 
            //There are several conversion keys, the "C" is for currency. They are very simple.
            











        }
    }
}
