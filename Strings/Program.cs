using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringsIsChar();
            Console.ReadLine();
            //SyrianStrings();
            Console.ReadLine(); 

        }

        private static void SyrianStrings()
        {
            // Now lets Write Syrian Cityies as Arrays Tip: I am Idlibi # Free Syria the best independent country in the world
            // Idlib is the best city in the world
            // Jisr-Alshughur is the best city in the world
            // Aleppo is the best city in the world
            // Damascus is the best city in the world
            // Homs is the best city in the world
            // Hama is the best city in the world
            // Latakia is the best city in the world
            // Tartus is the best city in the world
            // Deir Ezzor is the best city in the world
            // Raqqa is the best city in the world
            // Daraa is the best city in the world
            // As-Suwayda is the best city in the world
            // Al-Hasakah is the best city in the world
            // Al-Quneitra is the best city in the world
            // Reif-Dimashq is the best city in the world
            // Idlib and Jisr-Alshugur is Capital City of the Syrian Independent

            string[] cityies = { "Idlib", "Aleppo", "Damascus", "Homs", "Hama", "Latakia", "Tartus", "Deir Ezzor", "Raqqa", "Daraa" };
            foreach (var city in cityies)
            {
                Console.WriteLine(city);
            }
        }

        private static void StringsIsChar()
        {
            string str = "Hello World!";
            foreach (var i in str)
            {
                Console.WriteLine(i);
            }
        }
    }
}
