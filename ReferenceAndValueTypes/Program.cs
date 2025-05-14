using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 19;
            num1 = num2;
            num2 = 39;
            Console.WriteLine(num2);

            Console.ReadLine();

        }
    }
}
