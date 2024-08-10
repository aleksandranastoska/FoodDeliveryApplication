using FoodDelivery.Domain.Domain;

namespace FoodDelivery.Repository.Interface
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
        Category GetCategoryById(Guid? id);
    }
}
