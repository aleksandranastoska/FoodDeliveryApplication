namespace FoodDelivery.Domain.DTO
{
    public class RestaurantDTO
    {
        public string? Name { get; set; }
        public string? Location { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int? DeliveryTime { get; set; }
        public TimeOnly? WorkingFrom { get; set; }
        public TimeOnly? WorkingTo { get; set; }
        public string? PhoneNumber { get; set; }
        public string? RestaurantImage { get; set; }
    }
}

