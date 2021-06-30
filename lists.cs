using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            //.Add() ~ adds an object in the list.
            numbers.Add(1);

            //.AddRange() ~ adds another list/array of objects to the list.
            numbers.AddRange(new int[3] { 5, 6, 7 });
            foreach (var number in numbers)
                Console.WriteLine(number);
            //We already know what theh above does, simple foreach loop to display 'numbers' list.

            //.IndexOf() ~returns index of object you want in the list.
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            //We know that the 'numbers' list has two '1's in the list, but when we want to find the index of 1, it returns the index of the 1 that comes first.
            //If we want the last 1's index, we can do the below.
            //.LastIndexOf() ~ searches list from the end of the list, instead of the start.
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));

            //.Count() ~ returns numbers of objects in list
            Console.WriteLine("Count:" + numbers.Count());

            //.Remove() ~ removes the wanted object from the list.
            numbers.Remove(1);
            foreach (var number in numbers)
                Console.WriteLine(number);
            //However, the .Remove() only removes the first '1' in this case.
            //If we wanted to remove all the 1s we would do the below.
            for (var i = 0; i<numbers.Count();i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }
            foreach (var number in numbers)
                Console.WriteLine(number);

            //.Clear() ~ removes all element from list.
            numbers.Clear();
            Console.WriteLine("Count:" + numbers.Count()); 
            //this returns 0.








        }
    }
}
