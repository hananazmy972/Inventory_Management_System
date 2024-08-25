using Inventory_Management__System.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory_Management__System.Data.Config
{
    public class TransactionConfigration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Transaction> builder)
        {
            // Category Configuration
            builder.HasKey(c => c.TransactionID); // Primary Key

            builder.Property(x => x.TransactionID);
     


            builder.Property(t => t.TransactionType)
                .IsRequired()
                .HasConversion<string>();// Stores the enum as a string in the database


            builder.Property(t => t.TransactionDate)
                   .IsRequired();

            // Table configuration
            builder.ToTable("Transactions");

            // Seed the database with initial Transactions
            builder.HasData(loadTransactions());

        }

        private List<Transaction> loadTransactions()
        {
            return new List<Transaction>
            {
                new Transaction { TransactionID = 1, ProductID = 1, TransactionType = TransactionType.Purchase.ToString(), Quantity = 50, TransactionDate = DateTime.Now.AddDays(-10), Notes = "Initial stock purchase" },
                new Transaction { TransactionID = 2, ProductID = 2, TransactionType = TransactionType.Purchase.ToString(), Quantity = 100, TransactionDate = DateTime.Now.AddDays(-8), Notes = "Initial stock purchase" },
                new Transaction { TransactionID = 3, ProductID = 3, TransactionType = TransactionType.Purchase.ToString(), Quantity = 200, TransactionDate = DateTime.Now.AddDays(-6), Notes = "Initial stock purchase" },
                new Transaction { TransactionID = 4, ProductID = 4, TransactionType = TransactionType.Purchase.ToString(), Quantity = 150, TransactionDate = DateTime.Now.AddDays(-5), Notes = "Initial stock purchase" },
                new Transaction { TransactionID = 5, ProductID = 5, TransactionType = TransactionType.Sale.ToString(), Quantity = 30, TransactionDate = DateTime.Now.AddDays(-3), Notes = "Sale to customer" }
            };
        }
    } 
}
