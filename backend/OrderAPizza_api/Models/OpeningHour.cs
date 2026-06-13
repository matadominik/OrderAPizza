namespace OrderAPizza_api.Models
{
    public class OpeningHour
    {
        public int Id { get; set; }

        public TimeSpan OpenTime { get; set; }  // TimeSpan: only HH:MM
        public TimeSpan CloseTime { get; set; }
    }
}
