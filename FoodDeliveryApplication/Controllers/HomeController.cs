using FoodDelivery.Service.Interface;
using FoodDeliveryApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FoodDeliveryApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryService _categoryService;
        private readonly IRestaurantService _restaurantService;

        public HomeController(ILogger<HomeController> logger, ICategoryService categoryService, IRestaurantService restaurantService)
        {
            _logger = logger;
            _categoryService = categoryService;
            _restaurantService = restaurantService;
        }

        public IActionResult Index()
        {
            ViewBag.Categories = _categoryService.GetAllCategories();
            ViewBag.Restaurants = _restaurantService.GetAllRestaurants();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
