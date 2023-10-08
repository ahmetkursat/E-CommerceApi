namespace E_Api.Models
{
    public class OrderItem
    {
        public List<Product> IdProducts { get; set; }

        public int Quantity { get; set; }

        public int TotalPrice { get; set; }

    }
}
