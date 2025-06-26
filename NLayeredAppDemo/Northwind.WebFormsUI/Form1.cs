using Northwind.Business.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;

namespace Northwind.WebFormsUI
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            _productService = new ProductManager(new EFProductDal());
            _categoryService = new CategoryManager(new EFCategoryDal());
        }

        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategorySearch.DataSource = _categoryService.GetAll();
            cbxCategorySearch.DisplayMember = "CategoryName";
            cbxCategorySearch.ValueMember = "CategoryId";

            cbxAddCategoryID.DataSource = _categoryService.GetAll();
            cbxAddCategoryID.DisplayMember = "CategoryName";
            cbxAddCategoryID.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgvProducts.DataSource = _productService.GetAll();
        }

        private void cbxCategorySearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvProducts.DataSource = _productService.GetAllByCategory(Convert.ToInt32(cbxCategorySearch.SelectedValue));
            }
            catch
            {

            }

        }

        private void tbxNameSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxNameSearch.Text))
            {
                dgvProducts.DataSource = _productService.GetAllByName(tbxNameSearch.Text);
            }
            else
            {
                LoadProducts();
            }
        }

        private void gbxProductAdd_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {
                CategoryId = Convert.ToInt32(cbxAddCategoryID.SelectedValue),
                ProductName = tbxAddProductName.Text,
                UnitPrice = Convert.ToDecimal(tbxAddUnitPrice.Text),
                QuantityPerUnit = tbxAddQuantityPerUnit.Text,
                UnitsInStock = Convert.ToInt16(tbxAddStock.Text)

            });
            MessageBox.Show("Product Added Successfully!");
            LoadProducts();
        }
    }
}
