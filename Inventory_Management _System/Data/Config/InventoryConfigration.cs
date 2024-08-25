using Inventory_Management__System.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory_Management__System.Data.Config
{
    public class InventoryConfigration : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Inventory> builder)
        {
         
            builder.HasKey(c => c.InventoryID); // Primary Key
            builder.Property(x => x.InventoryID);
                 

            builder
            .Property(i => i.Quantity)
            .IsRequired();

            // Table configuration
            builder.ToTable("Inventories");

            // Seed the database with initial Inventories
            builder.HasData(loadInventories());

        }

        private  List<Inventory> loadInventories()
        {
            return new List<Inventory>
            {

                new Inventory { InventoryID = 1, ProductID = 1, Quantity = 50 }, // Laptop inventory
                new Inventory { InventoryID = 2, ProductID = 2, Quantity = 100 }, // Smartphone inventory
                new Inventory { InventoryID = 3, ProductID = 3, Quantity = 200 }, // Jeans inventory
                new Inventory { InventoryID = 4, ProductID = 4, Quantity = 150 }, // Desk Lamp inventory
                new Inventory { InventoryID = 5, ProductID = 5, Quantity = 300 }  // Cereal inventory
            };
        }
    }
}
