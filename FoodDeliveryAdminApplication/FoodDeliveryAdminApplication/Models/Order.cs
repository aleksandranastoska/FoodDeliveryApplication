using System.Net;

namespace FoodDeliveryAdminApplication.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public FoodDeliveryAppUser Owner { get; set; }
        public IEnumerable<FoodInOrder> FoodsInOrder { get; set; }
        public Guid? AddressId { get; set; }
        public Address Address { get; set; }
    }
}
