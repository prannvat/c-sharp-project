using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1, 
        RegisiteredAirMail = 2,
        Express = 3

    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);
            //you can use casting to convert an integer to the enum,
            //in  this case the 'ShippingMethod'
            //in this case the value 'Express' is returned.

            Console.WriteLine(method.ToString());
            //the above converts the enum into a string, so the method is converted into string.
            //this returns 'Express' and it is a string.
            //Console.WriteLine always calls the .ToString method so you don't need to type it,
            //while using Console.WriteLine.

            var methodName = "Express";
            //Parsing is what you call converting a string into a different data type.
            //Here we are going to parse the string into a ShippingMethod.
           var shippingMethod =  (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName); 

        }
    }
}
