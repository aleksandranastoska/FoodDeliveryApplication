using FoodDelivery.Domain.Domain;

namespace FoodDelivery.Repository.Interface
{
    public interface IWishlistRepository
    {
        IEnumerable<Wishlist> GetAllWishlists();
        Wishlist GetWishlistById(Guid? id);
        void Insert(Wishlist wishlist);
        void Update(Wishlist wishlist);
        void Delete(Wishlist wishlist);
        Wishlist GetWishlistByUserId(string userId);
    }
}
