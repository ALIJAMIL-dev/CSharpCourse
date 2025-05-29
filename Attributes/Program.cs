using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                LastName = "Doe",
                Age = 30
            };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }
    }
    [ToTable("Customers")]
    public class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }

    public class CustomerDal
    {
        [Obsolete("Don't use Add, instead use AddNew Method!")]
        public void Add(Customer customer)
        {
            // Simulate adding a customer to a database
            Console.WriteLine($"Customer {customer.FirstName} {customer.LastName} added successfully.");
        }
        public void AddNew(Customer customer)
        {
            // Simulate adding a customer to a database
            Console.WriteLine($"Customer {customer.FirstName} {customer.LastName} added successfully.");
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class RequiredPropertyAttribute : Attribute
    {

    }
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class ToTableAttribute : Attribute
    {
        private string v;

        public ToTableAttribute(string v)
        {
            this.v = v;
        }
    }
}

