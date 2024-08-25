using Inventory_Management__System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management__System.Data.Config
{
    public class ProductConfigration : IEntityTypeConfiguration<Product>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Product> builder)
        {
            //Primary key
            builder.HasKey(x => x.ProductID);

            builder.Property(x => x.ProductID);
                  

            //Name
            builder.Property(x => x.ProductName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired();

            //description

            builder.Property(x => x.Description)
                .HasColumnType("VARCHAR")
                .HasMaxLength(500);

            //price
            builder.Property(x => x.SellingPrice)
                .HasPrecision(15, 2)
                .IsRequired();


            //Relations

            //With inventroy
              builder.HasOne(x => x.Inventory)
                .WithOne(i => i.Product)
                .HasForeignKey<Inventory>(p => p.ProductID)
                .OnDelete(DeleteBehavior.Cascade);

            //with transaction 

            builder.HasMany(p => p.Transactions)
                .WithOne(t => t.Product)
                .HasForeignKey(t => t.ProductID)
                .OnDelete(DeleteBehavior.Cascade);

           // Table configuration
            builder.ToTable("Products");

           // Seed the database with initial products
            builder.HasData(loadProducts());
        }

        private List<Product> loadProducts()
        {
            return new List<Product>
            {
                 new Product { ProductID = 1, ProductName = "Laptop", Description = "15-inch laptop with 8GB RAM", SellingPrice = 999.99m, CategoryID = 1 },
                new Product { ProductID = 2, ProductName = "Smartphone", Description = "Latest model smartphone with 128GB storage", SellingPrice = 699.99m, CategoryID = 1 },
                new Product { ProductID = 3, ProductName = "Jeans", Description = "Comfortable blue jeans", SellingPrice = 49.99m, CategoryID = 3 },
                new Product { ProductID = 4, ProductName = "Desk Lamp", Description = "LED desk lamp with adjustable brightness", SellingPrice = 29.99m, CategoryID = 5 },
                new Product { ProductID = 5, ProductName = "Cereal", Description = "Whole grain cereal, 500g box", SellingPrice = 3.99m, CategoryID = 2 }
            };
        }
    }
}
