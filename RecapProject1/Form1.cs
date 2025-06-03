using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProducts();
        }

        private void LoadProducts()
        {
            using (NorthWindContext context= new NorthWindContext())
            {
                dgvProducts.DataSource = context.Products.ToList();
            }
        }
        private void LoadProductsByCategories(int categoryId)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                dgvProducts.DataSource = context.Products.Where(p=>p.CategoryId==categoryId).ToList();
            }
        }
        private void LoadProductsByProductName(string key)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                dgvProducts.DataSource = context.Products.Where(p => p.ProductName.ToLower().Contains(key.ToLower())).ToList();
            }
        }
        private void LoadCategories()
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                cbxCategory.DataSource = context.Categories.ToList();
                cbxCategory.DisplayMember = "CategoryName";
                cbxCategory.ValueMember = "CategoryId";
            }
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadProductsByCategories(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string key = tbxSearch.Text;
            if (string.IsNullOrEmpty(key))
            {
                LoadProducts();
            }
            else
            {
                LoadProductsByProductName(key);
            }
        }
    }
}
