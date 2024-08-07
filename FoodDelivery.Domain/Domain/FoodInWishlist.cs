namespace FoodDelivery.Domain.Domain
{
    public class FoodInWishlist : BaseEntity
    {
        public Guid FoodId { get; set; }
        public Food Food { get; set; }
        public Guid WishlistId { get; set; }
        public Wishlist Wishlist { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
