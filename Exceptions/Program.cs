using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TryCatch();
            Func<int, int, int> add = Sum;

            Console.WriteLine(add(3, 5));
            Console.ReadLine();
        }

        public static int Sum(int x, int y)
        {
            return x + y;
        }

        private static void TryCatch()
        {
            // ExceptionsIntro();

            // Find();

            try
            {
                Find();
            }
            catch (RecordNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void Find()
        {
            List<string> students1 = new List<string>
            {
                "Engin", "Derin", "Salih"
            };

            if (!students1.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("RecordNotFound!");
            }
            else
            {
                Console.WriteLine("Record Found");
            }
        }

        private static void ExceptionsIntro()
        {
            try
            {
                string[] students = new string[3]
                {
                "Engin", "Derin", "Salih"
                };
                students[3] = "Ahmet";
            }
            catch (IndexOutOfRangeException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception {0}", ex.Message);
            }
        }
    }
}
