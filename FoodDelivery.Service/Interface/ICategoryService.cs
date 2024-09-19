using FoodDelivery.Domain.Domain;

namespace FoodDelivery.Service.Interface
{
    public interface ICategoryService
    {
        List<Category> GetAllCategories();
        Category GetDetailsForCategory(Guid? id);
        List<Restaurant> GetAllRestaurants(Guid? id);
    }
}
