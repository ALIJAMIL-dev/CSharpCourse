using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays 
            // string student1 = "John";
            // Ali is my name
            // string student2 = "Ali";
            // string student3 = "Jack";
            //string[] students = new string[3];
            //students[0] = "John";
            //students[1] = "Ali";
            //students[2] = "Jack";

            //string[] students2 = {"Ali", "John", "Jack"}; // or string[] students2 =
            // new [] {"Ali", "John", "Jack"};

            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}

            //foreach (var student1 in students2)
            //{
            //    Console.WriteLine(student1);
            //}

            string[,] TurkeyRegions = new string[5, 3]
            {
                {"Istanbul", "Izmit", "Balikesir"},
                {"Ankara", "Konya", "Kirikkale"},
                {"Antalya", "Adana", "Hatay"},
                {"Rize", "Trabzon", "Samsun"},
                {"Erzurum", "Kars", "Agri"}
            };

                for (int i = 0; i <= TurkeyRegions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= TurkeyRegions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(TurkeyRegions[i, j]);
                }
                Console.WriteLine("*************************");
            }
        

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
