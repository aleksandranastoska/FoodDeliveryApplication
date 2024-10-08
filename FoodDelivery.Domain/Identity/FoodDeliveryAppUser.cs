﻿using FoodDelivery.Domain.Domain;
using FoodDelivery.Domain.Enumerations;
using Microsoft.AspNetCore.Identity;

namespace FoodDelivery.Domain.Identity
{
    public class FoodDeliveryAppUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public List<Address>? DeliveryAddress { get; set; }
        public virtual Wishlist Wishlist { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }
        public UserRole Role { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ICollection<FavoriteRestaurants>? FavoriteRestaurants { get; set; }
    }
}
