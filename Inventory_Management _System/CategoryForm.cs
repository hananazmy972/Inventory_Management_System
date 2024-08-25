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
           // ClearBindings();
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
                    Delete_Category(selectedCategory); // Pass the ID of the selected category
                    LoadData();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm();
            addCategoryForm.ShowDialog();
            LoadData(); 

        }
    }
}
