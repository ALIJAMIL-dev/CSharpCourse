using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                ID = 1,
                FirstName = "Engin",
                LastName = "Demiroğ",
                Address = "Ankara"
            };
            manager.Add(customer);
            Console.ReadLine();
        }
        interface IPerson
        {
            int ID { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }

        }
        class Customer : IPerson
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
        }
        class Student : IPerson
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant { get; set; }

        }
        class Teacher : IPerson
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Branch { get; set; }
        }
        class PersonManager
        {
            public void Add(Customer customer)
            {
                Console.WriteLine(customer.FirstName);
            }
        }
        class SchoolManager
        {
            // Students
            public void Add(Student student)
            {
                Console.WriteLine(student.FirstName);
            }
            // Teachers
            public void Add(Teacher teacher)
            {
                Console.WriteLine(teacher.FirstName);
            }
        }
    }
}
