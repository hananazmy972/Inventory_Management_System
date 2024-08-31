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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Inventory_Management__System
{
    public partial class SaleForm : Form
    {
        AppDbContext dbContext = new AppDbContext();
        public SaleForm()
        {
            InitializeComponent();
            fill_data();
        }

        private void FillProductComboBox()
        {
            var products = dbContext.Products.Select(p => new
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName
            }).ToList();
            comboBox1.DisplayMember = "ProductName";
            comboBox1.ValueMember = "ProductID";
            comboBox1.DataSource = products;
        }
        public void fill_data()
        {
            FillProductComboBox();
            dateTimePicker1.Value = DateTime.Now;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValidProduct())
            {
                return;
            }
            int selectedProductId = (int)comboBox1.SelectedValue;
            int quantity = int.Parse(numericUpDown1.Text);
            ;
            var product = dbContext.Inventories.FirstOrDefault(t => t.ProductID == selectedProductId);
            if (product != null && product.Quantity >= quantity)
            {
                product.Quantity -= quantity; //minus total quantity in stock
                Transaction transaction = new Transaction
                {
                    ProductID = selectedProductId,
                    TransactionDate = dateTimePicker1.Value,
                    Quantity = quantity,
                    TransactionType = "Sale",
                    Notes = textBox1.Text
                };
                dbContext.Transactions.Add(transaction);
                dbContext.SaveChanges();
                MessageBox.Show("Sale completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Not enough stock available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidProduct()
        {
            // Check if a Product is selected
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //check quantity
            if (!int.TryParse(numericUpDown1.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid  quantity than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


    }
}
