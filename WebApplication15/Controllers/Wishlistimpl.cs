namespace WebApplication16.Models
{
    public class Wishlistimpl : IWishrepository
    {
        private readonly BookDbContext _dbContext;


        public Wishlistimpl(BookDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        public Wishlist AddWishlist(Wishlist wishlist)
        {
            _dbContext.Wishlist.Add(wishlist);
            _dbContext.SaveChanges();
            return wishlist;
        }

        public void DeleteWishlist(int id)
        {
            throw new NotImplementedException();
        }

        public List<Wishlist> GetAllWishlist()
        {
            return _dbContext.Wishlist.ToList();
        }

        public Wishlist GetWishlistById(int id)
        {
            return _dbContext.Wishlist.FirstOrDefault(emp => emp.UserId == id);
        }

        public void UpdateWishlist(Wishlist wishlist)
        {
            throw new NotImplementedException();
        }
    }
}
