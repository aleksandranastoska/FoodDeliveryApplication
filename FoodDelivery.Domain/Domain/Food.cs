namespace FoodDelivery.Domain.Domain
{
    public class Food : BaseEntity
    {
        public string? Name { get; set; }
        public double? Price{ get; set; }
        public string? Image{ get; set; }
        public string? Description{ get; set; }
        public Guid? RestaurantId{ get; set; }
        public Restaurant? Restaurant{ get; set; }
    }
}
