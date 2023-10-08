namespace E_Api.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public string? OrderStatus { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }
}
