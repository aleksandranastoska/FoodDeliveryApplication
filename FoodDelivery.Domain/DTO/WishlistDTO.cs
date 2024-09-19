using FoodDelivery.Domain.Domain;

namespace FoodDelivery.Domain.DTO
{
    public class WishlistDTO
    {
        public List<FoodInWishlist>? Foods { get; set; }
        public double TotalPrice { get; set; }
    }
}
