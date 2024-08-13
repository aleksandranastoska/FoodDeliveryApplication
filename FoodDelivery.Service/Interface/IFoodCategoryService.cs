using FoodDelivery.Domain.Domain;

namespace FoodDelivery.Service.Interface
{
    public interface IFoodCategoryService
    {
        List<FoodCategory> GetAllFoodCategories();

        FoodCategory GetDetailsForFoodCategory(Guid? id);
    }
}
