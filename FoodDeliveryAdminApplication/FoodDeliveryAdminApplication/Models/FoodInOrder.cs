namespace FoodDeliveryAdminApplication.Models
{
    public class FoodInOrder
    {
        public Guid Id { get; set; }
        public Guid FoodId { get; set; }
        public Food Food { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
