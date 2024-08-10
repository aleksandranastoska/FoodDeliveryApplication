using FoodDelivery.Domain.Domain;
using FoodDelivery.Repository.Interface;
using FoodDelivery.Service.Interface;

namespace FoodDelivery.Service.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public List<Category> GetAllCategories()
        {
            return _categoryRepository.GetAllCategories().ToList();
        }

        public Category GetDetailsForCategory(Guid? id)
        {
            return _categoryRepository.GetCategoryById(id);
        }
    }
}
