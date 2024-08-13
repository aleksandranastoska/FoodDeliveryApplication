using FoodDelivery.Domain.Domain;
using FoodDelivery.Repository.Interface;
using FoodDelivery.Service.Interface;
namespace FoodDelivery.Service.Implementation
{
    public class FoodCategoryService : IFoodCategoryService
    {
        private readonly IFoodCategoryRepository _foodCategoryRepository;

        public FoodCategoryService(IFoodCategoryRepository foodCategoryRepository)
        {
            _foodCategoryRepository = foodCategoryRepository;
        }

        public List<FoodCategory> GetAllFoodCategories()
        {
            return _foodCategoryRepository.GetAllFoodCategories().ToList();
        }

        public FoodCategory GetDetailsForFoodCategory(Guid? id)
        {
            return _foodCategoryRepository.GetFoodCategoryById(id);
        }
    }
}
