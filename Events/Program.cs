using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Program
    {
        public static void StockAlert()
        {
            Console.WriteLine("⚠️ WARNING: Stock is below the threshold!");
        }
        static void Main(string[] args)
        {
            // Create a product
            Product product = new Product("Laptop", 15);

            // Subscribe to the event
            product.StockControlEvent += StockAlert;

            // Simulate selling products
            product.Sell(3);  // 12 left
            product.Sell(2);  // 10 left
            product.Sell(1);  // 9 left — event should trigger

            Console.ReadLine(); // Wait for user input before closing
        }
    }
}
