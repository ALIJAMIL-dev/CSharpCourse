using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                FirstName = "Me",
                LastName = "You",
                City = "He",
                Id = 1
            };

            Customer customerClone = (Customer)customer.Clone();
            customerClone.FirstName = "The";
            customerClone.LastName = "GOAT";
            customerClone.City = "'Cristiano Ronaldo 7'";

            Console.WriteLine($"Customer: {customer.FirstName} {customer.LastName} {customer.City}");
            Console.WriteLine($"The truth: {customerClone.FirstName} {customerClone.LastName} is {customerClone.City}");

            Console.ReadLine();
        }
    }

    public abstract class Person
    {
        public abstract Person Clone();

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    public class Customer : Person
    {
        public string City { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }

    public class Employee : Person
    {
        public decimal Salary { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
}
