using Inventory_Management__System.Data;
using Inventory_Management__System.Models;
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

    public partial class AddProductForm : Form
    {
        AppDbContext dbContext = new AppDbContext();
        public AddProductForm()
        {
            InitializeComponent();
            FillCategoryComboBox();
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
            CategoryComboBox.DisplayMember = "CategoryName";
            CategoryComboBox.ValueMember = "CategoryID";
            CategoryComboBox.DataSource = categories;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!IsValidProduct())
            {
                return;
            }
            var productName = ProductNametxtBox.Text;
            decimal.TryParse(PriceUpDownBox.Text, out decimal price);
            var categoryId = Convert.ToInt32(CategoryComboBox.SelectedValue); ;
            var description = DescriptionTextBox.Text;
            Product product = new Product
            {
                ProductName = productName,
                SellingPrice = price,
                CategoryID = categoryId,
                Description = description
            };
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();

        }
        private bool IsValidProduct()
        {
            // Check if the Product Name is not empty
            if (string.IsNullOrWhiteSpace(ProductNametxtBox.Text))
            {
                MessageBox.Show("Product Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the Price is a valid decimal and greater than zero
            if (!decimal.TryParse(PriceUpDownBox.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if a Category is selected
            if (CategoryComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the Description is not empty
            if (string.IsNullOrWhiteSpace(DescriptionTextBox.Text))
            {
                MessageBox.Show("Description is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }
    }
}
