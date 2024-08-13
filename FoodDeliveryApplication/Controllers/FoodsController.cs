using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FoodDelivery.Domain.Domain;
using FoodDelivery.Service.Interface;

namespace FoodDeliveryApplication.Controllers
{
    public class FoodsController : Controller
    {
        private readonly IFoodService _foodService;
        private readonly IRestaurantService restaurantService;

        public FoodsController(IFoodService foodService, IRestaurantService restaurantService)
        {
            _foodService = foodService;
            this.restaurantService = restaurantService;
        }


        public IActionResult Index()
        {
            return View(_foodService.GetAllFoods());
        }

        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var food = _foodService.GetDetailsForFood(id);

            if (food == null)
            {
                return NotFound();
            }

            return View(food);
        }

        public IActionResult Create()
        {
            ViewData["RestaurantId"] = new SelectList(restaurantService.GetAllRestaurants(), "Id", "Id");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,Price,Image,Description,RestaurantId,Id")] Food food)
        {
            if (ModelState.IsValid)
            {
                food.Id = Guid.NewGuid();
                _foodService.CreateNewFood(food);
                return RedirectToAction(nameof(Index));
            }

            ViewData["RestaurantId"] = new SelectList(restaurantService.GetAllRestaurants(), "Id", "Id", food.RestaurantId);

            return View(food);
        }

        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var food = _foodService.GetDetailsForFood(id);

            if (food == null)
            {
                return NotFound();
            }

            ViewData["RestaurantId"] = new SelectList(restaurantService.GetAllRestaurants(), "Id", "Id", food.RestaurantId);
            
            return View(food);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("Name,Price,Image,Description,RestaurantId,Id")] Food food)
        {
            if (id != food.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _foodService.UpdateExistingFood(food);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FoodExists(food.Id))
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
            
            ViewData["RestaurantId"] = new SelectList(restaurantService.GetAllRestaurants(), "Id", "Id", food.RestaurantId);
            
            return View(food);
        }

        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var food = _foodService.GetDetailsForFood(id);
            
            if (food == null)
            {
                return NotFound();
            }

            return View(food);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var restaurantId = _foodService.GetDetailsForFood(id).RestaurantId;
            _foodService.DeleteExistingFood(id);

            return RedirectToAction("Details", "Restaurants", new { id = restaurantId });
        }

        private bool FoodExists(Guid id)
        {
            return _foodService.GetDetailsForFood(id) != null;
        }
    }
}
