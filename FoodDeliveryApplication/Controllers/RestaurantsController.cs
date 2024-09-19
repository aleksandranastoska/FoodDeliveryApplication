using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FoodDelivery.Domain.Domain;
using FoodDelivery.Service.Interface;
using System.Security.Claims;
using FoodDelivery.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using FoodDelivery.Domain.DTO;
using FoodDelivery.Domain.Helpers;
using NuGet.Packaging;

namespace FoodDeliveryApplication.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly UserManager<FoodDeliveryAppUser> _userManager;
        private readonly IRestaurantService _restaurantService;
        private readonly ICategoryService _categoryService;
        private readonly IFoodCategoryService _foodCategoryService;
        private readonly CreateRestaurantHelper _createRestaurantHelper;
        private readonly IsRestaurantAvailableHelper _isRestaurantAvailableHelper;

        public RestaurantsController(UserManager<FoodDeliveryAppUser> userManager, IRestaurantService restaurantService, ICategoryService categoryService, IFoodCategoryService foodCategoryService, CreateRestaurantHelper createRestaurantHelper, IsRestaurantAvailableHelper isRestaurantAvailableHelper)
        {
            _userManager = userManager;
            _restaurantService = restaurantService;
            _categoryService = categoryService;
            _foodCategoryService = foodCategoryService;
            _createRestaurantHelper = createRestaurantHelper;
            _isRestaurantAvailableHelper = isRestaurantAvailableHelper;
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

            restaurant.IsAvailable = _isRestaurantAvailableHelper.IsRestaurantAvailable(restaurant);

            var isRestaurantFavorite = _restaurantService.IsRestaurantFavoriteForUser(User.FindFirstValue(ClaimTypes.NameIdentifier), restaurant.Id);
            ViewBag.IsFavorite = isRestaurantFavorite;

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

            var restaurant = await _createRestaurantHelper.CreateRestaurant(restaurantDTO, loggedInUser);

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

        [HttpGet]
        public IActionResult CreateMenu(Guid Id)
        {
            var restaurant = _restaurantService.GetDetailsForRestaurant(Id);

            ViewBag.FoodCategories = _foodCategoryService.GetAllFoodCategories();
            ViewBag.Restaurant = restaurant;

            object menuDto = null;

            if (restaurant.Menu.Count != 0)
            {
                menuDto = new MenuDTO
                {
                    RestaurantId = restaurant.Id,
                    ExistingMenu = (List<Food>)restaurant.Menu,
                    NewMenu = new List<Food>()
                };
            }
            else
            {
                menuDto = new MenuDTO
                {
                    RestaurantId = restaurant.Id,
                    ExistingMenu = new List<Food>(),
                    NewMenu = new List<Food>()
                };
            }

            return View(menuDto);
        }
        [HttpPost]
        public IActionResult CreateMenu(MenuDTO menuDTO)
        {
            if (ModelState.IsValid)
            {
                var existingRestaurant = _restaurantService.GetDetailsForRestaurant(menuDTO.RestaurantId);

                Restaurant res = _createRestaurantHelper.CreateRestaurantFromMenu(existingRestaurant);

                if (existingRestaurant != null)
                {
                    foreach (var food in menuDTO.ExistingMenu)
                    {
                        food.RestaurantId = res.Id;
                    }

                    var newMenuItems = MenuCreator(menuDTO, res.Id);

                    _restaurantService.DeleteExistingRestaurant(existingRestaurant.Id);

                    res.Menu.AddRange(newMenuItems);
                    _restaurantService.CreateNewRestaurant(res);
                }

                return RedirectToAction("Details", new { id = res.Id });
            }
            ViewBag.FoodCategories = _foodCategoryService.GetAllFoodCategories();

            return View(menuDTO);
        }

        private bool RestaurantExists(Guid id)
        {
            return _restaurantService.GetDetailsForRestaurant(id) != null;
        }

        private bool CheckIfRestaurantIsNull(Guid? id)
        {
            return id == null;
        }
        private List<Food> MenuCreator(MenuDTO menuDTO, Guid id)
        {

            return menuDTO.NewMenu.Select(food => new Food
            {
                Id = Guid.NewGuid(),
                Name = food.Name,
                Price = food.Price,
                Description = food.Description,
                FoodCategoryId = food.FoodCategoryId,
                RestaurantId = id
            }).ToList();
        }}
    
    }

