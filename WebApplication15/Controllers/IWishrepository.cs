namespace WebApplication16.Models
{
    public interface IWishrepository
    {
        List<Wishlist> GetAllWishlist();
        Wishlist GetWishlistById(int id);
        Wishlist AddWishlist(Wishlist wishlist);
        void DeleteWishlist(int id);
        void UpdateWishlist(Wishlist wishlist);
    }
}
