using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete.NHibernate
{
    public class NHProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>
            {
                new Product{
                    CategoryId = 1,
                    ProductId = 1,
                    ProductName = "Laptop",
                    QuantityPerUnit = "1 unit",
                    UnitPrice = 1000,
                    UnitsInStock = 11
                }
            };
            return products;
        }

        public Product Get(int Id)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
