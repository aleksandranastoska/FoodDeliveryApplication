using FoodDelivery.Domain.Domain;

namespace FoodDelivery.Domain.DTO
{
    public class MenuDTO
    {
        public Guid RestaurantId { get; set; }
        public List<Food> ExistingMenu { get; set; } = new List<Food>();
        public List<Food> NewMenu { get; set; } 
    }
}
