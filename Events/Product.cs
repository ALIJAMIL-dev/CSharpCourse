using System;

namespace Events
{
    // Step 1: Define a delegate
    public delegate void StockControl();

    // Step 2: Create the Product class
    public class Product
    {
        private int _stock;

        // Event based on the delegate
        public event StockControl StockControlEvent;

        public string ProductName { get; set; }

        public int Stock
        {
            get => _stock;
            set
            {
                _stock = value;

                // Trigger the event when stock is low
                if (_stock < 10 && StockControlEvent != null)
                {
                    StockControlEvent(); // Fire the event
                }
            }
        }

        // Constructor
        public Product(string productName, int initialStock)
        {
            ProductName = productName;
            Stock = initialStock;
        }

        // Method to sell a product
        public void Sell(int amount)
        {
            if (_stock >= amount)
            {
                Stock -= amount;
                Console.WriteLine($"{amount} units sold. Current stock: {_stock}");
            }
            else
            {
                Console.WriteLine("Not enough stock to complete the sale.");
            }
        }
    }
}
