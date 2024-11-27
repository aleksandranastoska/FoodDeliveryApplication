namespace FoodDeliveryAdminApplication.Models
{
    public class Food
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public double? Price { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public Guid? RestaurantId { get; set; }
        public Restaurant? Restaurant { get; set; }
        public Guid? FoodCategoryId { get; set; }
        public FoodCategory? FoodCategory { get; set; }
    }
}
