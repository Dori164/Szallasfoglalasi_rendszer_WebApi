namespace Szallasfoglalasi_rendszer_WebApi.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
