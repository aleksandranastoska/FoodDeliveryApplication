using FoodDelivery.Domain.Domain;

namespace FoodDelivery.Repository.Interface
{
    public interface IFoodRepository
    {
        IEnumerable<Food> GetAllFoods();
        List<Food> GetAllFoodsForRestaurant(Guid? restaurantId);
        Food GetFoodById(Guid? id);
        void Insert(Food food);
        void Update(Food food);
        void Delete(Food food);
    }
}
