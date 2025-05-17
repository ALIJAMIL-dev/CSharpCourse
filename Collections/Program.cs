using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ArrayList();

            // ListOff();

            // ClassList();

            // DictList();

            Console.ReadLine();
        }

        private static void DictList()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("MC", "Minecraft latest version");
            dict.Add("BwV", "Bedwars MC 1.8.9 or Lunar Client");
            dict.Add("1.4", "April Fools! hahahaahaaha");

            // Console.WriteLine(dict["BwV"]);
            // Console.WriteLine(dict["1.4"]);

            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }
        }

        private static void ClassList()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, Name = "AliJamil" });
            customers.Add(new Customer { Id = 2, Name = "Mc1.8.9" });

            foreach (var item in customers)
            {
                Console.WriteLine(item);
            }
        }

        private static void ListOff()
        {
            List<string> cities = new List<string>();
            cities.Add("Idlib");
            cities.Add("Aleppo");
            cities.Add("Hama");
            cities.Add("Damascus");
            cities.Add("Homs");

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            // Let's Add All Syrian Regions
            cities.Add("Idlib");
            cities.Add("Aleppo");
            cities.Add("Hama");
            cities.Add("Homs");
            cities.Add("Damascus");

            cities.Add(1);

            foreach (string item in cities)
            {
                Console.WriteLine(item);
            }
        }

        class Customer
        {
            public string Name { get; set; }
            public int Id { get; set; }
        }
    }
}
