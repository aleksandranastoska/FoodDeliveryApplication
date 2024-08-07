using FoodDelivery.Domain.Domain;

namespace FoodDelivery.Service.Interface
{
    public interface IRestaurantService
    {
        List<Restaurant> GetAllRestaurants();
        Restaurant GetDetailsForRestaurant(Guid? id);
        void CreateNewRestaurant(Restaurant r);
        void UpdateExistingRestaurant(Restaurant r);
        void DeleteExistingRestaurant(Guid? id);
    }
}
