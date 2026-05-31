namespace OrderAPizza_api.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public List<Item> Items { get; set; } = new();
    }
}
