using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FoodDelivery.Domain.Domain;
using FoodDelivery.Service.Interface;

namespace FoodDeliveryApplication.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly IRestaurantService _restaurantService;

        public RestaurantsController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        public IActionResult Index()
        {
            return View(_restaurantService.GetAllRestaurants());
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            CheckIfRestaurantIsNull(id);

            var restaurant = _restaurantService.GetDetailsForRestaurant(id);

            if (!RestaurantExists(restaurant.Id)) return NotFound();

            return View(restaurant);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,Location,Latitude,Longitude,Rating,NumOfOrders,IsAvailable,DeliveryTime,WorkingFrom,WorkingTo,PhoneNumber,Id")] Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                restaurant.Id = Guid.NewGuid();
                _restaurantService.CreateNewRestaurant(restaurant);
                return RedirectToAction(nameof(Index));
            }

            return View(restaurant);
        }

        public IActionResult Edit(Guid? id)
        {
            CheckIfRestaurantIsNull(id);

            var restaurant = _restaurantService.GetDetailsForRestaurant(id);

            if (!RestaurantExists(restaurant.Id)) return NotFound();

            return View(restaurant);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("Name,Location,Latitude,Longitude,Rating,NumOfOrders,IsAvailable,DeliveryTime,WorkingFrom,WorkingTo,PhoneNumber,Id")] Restaurant restaurant)
        {
            CheckIfRestaurantIsNull(id);

            if (ModelState.IsValid)
            {
                try
                {
                    _restaurantService.UpdateExistingRestaurant(restaurant);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RestaurantExists(restaurant.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(restaurant);
        }

        public IActionResult Delete(Guid? id)
        {
            if (CheckIfRestaurantIsNull(id)) return NotFound();

            var restaurant = _restaurantService.GetDetailsForRestaurant(id);

            if (!RestaurantExists(restaurant.Id)) return NotFound();

            return View(restaurant);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _restaurantService.DeleteExistingRestaurant(id);
            return RedirectToAction(nameof(Index));
        }

        private bool RestaurantExists(Guid id)
        {
            return _restaurantService.GetDetailsForRestaurant(id) != null;
        }

        private bool CheckIfRestaurantIsNull(Guid? id)
        {
            return id == null;
        }
    }
}
