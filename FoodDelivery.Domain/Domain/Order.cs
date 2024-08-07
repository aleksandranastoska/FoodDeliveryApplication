using FoodDelivery.Domain.Identity;

namespace FoodDelivery.Domain.Domain
{
    public class Order : BaseEntity
    {
        public string UserId { get; set; }
        public FoodDeliveryAppUser Owner { get; set; }
        public IEnumerable<FoodInOrder> FoodsInOrder{ get; set; }
    }
}
