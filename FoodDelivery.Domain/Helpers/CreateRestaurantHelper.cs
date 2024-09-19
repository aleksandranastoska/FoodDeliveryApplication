using FoodDelivery.Domain.Domain;
using FoodDelivery.Domain.DTO;
using FoodDelivery.Domain.Identity;
using Microsoft.AspNetCore.Identity;

namespace FoodDelivery.Domain.Helpers
{
    public class CreateRestaurantHelper
    {
        private readonly UserManager<FoodDeliveryAppUser> _userManager;

        public CreateRestaurantHelper(UserManager<FoodDeliveryAppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<Restaurant> CreateRestaurant(RestaurantDTO restaurantDTO, string loggedInUser)
        {

           return new Restaurant
           {
               Id = Guid.NewGuid(),
               Name = restaurantDTO.Name,
               Location = restaurantDTO.Location,
               Latitude = restaurantDTO.Latitude,
               Longitude = restaurantDTO.Longitude,
               Rating = 0.0,
               NumOfOrders = 0,
               TotalGrades = 0,
               IsAvailable = false,
               DeliveryTime = restaurantDTO.DeliveryTime,
               WorkingFrom = restaurantDTO.WorkingFrom,
               WorkingTo = restaurantDTO.WorkingTo,
               PhoneNumber = restaurantDTO.PhoneNumber,
               OwnerId = loggedInUser,
               Owner = await _userManager.FindByIdAsync(loggedInUser),
               RestaurantImage = restaurantDTO.RestaurantImage
           };
        }

        public Restaurant CreateRestaurantFromMenu(Restaurant restaurant)
        {
            return new Restaurant
            {
                Id = Guid.NewGuid(),
                Name = restaurant.Name,
                Location = restaurant.Location,
                Latitude = restaurant.Latitude,
                Longitude = restaurant.Longitude,
                Rating = restaurant.Rating,
                NumOfOrders = restaurant.NumOfOrders,
                TotalGrades = restaurant.TotalGrades,
                IsAvailable = restaurant.IsAvailable,
                DeliveryTime = restaurant.DeliveryTime,
                WorkingFrom = restaurant.WorkingFrom,
                WorkingTo = restaurant.WorkingTo,
                PhoneNumber = restaurant.PhoneNumber,
                OwnerId = restaurant.OwnerId,
                Owner = restaurant.Owner,
                Menu = restaurant.Menu,
                RestaurantImage = restaurant.RestaurantImage
            };
        }
    }
}
