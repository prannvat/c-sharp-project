using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugging_tools
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var smallests = GetSmallests(numbers, 3);

            foreach (var number in smallests)
                Console.WriteLine(number);

        }
        public static List<int> GetSmallests(List<int> list, int count)
        //For clearance, in this code we are using two methods which have very similar names: 'GetSmallests' and 'GetSmallest'.
        //This is not a good thing to do because this can cause confusion and lead to more problems in your code and make it harder to debug.
        {
            var smallests = new List<int>();
            
            while (smallests.Count < count)
            {
                var min = GetSmallest(list);
                smallests.Add(min);
                list.Remove(min);
            }

            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            // Assume the first number is the smallest
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                //if (list[i] > min)
                    min = list[i];

            }
            return min;
        }
    }
}
