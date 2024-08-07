namespace FoodDelivery.Domain.Domain
{
    public class CategoryInRestaurant : BaseEntity
    {
        public Guid CategoryId{ get; set; }
        public Category Category{ get; set; }
        public Guid RestaurantId{ get; set; }
        public Restaurant Restaurant{ get; set; }
    }
}
