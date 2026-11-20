namespace Szallasfoglalasi_rendszer_WebApi.Models
{
    public class Guest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public DateTime RegisteredAt { get; set; }
    }
}
