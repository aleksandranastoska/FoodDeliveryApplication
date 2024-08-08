namespace FoodDelivery.Domain.Domain
{
    public class Category 
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
        public virtual ICollection<CategoryInRestaurant>? CategoryInRestaurants { get; set; }
    }
}
