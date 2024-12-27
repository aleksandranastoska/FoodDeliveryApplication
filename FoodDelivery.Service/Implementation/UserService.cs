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
        private readonly IOrderRepository _orderRepository;

        public UserService(IUserRepository userRepository, IAddressRepository addressRepository, IRestaurantRepository restaurantRepository, IOrderRepository orderRepository)
        {
            _userRepository = userRepository;
            _addressRepository = addressRepository;
            _restaurantRepository = restaurantRepository;
            _orderRepository = orderRepository;
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

        public List<Order> GetAllOrdersForUser(string? id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return new List<Order>();
            }

            var orders = _orderRepository.GetAllOrdersForUser(id);
            return orders ?? new List<Order>();
        }

        public List<FoodDeliveryAppUser> GetAllUsers()
        {
            return _userRepository.GetAll().ToList();
        }

        public FoodDeliveryAppUser GetDetailsForUser(string? id)
        {
            return _userRepository.Get(id);
        }

        public void UpdateExistingUser(FoodDeliveryAppUser user)
        {
            _userRepository.Update(user);
        }
    }
}
