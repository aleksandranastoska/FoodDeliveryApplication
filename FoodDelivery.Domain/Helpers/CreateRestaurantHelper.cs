using FoodDelivery.Domain.Domain;
using FoodDelivery.Domain.DTO;

namespace FoodDelivery.Domain.Helpers
{
    public class CreateRestaurantHelper
    {
        public static Restaurant CreateRestaurant(RestaurantDTO restaurantDTO, string loggedInUser, Identity.FoodDeliveryAppUser? user)
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
               Owner = user
           };
        }
    }
}
