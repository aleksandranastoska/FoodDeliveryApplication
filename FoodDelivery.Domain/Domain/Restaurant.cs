using FoodDelivery.Domain.Identity;

namespace FoodDelivery.Domain.Domain
{
    public class Restaurant : BaseEntity
    {
        public string? Name { get; set; }
        public string? Location { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public double? Rating { get; set; }
        public int? NumOfOrders { get; set; }
        public int? TotalGrades { get; set; }
        public bool? IsAvailable { get; set; }
        public int? DeliveryTime { get; set; }
        public TimeOnly? WorkingFrom { get; set; }
        public TimeOnly? WorkingTo { get; set; }
        public string? PhoneNumber { get; set; }
        public virtual ICollection<CategoryInRestaurant>? CategoryInRestaurants { get; set; }
        public string OwnerId { get; set; }
        public FoodDeliveryAppUser Owner { get; set; }
        public ICollection<Food> Menu { get; set; } = new List<Food>();
        public string? RestaurantImage { get; set; }
        public virtual ICollection<FavoriteRestaurants>? FavoriteRestaurants { get; set; }
    }
}
