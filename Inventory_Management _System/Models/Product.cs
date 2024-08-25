namespace Inventory_Management__System.Models
{
    public class Product
    {
        public int ProductID { get; set; } // Primary Key
        public string ProductName { get; set; } 
        public string? Description { get; set; }
        public decimal SellingPrice { get; set; }
        public int CategoryID { get; set; } //Required Foreign Key
        public Category Category { get; set; } = null !; //Required property


        // Navigation property for the Inventory (1:1 relationship)
        public Inventory? Inventory { get; set; }

        // Navigation property for the Transactions (1:N relationship)
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    }
}
