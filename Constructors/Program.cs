using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);
            customerManager.List();
            Product product = new Product(id: 1, name: "A");

            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());
            employeeManager.Add();


            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        private int _count;
        public CustomerManager(int count)
        {
            _count = count;
        }
        public void List()
        {
            Console.WriteLine("Listed {0} items.", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }
    class Product
    {
        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

    }
    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database!");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to FileLogger!");
        }
    }
    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public ILogger Logger { get; set; }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }
    }
    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {

        }
    }
    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)
        {
        }
    }
}
