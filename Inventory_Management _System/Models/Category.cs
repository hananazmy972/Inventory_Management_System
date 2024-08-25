using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management__System.Models
{
    public class Category
    {
        public int CategoryID { get; set; } // Primary Key
        public string CategoryName { get; set; } = string.Empty;

        // Navigation property to represent the one-to-many relationship with Products
        public ICollection<Product> Products { get; set; } = new List<Product>();

    }




}
