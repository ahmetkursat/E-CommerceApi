using Microsoft.AspNetCore.Components.Forms;

namespace E_Api.Models
{
    public class CartItem
    {
        public List<Product> ProductID { get; set; }
        
        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
