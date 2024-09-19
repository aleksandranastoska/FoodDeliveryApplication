using FoodDelivery.Domain.Domain;
using FoodDelivery.Repository.Interface;
using FoodDelivery.Service.Interface;

namespace FoodDelivery.Service.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IRestaurantRepository _restaurantRepository;

        public CategoryService(ICategoryRepository categoryRepository, IRestaurantRepository restaurantRepository)
        {
            _categoryRepository = categoryRepository;
            _restaurantRepository = restaurantRepository;
        }

        public List<Category> GetAllCategories()
        {
            return _categoryRepository.GetAllCategories().ToList();
        }

        public List<Restaurant> GetAllRestaurants(Guid? id)
        {
            return _restaurantRepository.GetAllRestaurants()
                .Where(r => r.CategoryInRestaurants
                    .Any(cir => cir.CategoryId == id))
                .ToList();
        }

        public Category GetDetailsForCategory(Guid? id)
        {
            return _categoryRepository.GetCategoryById(id);
        }
    }
}
