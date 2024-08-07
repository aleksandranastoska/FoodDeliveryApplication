using FoodDelivery.Domain.Domain;
using FoodDelivery.Repository.Interface;
using FoodDelivery.Service.Interface;

namespace FoodDelivery.Service.Implementation
{
    public class RestaurantService : IRestaurantService
    {
       private readonly IRestaurantRepository _restaurantRepository;

        public RestaurantService(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        public void CreateNewRestaurant(Restaurant r)
        {
            _restaurantRepository.Insert(r);
        }

        public void DeleteExistingRestaurant(Guid? id)
        {
            var restaurant = _restaurantRepository.GetRestaurantById(id);
            _restaurantRepository.Delete(restaurant);
        }

        public List<Restaurant> GetAllRestaurants()
        {
            return _restaurantRepository.GetAllRestaurants().ToList();
        }

        public Restaurant GetDetailsForRestaurant(Guid? id)
        {
            return _restaurantRepository.GetRestaurantById(id);
        }

        public void UpdateExistingRestaurant(Restaurant r)
        {
            _restaurantRepository.Update(r);
        }
    }
}
