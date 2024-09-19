using FoodDelivery.Domain.Domain;
using FoodDelivery.Domain.DTO;

namespace FoodDelivery.Service.Interface
{
    public interface IWishlistService
    {
        List<Wishlist> GetAllWishlists();
        Wishlist GetDetailsForWishlist(Guid? id);
        void CreateNewWishlist(Wishlist w);
        void UpdateExistingWishlist(Wishlist w);
        void DeleteExistingWishlist(Guid? id);
        Wishlist GetUserWishlist(string userId);
        WishlistDTO GetWishlistInfo(string userId);
        bool deleteFoodFromWishlist(string userId, Guid foodId);
    }
}
