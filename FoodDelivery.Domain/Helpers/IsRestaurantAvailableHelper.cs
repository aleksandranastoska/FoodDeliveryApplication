using FoodDelivery.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Domain.Helpers
{
    public class IsRestaurantAvailableHelper
    {
        public bool IsRestaurantAvailable(Restaurant restaurant)
        {
            var currentTime = TimeOnly.FromDateTime(DateTime.Now);
            return currentTime>= restaurant.WorkingFrom && currentTime<=restaurant.WorkingTo;
        }
    }
}
