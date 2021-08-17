using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_intermediate_intro
{
    public class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }
            
        public  static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }

    class Program
    {
            static void Main(string[] args)

            {
                    var person = Person.Parse("John");
                    person.Introduce("Prannvat");
            }       
                               
            // Class - A building block of an application
            //In the real world, an application consists of multiple classes, each responsible for a particular behaviour in the application
            //Anatomy of a Class:
            //- Data(represented by fields)
            //- Behaviour(represented by methods/funtions)
            // An object is an instance of a class that resides in the memory.
        }
    }

    //Declaring a class:
    public class Human
    {
        // Declaring a member - we refer to fields and methods of a class as memebers of the class:
        // In real world we shouldn't declare fields using 'public' - thsi is just to keep it simple for now.
        public string Name;

        //Declaring methods in a class:
        //void means that method doesn't return a value
        public void Introduce()//we can out parameters iside the identifier of a methods.
        {
            Console.WriteLine("Hi my name is" + Name);
        }
        //Now we have a class, lets see how we can create an object or an instance from it:
         Human human = new Human();
        //person.Name = "Mosh";
        //person.Introduce()

    }
    //Class members:
    //Instance member - accessible from an object:
   
    //var person = new Person();
    //person.Introduce()

    //Static member - accessible from the class
    //Why use static members?
    //-To represent concepts that are singleton
    // eg. DateTime.Now and Console.WriteLine()


   
}
