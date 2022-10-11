namespace WebApplication16.Models
{
    public class Wishlist
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public String Title { get; set; }
        public String Image { get; set; }
        public String ISBN { get; set; }
        public int Price { get; set; }
    }
}
