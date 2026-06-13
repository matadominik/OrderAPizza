namespace OrderAPizza_api.Models
{
    public enum OrderStatus
    {
        pending, 
        confirmed, 
        delivered
    }
    public class Order
    {
        public int Id { get; set; }

        public int? UsersId { get; set; }
        public int? AddressesId { get; set; }

        public string? GuestName { get; set; }
        public string? GuestEmail { get; set; }
        public string? GuestPhoneNumber { get; set; }
        public string? GuestCity { get; set; }
        public string? GuestStreet { get; set; }
        public string? GuestHouseNumber { get; set; }
        public string? GuestAddressNote { get; set; }

        public OrderStatus Status { get; set; } = OrderStatus.pending;
        public DateTime CreatedAt { get; set; }
        public int TotalPrice { get; set; }
        public int PointsGiven { get; set; }

        // Navigation properties
        public User? User { get; set; }
        public Address? Address { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new();
    }
}
