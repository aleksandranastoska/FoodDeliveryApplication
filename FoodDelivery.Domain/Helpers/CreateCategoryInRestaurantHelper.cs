using FoodDelivery.Domain.Domain;

namespace FoodDelivery.Domain.Helpers
{
    public class CreateCategoryInRestaurantHelper
    {
        public static CategoryInRestaurant CreateCategoryInRestaurant(Restaurant restaurant, Category category)
        {
            return new CategoryInRestaurant
            {
                Id = Guid.NewGuid(),
                CategoryId = category.Id,
                Category = category,
                RestaurantId = restaurant.Id,
                Restaurant = restaurant
            };
        }
    }
}
