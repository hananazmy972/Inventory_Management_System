using Inventory_Management__System.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Inventory_Management__System.Data.Config
{
    public class CategoryConfigration : IEntityTypeConfiguration<Category>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
            // Category Configuration
            builder.HasKey(c => c.CategoryID); // Primary Key

            builder.Property(x => x.CategoryID);
    

                 builder
                .Property(c => c.CategoryName)
                .IsRequired()
                .HasMaxLength(50); // Column constraints

                 builder
                .HasMany(c => c.Products) // One-to-Many relationship
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryID)
                .OnDelete(DeleteBehavior.Cascade);

            // Table configuration
            builder.ToTable("Categories");

            // Seed the database with initial Categories
            builder.HasData(loadCategories());

        }

        private List<Category> loadCategories()
        {
            return new List<Category>
            {

                new Category { CategoryID = 1, CategoryName = "Electronics" },
                new Category { CategoryID = 2, CategoryName = "Groceries" },
                new Category { CategoryID = 3, CategoryName = "Clothing" },
                new Category { CategoryID = 4, CategoryName = "Books" },
                new Category { CategoryID = 5, CategoryName = "Furniture" }
            };
        }
    }  
}
