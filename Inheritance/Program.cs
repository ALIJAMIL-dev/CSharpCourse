using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3];
            {
                new Customer
                {
                    ID = 1,
                    FirstName = "Engin",
                    LastName = "Demirog"
                };
                new Student
                {
                    ID = 2,
                    FirstName = "I don't",
                    LastName = "love the school",
                    StudentNumber = "S12345"
                };
                new Person
                {
                    ID = 3,
                    FirstName = "Ali",
                    LastName = "Jamil"
                };
            }
        }
    }
    class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
    }
    class Student : Person
    {
        public string StudentNumber { get; set; }
    }
}
