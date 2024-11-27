using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FoodDelivery.Domain.Domain;
using FoodDelivery.Repository;
using System.Runtime.CompilerServices;
using FoodDelivery.Repository.Interface;
using FoodDelivery.Service.Interface;

namespace FoodDeliveryApplication.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        public IActionResult Index()
        {
            return View(_categoryService.GetAllCategories());
        }

        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = _categoryService.GetDetailsForCategory(id);

            var restaurants = _categoryService.GetAllRestaurants(id);

            ViewBag.Restaurants = restaurants;


            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }
    }
}
