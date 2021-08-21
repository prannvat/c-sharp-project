using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructors
{
    public class Customer
    {
        public int Id;
        public string Name;

        public Customer()
        {

        }
        public Customer(int id) //ctor is a code snippet for declaring a constructor.
        {
            this.Id = id;
        }
        public Customer(int id, string name)           
        {
            this.Id = id;
            this.Name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "John");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
