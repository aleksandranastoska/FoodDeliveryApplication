using FoodDelivery.Domain.Identity;

namespace FoodDelivery.Domain.Domain
{
    public class Address : BaseEntity
    {
        public string Title { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public int Flat { get; set; }
        public string OwnerId { get; set; }
        public FoodDeliveryAppUser Owner { get; set; }
    }
}
