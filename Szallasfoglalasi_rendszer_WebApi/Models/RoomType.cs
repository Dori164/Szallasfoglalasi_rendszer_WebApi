namespace Szallasfoglalasi_rendszer_WebApi.Models
{
    public class RoomType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int PricePerNight { get; set; }
        public string Description { get; set; }
    }
}
