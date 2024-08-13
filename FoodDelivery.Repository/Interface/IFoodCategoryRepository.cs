using FoodDelivery.Domain.Domain;

namespace FoodDelivery.Repository.Interface
{
    public interface IFoodCategoryRepository
    {
        IEnumerable<FoodCategory> GetAllFoodCategories();
        FoodCategory GetFoodCategoryById(Guid? id);
    }
}
