using FoodDelivery.Domain.Domain;
using FoodDelivery.Repository.Interface;
using FoodDelivery.Service.Interface;

namespace FoodDelivery.Service.Implementation
{
    public class FoodService : IFoodService
    {
        private readonly IFoodRepository _foodRepository;
        private readonly IUserRepository _userRepository;

        public FoodService(IFoodRepository foodRepository, IUserRepository userRepository)
        {
            _foodRepository = foodRepository;
            _userRepository = userRepository;
        }

        public void CreateNewFood(Food f)
        {
            _foodRepository.Insert(f);
        }

        public void DeleteExistingFood(Guid? id)
        {
            var food = _foodRepository.GetFoodById(id);
            _foodRepository.Delete(food);
        }

        public List<Food> GetAllFoods()
        {
            return _foodRepository.GetAllFoods().ToList();
        }

        public List<Food> GetAllFoodsForRestaurant(Guid? restaurantId)
        {
            return _foodRepository.GetAllFoodsForRestaurant(restaurantId).ToList();
        }

        public Food GetDetailsForFood(Guid? id)
        {
            return _foodRepository.GetFoodById(id);
        }

        public void UpdateExistingFood(Food f)
        {
            _foodRepository.Update(f);
        }
    }
}
