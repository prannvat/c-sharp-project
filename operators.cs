using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            Console.WriteLine(a + b);
            //the above is simple and self explanatory, just adding tow variables together #
            //using + operator.

            var num1 = 20;
            var num2 = 6;
            Console.WriteLine((float)num1 / (float)num2);
            // As the above two variables are assigned as integers initiall,
            // you need to cast them into float in this case or it will return an integer,
            // even though 20 / 6 is a float, hence the floatin barckets beforehand.

            var num3 = 1;
            var num4 = 2;
            var num5 = 3;
            Console.WriteLine( num3 + num4 * num5);
            //bidmas rules apply here too, so use parenthesis if you want to add before multiply etc.

            Console.WriteLine(a > b);
            //Comaparison operators return value of true or false,
            //in this case 'a' is 10 and 'b' is 3 so it returns true as a > b.

            Console.WriteLine(!(a != b));
            //above has two NOT operators so double negative, 
            //what this means is that if a is not = to b then you apply a NOT to that to make it false.
            //basically, you get same result as if it was checking if a == b

            Console.WriteLine(num5 > num4 && num5 > num3 );
            //above is a logical operator, 
            //it checks that if both conditions are true then it returns true value, otherwise a false.

            Console.WriteLine(num5 > num4 || num5 == num3);
            //above uses OR operator and checks thatif either one of the conditions are treu then it returns true.

        }
    }
}
