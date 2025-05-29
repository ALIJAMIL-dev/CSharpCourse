using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<String>("Idlib", "Hama", "Aleppo", "Homs");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName = "Engin" }, new Customer { FirstName = "Derin" });
            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }

            Console.ReadLine();

        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    public class Product
    {

    }

    public class Customer
    {
        public string FirstName { get; set; }
    }

    public class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    public class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }

    interface IProductDal : IRepositry<Product>
    {

    }

    interface ICustomerDal : IRepositry<Customer>
    {

    }

    interface IRepositry<T>
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
