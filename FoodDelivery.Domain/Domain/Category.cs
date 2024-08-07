namespace FoodDelivery.Domain.Domain
{
    public class Category : BaseEntity
    {
        public string? Name { get; set; }
        public string? Image { get; set; }
        public virtual ICollection<CategoryInRestaurant>? CategoryInRestaurants { get; set; }
    }
}
