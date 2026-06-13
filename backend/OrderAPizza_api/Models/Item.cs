namespace OrderAPizza_api.Models
{
    public class Item
    {
        public int Id { get; set; }

        public int GroupsId { get; set; }

        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime? DeletedAt { get; set; }

        // Navigation properties
        public Group? Group { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new();
        public List<CartItem> CartItems { get; set; } = new();
    }
}
