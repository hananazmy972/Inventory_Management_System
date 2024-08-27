using Inventory_Management__System.Data;
using Inventory_Management__System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management__System
{
    public partial class InventoryForm : Form
    {
        AppDbContext dbContext = new AppDbContext();
        public InventoryForm()
        {
            InitializeComponent();
            FillCategoryComboBox();
            LoadInventoryData();
        }

        private List<object> GetProductInStock(int? categoryId = null)
        {

            var query = dbContext.Inventories.AsQueryable();

            if (categoryId.HasValue)
            {
                query = query.Where(i => i.Product.CategoryID == categoryId.Value);
            }

            var productsInStock = query
                .Select(i => new
                {
                    ID = i.InventoryID,
                    ProductName = i.Product.ProductName,
                    CategoryName = i.Product.Category.CategoryName,
                    Quantity = i.Quantity
                })
                .ToList<object>();

            return productsInStock;
        }
        private void LoadInventoryData(int? categoryId = null)
        {
            // First, get the data from the database into a local list.
            List<object> productsInStock = GetProductInStock(categoryId);

            // Set the DataSource of the DataGridView to the list.
            StockGridView.DataSource = productsInStock;
        }

        private void FillCategoryComboBox()
        {
            var categories = dbContext.Categories
                            .Select(c => new Category
                            {
                                CategoryID = c.CategoryID,
                                CategoryName = c.CategoryName
                            })
                            .ToList();

            categories.Insert(0, new Category { CategoryID = 0, CategoryName = "All Categories" });

            CategoryComboBox.DisplayMember = "CategoryName";
            CategoryComboBox.ValueMember = "CategoryID";
            CategoryComboBox.DataSource = categories;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update the data grid view to display slected category products
            int selectedCategoryId = (int)CategoryComboBox.SelectedValue;

            if (selectedCategoryId == 0)
            {
                LoadInventoryData();
            }
            else
            {
                // Load data for the selected category
                LoadInventoryData(selectedCategoryId);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadInventoryData();
        }

        private void btnLowStock_Click(object sender, EventArgs e)
        {
            var currentDataSource = StockGridView.DataSource as List<object>;
            if (currentDataSource != null)
            {
                var lowStockData = currentDataSource.Where(item => ((dynamic)item).Quantity <= 10).ToList();
                StockGridView.DataSource = lowStockData;
            }
            else
            {
                MessageBox.Show("No data to sort.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            //sort tha data that currently in data gridview by quantity
            var currentDataSource = StockGridView.DataSource as List<object>;
            if (currentDataSource != null)
            {
                var sortedData = currentDataSource.OrderBy(item => ((dynamic)item).Quantity).ToList();
                StockGridView.DataSource = sortedData;
            }
            else
            {
                MessageBox.Show("No data to sort.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BackHomePictureBox_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }


    }
}
