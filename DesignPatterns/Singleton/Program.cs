using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customerManager = CustomerManager.CreateAsSingleton();
            customerManager.AddCustomer("John Doe");
        }
    }

    class CustomerManager
    {
        static object _lockObject = new object();
        private static CustomerManager _customerManager;
        public CustomerManager()
        {

        }
        public static CustomerManager CreateAsSingleton()
        {
            lock (_lockObject)
            {
                if (_customerManager == null)
                {
                    _customerManager = new CustomerManager();
                }
            }
            return _customerManager;
        }
        public void AddCustomer(string customerName)
        {
            Console.WriteLine("Customer added: " + customerName);
        }
    }
}
