using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductDirector director = new ProductDirector();
            var builder = new NewCustomerProductBuilder();
            director.GenerateProduct(builder);
            var model = builder.GetModel();

            Console.WriteLine($"Product: {model.ProductName}, Price: {model.UnitPrice:C}, Discounted Price: {model.DiscountedPrice:C}, Discount Applied: {model.DiscountApplied}");
        }
    }

    public class ProductViewModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountedPrice { get; set; }
        public bool DiscountApplied { get; set; }
    }

    abstract class ProductBuilder
    {
        public abstract void GetProductData();
        public abstract void ApplyDiscount();
        public abstract ProductViewModel GetModel();
    }

    class NewCustomerProductBuilder : ProductBuilder
    {
        ProductViewModel Model = new ProductViewModel();

        public override void ApplyDiscount()
        {
            Model.DiscountApplied = true;
            Model.DiscountedPrice = Model.UnitPrice * (decimal)0.90;
        }

        public override void GetProductData()
        {
            Model.Id = 1;
            Model.CategoryName = "Electronics";
            Model.ProductName = "Smartphone";
            Model.UnitPrice = 699;
        }

        public override ProductViewModel GetModel()
        {
            return Model;
        }
    }

    class OldCustomerProductBuilder : ProductBuilder
    {
        ProductViewModel Model = new ProductViewModel();

        public override void ApplyDiscount()
        {
            Model.DiscountApplied = true;
            Model.DiscountedPrice = Model.UnitPrice;
        }

        public override void GetProductData()
        {
            Model.Id = 1;
            Model.CategoryName = "Electronics";
            Model.ProductName = "Smartphone";
            Model.UnitPrice = 699;
        }

        public override ProductViewModel GetModel()
        {
            return Model;
        }
    }

    class ProductDirector
    {
        public void GenerateProduct(ProductBuilder builder)
        {
            builder.GetProductData();
            builder.ApplyDiscount();
        }
    }
}
