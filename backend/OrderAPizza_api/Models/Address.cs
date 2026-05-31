namespace OrderAPizza_api.Models
{
    public class Address
    {
        public int Id { get; set; }
        public int UsersId { get; set; } 

        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string HouseNumber { get; set; } = string.Empty;
        public string AddressNote { get; set; } = string.Empty;

        // navigation properties
        public User? User { get; set; }
        public List<Order> Orders { get; set; } = new();
    }
}
