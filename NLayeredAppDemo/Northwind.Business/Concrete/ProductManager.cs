using System;
using System.Collections.Generic;
using System.Linq;
using Northwind.Entities.Concrete;
using Northwind.DataAccess.Concrete;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class ProductManager
    {
        ProductDal _productDal = new ProductDal();
        public List<Product> GetAll()
        {
            //Business Code
            return _productDal.GetAll();
        }
    }
}
