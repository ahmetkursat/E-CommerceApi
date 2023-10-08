using System.ComponentModel.DataAnnotations;

namespace E_Api.Models
{
    public class Cart 
    {
        public List<CartItem> CardItems { get; set; }
        public double TotalPrice  { get; set; }
    }
}
