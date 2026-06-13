namespace OrderAPizza_api.Models
{
    public enum UserRole
    {
        user, 
        admin
    }
    public class User
    {
        public int Id { get; set; }

        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public UserRole Role { get; set; } = UserRole.user;
        public int Points { get; set; }
        public DateTime? DeletedAt { get; set; }

        // Navigation properties
        public List<Address> Addresses { get; set; } = new();
        public List<Order> Orders { get; set; } = new();
        public List<Cart> Carts { get; set; } = new();
    }
}
