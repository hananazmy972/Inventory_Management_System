namespace Inventory_Management__System.Models
{
    public class Transaction
    {

        public int TransactionID { get; set; } // Primary Key
        public DateTime TransactionDate { get; set; }

        public int ProductID { get; set; }  // Foreign Key for Product
        public Product Product { get; set; } = null!; //Required property

        public int Quantity { get; set; }
        public string TransactionType { get; set; }  // "Purchase" or "Sale"
        public string? Notes { get; set; }
    }
}
