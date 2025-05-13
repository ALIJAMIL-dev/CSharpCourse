using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Customer
    {
        protected int Id1;
  
        public int id;
    }
    class Student
    {
        public void Save()
        {
            Customer customer = new Customer();
            // customer.id;
        }
    }
    public class Course
    {
        public int Id;
        public int Name;
        public void Save()
        {
            Console.WriteLine("Saved");
        }
    }
}
