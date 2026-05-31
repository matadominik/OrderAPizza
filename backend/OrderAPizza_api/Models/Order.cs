namespace OrderAPizza_api.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UsersId { get; set; }
        public int AddressesId { get; set; }

        public string Status { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public int TotalPrice { get; set; }
        public int PointsGiven { get; set; }

        public User? User { get; set; }
        public Address? Address { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new();
    }
}
