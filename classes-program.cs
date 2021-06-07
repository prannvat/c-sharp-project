
using classes.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var prannvat = new Person();
            prannvat.FirstName = "Prannvat";
            prannvat.LastName = "Singh";
            prannvat.Introduce();
            //you want one class per file or it can get too chaotic
            //so you move each file to separate files.

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
            //USING THE CALCULATOR CLASS.

        }

    }
}
