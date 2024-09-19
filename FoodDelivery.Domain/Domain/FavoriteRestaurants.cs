using FoodDelivery.Domain.Identity;

namespace FoodDelivery.Domain.Domain
{
    public class FavoriteRestaurants : BaseEntity
    {
        public string OwnerId { get; set; }
        public FoodDeliveryAppUser Owner { get; set; }
        public Guid RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public bool IsFavorite { get; set; }
    }
}
