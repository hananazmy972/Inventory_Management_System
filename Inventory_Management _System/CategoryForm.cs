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
    public partial class CategoryForm : Form
    {
        BindingSource source;
        public event Action DataUpdated;
        AppDbContext dbContext = new AppDbContext();
        public CategoryForm()
        {
            InitializeComponent();
            LoadData();


        }

        private void CategoryIDtxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CategoryNametxtBox_TextChanged(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            CategoryGridView.AutoGenerateColumns = false; // Prevents automatic generation of columns
            CategoryGridView.Columns.Clear();

            // Define and add columns manually
            var idColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CategoryID",
                HeaderText = "Category ID",
                Name = "CategoryID"
            };

            var nameColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CategoryName",
                HeaderText = "Category Name",
                Name = "CategoryName"
            };

            CategoryGridView.Columns.Add(idColumn);
            CategoryGridView.Columns.Add(nameColumn);

            CategoryGridView.SelectionChanged -= CategoryGridView_SelectionChanged;
            CategoryGridView.DataSource = GetCategories();
            ClearBindings();
            if (source == null)
            {
                source = new BindingSource();
            }
            source.DataSource = typeof(Category);
            CategoryIDtxtBox.DataBindings.Add("Text", source, "CategoryID");
            CategoryNametxtBox.DataBindings.Add("Text", source, "CategoryName");

            CategoryGridView.SelectionChanged += CategoryGridView_SelectionChanged;
        }

        public List<Category> GetCategories()
        {
            //return all categories 
            var categories = dbContext.Categories
                              .Select(c => new Category
                              {
                                  CategoryID = c.CategoryID,
                                  CategoryName = c.CategoryName
                              })
                              .ToList();
            return categories;

        }
        private void CategoryGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (CategoryGridView.SelectedRows.Count > 0)
            {
                var selectedMember = (Category)CategoryGridView.SelectedRows[0].DataBoundItem;
                source.DataSource = selectedMember;
            }
        }
        private void ClearBindings()
        {
            CategoryIDtxtBox.DataBindings.Clear();
            CategoryNametxtBox.DataBindings.Clear();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show(text: "Confirm Delete", caption: "", buttons: MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (source.Current != null)
                {
                    var selectedCategory = (Category)source.Current;
                    Delete_Category(selectedCategory);
                    LoadData();
                    ClearBindings();
                }
                else
                {
                    MessageBox.Show("Please select a record to delete.");
                }
            }
        }

        private void Delete_Category(Category category)
        {

            dbContext.Categories.Remove(category);
            dbContext.SaveChanges();

        }
        private void Update_Category(int categoryId, string newCategoryName)
        {
            var category = dbContext.Categories.SingleOrDefault(c => c.CategoryID == categoryId);
            if (category != null)
            {
                // Update the category's name
                category.CategoryName = newCategoryName;
                dbContext.SaveChanges();
                MessageBox.Show("Category updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Category not found. Please check the category ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(text: "Confirm Update", caption: "", buttons: MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (int.TryParse(CategoryIDtxtBox.Text, out int categoryId) && !string.IsNullOrWhiteSpace(CategoryNametxtBox.Text))
                {
                    string newCategoryName = CategoryNametxtBox.Text;
                    Update_Category(categoryId, newCategoryName);
                    LoadData();
                    source.ResetBindings(false);//Reset the bindings to reflect updated data
                }
                else
                {
                    MessageBox.Show("Please enter a valid Category Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm();
            addCategoryForm.ShowDialog();
            LoadData();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void SearchName_TextChanged(object sender, EventArgs e)
        {
            var name = SearchName.Text.Trim();
            var filteredCategories = dbContext.Categories
                                      .Where(c => c.CategoryName.Contains(name))
                                      .Select(c => new Category
                                      {
                                          CategoryID = c.CategoryID,
                                          CategoryName = c.CategoryName
                                      })
                                      .ToList();
            CategoryGridView.DataSource = null; // Reset the DataSource first
            source.DataSource = filteredCategories; // Set the filtered list to the BindingSource
            CategoryGridView.DataSource = source; // Set the DataGridView's DataSource to BindingSource

            // Clear current selection
            CategoryGridView.ClearSelection();
       
        }
    }
}
