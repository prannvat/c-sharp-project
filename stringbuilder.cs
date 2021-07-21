using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder(); //<<You can assign a string value to StringBuilder in the brackets when assigning.


            //.Append = This adds whAt you tell it to add on the end of the string

            //.AppendLine = This adds a new line to the string.



            //builder.Append('-', 10);
            //builder.AppendLine();
            //builder.Append("Header");
            //builder.AppendLine();
            //builder.Append('-', 10);

            //The above is how you would think is the neatest way of using all these .Append methods.That is not the case, the better, more neater way is this:


            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10);

            //The above way of formatting can be used for all the methods.



            Console.WriteLine(builder);
            //Above returns this:

            //----------
            //Header
            //----------

            builder.Replace('-', '+');
            Console.WriteLine(builder);
            //.Replace = Replaces what you want in string with something else.
            //Above returns this:

            //++++++++++
            //Header
            //++++++++++

            //.Remove = This takes the index value of string as first argument, then how many characters after that you want to remove.
            builder.Remove(0, 10);
            Console.WriteLine(builder);
            //Above returns this:


            //Header
            //++++++++++

            //.Insert = Takes index as first argument then anything that you want to add on from that index onwards.
            builder.Insert(0, new string('-', 10));
            Console.WriteLine(builder);
            //Above returns this:

            //----------
            //Header
            //++++++++++

            //You can acces indexer with stringBuilder:
            Console.WriteLine(builder[0]);





        }
    }
}
