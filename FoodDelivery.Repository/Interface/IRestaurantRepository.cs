using FoodDelivery.Domain.Domain;

namespace FoodDelivery.Repository.Interface
{
    public interface IRestaurantRepository
    {
        IEnumerable<Restaurant> GetAllRestaurants();
        Restaurant GetRestaurantById(Guid? id);
        void Insert(Restaurant restaurant);
        void Update(Restaurant restaurant);
        void Delete(Restaurant restaurant);
        IEnumerable<Restaurant> GetAllRestaurantFromOwner(string ownerId);
        IEnumerable<Category> GetCategoriesForRestaurant(Guid restaurantId);
    }
}
