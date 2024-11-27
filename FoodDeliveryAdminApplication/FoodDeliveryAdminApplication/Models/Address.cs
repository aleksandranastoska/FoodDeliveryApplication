namespace FoodDeliveryAdminApplication.Models
{
    public class Address
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public int Flat { get; set; }
        public string OwnerId { get; set; }
        public FoodDeliveryAppUser Owner { get; set; }
    }
}
