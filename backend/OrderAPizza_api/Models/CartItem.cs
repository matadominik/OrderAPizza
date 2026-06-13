namespace OrderAPizza_api.Models
{
    public class CartItem
    {
        public int Id { get; set; }

        public int CartsId { get; set; }
        public int ItemsId { get; set; }

        public int Quantity { get; set; }

        // Navigation properties
        public Cart? Cart { get; set; }
        public Item? Item { get; set; }
    }
}
