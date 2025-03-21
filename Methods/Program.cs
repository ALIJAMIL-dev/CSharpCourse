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
        // Main Method + Use Point
        static void Main(string[] args)
        {
            //Add1();
            //Add1();
            //Add1();
            //var result = Add(10, 25);

            //int number1;
            //int number2 = 100;
            //var result = Add3(out number1, number2);
            //Console.WriteLine(result);
            //Console.WriteLine(number1);
            Console.WriteLine(Multiply(5, 2));
            Console.WriteLine(Multiply(5, 2, 3));
            Console.ReadLine();
        }
        // First Method
        static void Add1()
        {
            Console.WriteLine("Added!");
        }
        // Now About Default Values
        static int Add(int number1 = 10, int number2 = 1)
        {
            var result = number1 + number2;
            return result;
        }
        // Now About Challenge Ref and Out Keyword
        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        // Now About Method Overloading
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        //Now About Params Keyword
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
