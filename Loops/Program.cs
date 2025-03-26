using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForEachLoop();

            if (PrimeNumber(11))
            {
                Console.WriteLine("This is a Prime Number");
            }
            else
            {
                Console.WriteLine("This is not a Prime Number");
            }
            Console.ReadLine();
            // Now We will see the Prime Number Program
        }
        private static bool PrimeNumber(int number1)
        {
            bool result = true;
            for (int i = 2; i < number1-1; i++)
            {
                if (number1 % i == 0)
                {
                    result = false;
                    i = number1;
                }
            }
            return result;
        }
        private static void ForEachLoop()
        {
            string[] students2 = { "Ali", "John", "Jack" };
            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
        }

        private static void WhileLoop()
        {
            int number = 1000;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
        }

        private static void ForLoop()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
