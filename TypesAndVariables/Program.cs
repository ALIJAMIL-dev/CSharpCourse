using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {   int number1 = 2147483647; // 2^31
            long number2 = 2147483648; // 2^32
            short number3 = 32767; // -32768 - 32767
            byte number4 = 255; // 0-255
            bool condition = true; // True or False
            char character = 'A'; // Unicode character
            double number5 = 10.4; // 64 bit
            decimal number6 = 19.4m; // 128 bit
            var number7 = 10; // int
            number7 = 'A'; // Unicode value of A is 65

            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine("Condition is {0}", condition);
            Console.WriteLine("Character is {0}", character);
            Console.WriteLine(Days.Friday);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
