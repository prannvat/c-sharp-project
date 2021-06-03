using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace type_conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;   //int is 4 bytes and byte is just one byte so can be converted easily.
            int i = b;
            Console.WriteLine(i);
            // above was implicit conversion.

            int num = 3;
            byte x = (byte) num;
            Console.WriteLine(x);
            //int to byte can cause data loss as int has more bytes,
            //so you must cast int to byte by telling compiler you want this change.
            //above was explicit conversion.

            string number = "1234"; //could use 'var' keyword instead of 'string'.
            int newNum = Convert.ToInt32(number);
            Console.WriteLine(newNum);
            //above was a non compatible coversion as it was string to int, thus use convert keyword.
            // have to keep overflowing in mind, because datatypes have certain limits of values they can store.
            // for example byte goes form 0 to 255.

        }
    }
}
