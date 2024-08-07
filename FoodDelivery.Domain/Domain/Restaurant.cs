﻿namespace FoodDelivery.Domain.Domain
{
    public class Restaurant : BaseEntity
    {
        public string? Name { get; set; }
        public string? Location { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public double? Rating { get; set; }
        public int? NumOfOrders { get; set; }
        public int? TotalGrades { get; set; }
        public bool? IsAvailable { get; set; }
        public int? DeliveryTime { get; set; }
        public TimeOnly? WorkingFrom { get; set; }
        public TimeOnly? WorkingTo { get; set; }
        public string? PhoneNumber { get; set; }
        public virtual ICollection<CategoryInRestaurant>? CategoryInRestaurants { get; set; }
    }
}