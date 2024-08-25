namespace Inventory_Management__System.Models
{
    public class Inventory
    {
        public int InventoryID { get; set; }

        public int ProductID { get; set; } // Required Foreign Key

        public Product Product { get; set; } = null!; //Required property

        public int Quantity { get; set; }
    }
}
