using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    // This is Abstract Class 
    abstract class AbstractClass
    {
        protected AbstractClass() 
        {
            Console.WriteLine("Abstract Class Constructor");
        }
    }
    // Summarize of Abstract Class is:
    // 1.Abstract Classes are using with Inheritance(Virtual Methods)
}
