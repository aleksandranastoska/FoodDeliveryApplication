using FoodDelivery.Domain.Domain;
using FoodDelivery.Domain.Identity;
using FoodDelivery.Repository.Interface;
using FoodDelivery.Service.Interface;

namespace FoodDelivery.Service.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IAddressRepository _addressRepository;
        private readonly IRestaurantRepository _restaurantRepository;

        public UserService(IUserRepository userRepository, IAddressRepository addressRepository, IRestaurantRepository restaurantRepository)
        {
            _userRepository = userRepository;
            _addressRepository = addressRepository;
            _restaurantRepository = restaurantRepository;
        }

        public void AddAddress(Address address)
        {
            _addressRepository.Insert(address);
        }

        public async Task<bool> AddToFavorites(string userId, Guid restaurantId)
        {
            var restaurant = _restaurantRepository.GetRestaurantById(restaurantId);

            var user = _userRepository.Get(userId);

            user.FavoriteRestaurants.Add(new FavoriteRestaurants
            {
                Id = Guid.NewGuid(),
                OwnerId = userId,
                RestaurantId = restaurantId,
                IsFavorite = true
            });

            return await Task.FromResult(true);
        }

        public List<Address> GetAllAddressesForUser(string? id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return new List<Address>();
            }

            var addresses = _addressRepository.GetAllAddressesForUser(id);
            return addresses ?? new List<Address>();
        }

        public List<FoodDeliveryAppUser> GetAllUsers()
        {
            return _userRepository.GetAll().ToList();
        }

        public FoodDeliveryAppUser GetDetailsForUser(string? id)
        {
            return _userRepository.Get(id);
        }
    }
}
