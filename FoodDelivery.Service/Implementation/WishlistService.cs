using FoodDelivery.Domain.Domain;
using FoodDelivery.Domain.DTO;
using FoodDelivery.Repository.Interface;
using FoodDelivery.Service.Interface;

namespace FoodDelivery.Service.Implementation
{
    public class WishlistService : IWishlistService
    {
        private readonly IWishlistRepository _wishlistRepository;

        private readonly IUserRepository _userRepository;

        public WishlistService(IWishlistRepository wishlistRepository, IUserRepository userRepository)
        {
            _wishlistRepository = wishlistRepository;
            _userRepository = userRepository;
        }

        public void CreateNewWishlist(Wishlist w)
        {
            _wishlistRepository.Insert(w);
        }

        public void DeleteExistingWishlist(Guid? id)
        {
            var wishlist = _wishlistRepository.GetWishlistById(id);

            _wishlistRepository.Delete(wishlist);
        }

        public bool deleteFoodFromWishlist(string userId, Guid foodId)
        {
            if (foodId != null)
            {
                var loggedInUser = _userRepository.Get(userId);

                var userWishlist = loggedInUser.Wishlist;
                var foodToDelete = userWishlist.FoodInWishlists.Where(f=>f.FoodId == foodId).FirstOrDefault();

                userWishlist.FoodInWishlists.Remove(foodToDelete);

                _wishlistRepository.Update(userWishlist);
                
                return true;
            }

            return false;
        }

        public List<Wishlist> GetAllWishlists()
        {
            return _wishlistRepository.GetAllWishlists().ToList();
        }

        public Wishlist GetDetailsForWishlist(Guid? id)
        {
            return _wishlistRepository.GetWishlistById(id);
        }

        public Wishlist GetUserWishlist(string userId)
        {
            return _wishlistRepository.GetWishlistByUserId(userId);
        }

        public WishlistDTO GetWishlistInfo(string userId)
        {
            var loggedInUser = _userRepository.Get(userId);

            var userWishlist = loggedInUser?.Wishlist;
            var allFoods = userWishlist?.FoodInWishlists?.ToList();

            var price = allFoods.Select(f=>(f.Food.Price * f.Quantity)).Sum();

            WishlistDTO wishlistDto = new WishlistDTO
            {
                Foods = allFoods,
                TotalPrice = price??0
            };

            return wishlistDto;
        }

        public void UpdateExistingWishlist(Wishlist w)
        {
            _wishlistRepository.Update(w);
        }
    }
}
