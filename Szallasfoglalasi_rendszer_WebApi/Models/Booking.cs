namespace Szallasfoglalasi_rendszer_WebApi.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int GuestId { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int NumberOfGuests { get; set; }
        public string Status { get; set; }
        public int TotalPrice { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
