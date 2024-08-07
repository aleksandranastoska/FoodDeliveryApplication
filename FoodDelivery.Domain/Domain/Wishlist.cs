using FoodDelivery.Domain.Identity;

namespace FoodDelivery.Domain.Domain
{
    public class Wishlist : BaseEntity
    {
        public string? UserId { get; set; }
        public FoodDeliveryAppUser? User { get; set; }
        public virtual ICollection<FoodInWishlist>? FoodInWishlists { get; set; }
    }
}
