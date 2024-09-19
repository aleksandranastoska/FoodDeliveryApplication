using FoodDelivery.Domain.Domain;

namespace FoodDelivery.Domain.DTO
{
    public class OrderDTO
    {
        public Order Order { get; set; }
        public IEnumerable<Address> Addresses { get; set; }
    }
}
