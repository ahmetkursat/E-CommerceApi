namespace E_Api.Models
{
    public class Product
    {
        public string? Name { get; set; }

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public List<string> ImageUrl { get; set; }

        public int Id { get; set; }
    }
}
