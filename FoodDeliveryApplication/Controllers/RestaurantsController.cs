using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FoodDelivery.Domain.Domain;
using FoodDelivery.Service.Interface;
using System.Security.Claims;
using FoodDelivery.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using FoodDelivery.Domain.DTO;
using FoodDelivery.Domain.Helpers;

namespace FoodDeliveryApplication.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly UserManager<FoodDeliveryAppUser> _userManager;
        private readonly IRestaurantService _restaurantService;
        private readonly ICategoryService _categoryService;

        public RestaurantsController(UserManager<FoodDeliveryAppUser> userManager, IRestaurantService restaurantService, ICategoryService categoryService)
        {
            _userManager = userManager;
            _restaurantService = restaurantService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var loggedInUser = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (loggedInUser == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var loggedInUserInfo = await _userManager.FindByIdAsync(loggedInUser);

            var restaurants = _restaurantService.GetAllRestaurantsFromOwner(loggedInUser);

            if (restaurants == null || !restaurants.Any())
            {
                restaurants = new List<Restaurant>();
            }

            ViewBag.Restaurants = restaurants;

            return View();
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
            var categories = _categoryService.GetAllCategories();

            ViewBag.Categories = categories;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RestaurantDTO restaurantDTO, List<Guid> SelectedCategoryIds)
        {
            var loggedInUser = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(loggedInUser);

            var restaurant = CreateRestaurantHelper.CreateRestaurant(restaurantDTO, loggedInUser, user);
            
            if (ModelState.IsValid)
            {
                restaurant.CategoryInRestaurants = new List<CategoryInRestaurant>();

                foreach (var categoryId in SelectedCategoryIds)
                {
                    var category = _categoryService.GetDetailsForCategory(categoryId);

                    if (category != null)
                    {
                        restaurant.CategoryInRestaurants.Add(CreateCategoryInRestaurantHelper.CreateCategoryInRestaurant(restaurant, category));
                    }
                }

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
