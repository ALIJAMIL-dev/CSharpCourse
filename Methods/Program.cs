using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add1();
            Add1();
            Add1();
            var result = Add(10, 25);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static void Add1()
        {
            Console.WriteLine("Added!");
        }
        static int Add(int number1 = 10, int number2 = 1)
        {
            var result = number1 + number2;
            return result;
        }
        
    }
}
