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
    public partial class AddCategoryForm : Form
    {
        AppDbContext dbContext = new AppDbContext();
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string categoryName = CategoryNametxtBox.Text.Trim();
            if(!IsValidCategoryName(categoryName))
            {
                return;

            }
            Category newCategory = new Category
            {
                CategoryName = categoryName
            };
            dbContext.Categories.Add(newCategory);
            dbContext.SaveChanges();

            MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide(); 

        }
        private bool IsValidCategoryName(string categoryName)
        {
            // Check if the name is empty or whitespace
            if (string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBox.Show("Category name cannot be empty or whitespace.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }

            // Optional: Check for duplicate category name
            bool categoryExists = dbContext.Categories
                                    .Any(c => c.CategoryName.ToLower() == categoryName.ToLower());

            if (categoryExists)
            {
                MessageBox.Show("This category name already exists. Please choose a different name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; 
        }

       
        private void ResetForm()
        {
            CategoryNametxtBox.Clear();
            // Focus back on the category name text box for user convenience
            CategoryNametxtBox.Focus();
        }
    }
}
