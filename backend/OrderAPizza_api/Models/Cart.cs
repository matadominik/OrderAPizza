namespace OrderAPizza_api.Models
{
    public class Cart
    {
        public int Id { get; set; }

        public int UsersId { get; set; }

        // Navigation properties
        public User? User { get; set; }
        public List<CartItem> CartItems { get; set; } = new();
    }
}
