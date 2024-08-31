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

    public partial class TransactionForm : Form
    {
        AppDbContext dbContext = new AppDbContext();
        public TransactionForm()
        {
            InitializeComponent();
            LoadTransactionsData();
        }
        private List<object> GetTransaction()
        {
            var transactions = dbContext.Transactions.Select(
                t => new
                {
                    TransactionID = t.TransactionID,
                    TransactionDate = t.TransactionDate,
                    ProductName = t.Product.ProductName,
                    TransactionType = t.TransactionType,    
                    Quantity = t.Quantity,
                    Notes = t.Notes
                }).ToList<object>();

            return transactions;
        }
        private void LoadTransactionsData()
        {
            TransactionGridView.DataSource = GetTransaction();
        }

        private void BackHomePictureBox_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            SaleForm saleForm = new SaleForm();
            saleForm.ShowDialog();
            LoadTransactionsData();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            PurchaseForm  purchaseForm = new PurchaseForm();
            purchaseForm.ShowDialog();
            LoadTransactionsData();
        }
    }
}
