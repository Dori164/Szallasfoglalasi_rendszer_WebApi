namespace Szallasfoglalasi_rendszer_WebApi.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Floor { get; set; }
        public int RoomTypeId { get; set; }
        public bool IsActive { get; set; }
    }
}
