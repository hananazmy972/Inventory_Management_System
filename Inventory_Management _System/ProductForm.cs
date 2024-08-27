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
    public partial class ProductForm : Form
    {
        BindingSource source;
        public event Action DataUpdated;
        AppDbContext dbContext = new AppDbContext();
        public ProductForm()
        {
            InitializeComponent();
            FillCategoryComboBox();
            Load_Data();
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

        private void BackHomePictureBox_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private List<Product> GetProducts()
        {
            var products = dbContext.Products.Select(
                p => new Product
                {
                    ProductID = p.ProductID
                    ,
                    ProductName = p.ProductName,
                    SellingPrice = p.SellingPrice
                    ,
                    CategoryID = p.CategoryID
                    ,
                    Description = p.Description
                }).ToList();
            return products;
        }
        private void ProductGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ProductGridView.SelectedRows.Count > 0)
            {
                var selectedProduct = (Product)ProductGridView.SelectedRows[0].DataBoundItem;
                source.DataSource = selectedProduct;

            }

        }

        private void Load_Data()
        {


            ProductGridView.AutoGenerateColumns = false; // Prevents automatic generation of columns
            ProductGridView.Columns.Clear();

            var idColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductID",
                HeaderText = "Product ID",
                Name = "ProductID"
            };
            var nameColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductName",
                HeaderText = "Product Name",
                Name = "ProductName"
            };

            var priceColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SellingPrice",
                HeaderText = "Selling Price",
                Name = "SellingPrice"
            };
            var categoryColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CategoryID",
                HeaderText = "Category ID",
                Name = "CategoryID"
            };
            var descriptionColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Description",
                Name = "Description"
            };

            ProductGridView.Columns.Add(idColumn);
            ProductGridView.Columns.Add(nameColumn);
            ProductGridView.Columns.Add(priceColumn);
            ProductGridView.Columns.Add(categoryColumn);
            ProductGridView.Columns.Add(descriptionColumn);

            ProductGridView.SelectionChanged -= ProductGridView_SelectionChanged;
            ProductGridView.DataSource = GetProducts();
            ClearBindings();
            if (source == null)
            {
                source = new BindingSource();
            }
            source.DataSource = typeof(Product);
            ProductIDtxtBox.DataBindings.Add("Text", source, "ProductID");
            ProductNametxtBox.DataBindings.Add("Text", source, "ProductName");
            PriceUpDownBox.DataBindings.Add("Value", source, "SellingPrice");
            CategoryComboBox.DataBindings.Add("SelectedValue", source, "CategoryID");
            DescriptionTextBox.DataBindings.Add("Text", source, "Description");

            ProductGridView.SelectionChanged += ProductGridView_SelectionChanged;

        }

        private void ClearBindings()
        {
            ProductIDtxtBox.DataBindings.Clear();
            ProductNametxtBox.DataBindings.Clear();
            PriceUpDownBox.DataBindings.Clear();
            DescriptionTextBox.DataBindings.Clear();
            CategoryComboBox.DataBindings.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(text: "Confirm Delete", caption: "", buttons: MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (source.Current != null)
                {
                    var selectedProduct = (Product)source.Current;
                    Delete_Product(selectedProduct);
                    Load_Data();
                }
                else
                {
                    MessageBox.Show("Please select a record to delete.");
                }
            }
        }
        private void Delete_Product(Product product)
        {
            dbContext.Products.Remove(product);
            dbContext.SaveChanges();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(text: "Confirm Update", caption: "", buttons: MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (int.TryParse(ProductIDtxtBox.Text, out int productId) && !string.IsNullOrWhiteSpace(ProductNametxtBox.Text) && decimal.TryParse(PriceUpDownBox.Text, out decimal price))
                {
                    string newProductName = ProductNametxtBox.Text;
                    int newCategorySelected = Convert.ToInt32(CategoryComboBox.SelectedValue);
                    string newDescription = DescriptionTextBox.Text;

                    Update_Product(productId, newProductName, price, newCategorySelected, newDescription);
                    Load_Data();
                }
                else
                {
                    MessageBox.Show("Please enter a valid Product Name, Price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Update_Product(int productId, string newProductName, decimal price, int newCategorySelected, string newDescription)
        {
            var product = dbContext.Products.SingleOrDefault(p => p.ProductID == productId);
            if (product != null)
            {
                // Update the product
                product.ProductName = newProductName;
                product.SellingPrice = price;
                product.CategoryID = newCategorySelected;
                product.Description = newDescription;
                dbContext.SaveChanges();
                MessageBox.Show("Category updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Category not found. Please check the category ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProductForm add = new AddProductForm();
            add.ShowDialog();
            Load_Data();

        }

        private void SearchName_TextChanged(object sender, EventArgs e)
        {
            var name = SearchName.Text.Trim();
            var products = dbContext.Products
                .Where(p => p.ProductName.Contains(name) )
                .Select(p => new Product
                {
                    ProductID = p.ProductID
                    ,
                    ProductName = p.ProductName,
                    SellingPrice = p.SellingPrice
                    ,
                    CategoryID = p.CategoryID
                    ,
                    Description = p.Description
                })
                .ToList();

            ProductGridView.DataSource = null;
            source.DataSource = products;
            ProductGridView.DataSource = source;
            ProductGridView.ClearSelection();
  
       


        }
    }
}
