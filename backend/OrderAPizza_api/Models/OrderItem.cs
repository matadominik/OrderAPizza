namespace OrderAPizza_api.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrdersId { get; set; }
        public int ItemsId { get; set; }

        public int Quantity { get; set; }
        public int UnitPrice { get; set; }

        public Order? Order { get; set; }
        public Item? Item { get; set; }
    }
}
