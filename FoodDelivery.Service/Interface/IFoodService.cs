using FoodDelivery.Domain.Domain;

namespace FoodDelivery.Service.Interface
{
    public interface IFoodService
    {
        List<Food> GetAllFoods();
        Food GetDetailsForFood(Guid? id);
        void CreateNewFood(Food f);
        void UpdateExistingFood(Food f);
        void DeleteExistingFood(Guid? id);
        List<Food> GetAllFoodsForRestaurant(Guid? restaurantId);
    }
}
