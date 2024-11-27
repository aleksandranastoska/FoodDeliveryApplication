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
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Collections.Specialized.BitVector32;
using GemBox.Document.Tables;
using GemBox.Document;

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
            if (id == null)
            {
                return NotFound();
            }

            var restaurant = _restaurantService.GetDetailsForRestaurant(id);

            if (restaurant == null)
            {
                return NotFound();
            }

            var loggedInUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var isOwner = restaurant.OwnerId == loggedInUserId;

            var isRegularUser = !isOwner;

            ViewBag.IsOwner = isOwner;
            ViewBag.IsRegularUser = isRegularUser;

            restaurant.IsAvailable = _isRestaurantAvailableHelper.IsRestaurantAvailable(restaurant);
            var isRestaurantFavorite = _restaurantService.IsRestaurantFavoriteForUser(loggedInUserId, restaurant.Id);
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

            if (restaurant == null)
            {
                return NotFound();
            }

            var loggedInUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (restaurant.OwnerId != loggedInUserId)
            {
                return Forbid(); 
            }


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
        }

        [HttpGet]
        public IActionResult ExportMenuToPDF(Guid restaurantId)
        {

            ComponentInfo.SetLicense("FREE-LIMITED-KEY");

            var restaurant = _restaurantService.GetDetailsForRestaurant(restaurantId);
            if (restaurant == null)
            {
                return NotFound();
            }

            var menu = restaurant.Menu;

            var document = new DocumentModel();

            var section = new GemBox.Document.Section(document);
            section.Blocks.Add(new Paragraph(document, $"Menu for {restaurant.Name}")
            {
                ParagraphFormat = new ParagraphFormat
                {
                    Alignment = HorizontalAlignment.Center,
                    SpaceAfter = 20 
                }
            });

            section.Blocks.Add(new Paragraph(document, $"Location: {restaurant.Location} ")
            {
                ParagraphFormat = new ParagraphFormat
                {
                    Alignment = HorizontalAlignment.Center,
                    SpaceAfter = 20
                }
            });

            var table = new GemBox.Document.Tables.Table(document);
            table.TableFormat.PreferredWidth = new TableWidth(100, TableWidthUnit.Percentage);

            var headerRow = new TableRow(document);
            headerRow.Cells.Add(new TableCell(document, new Paragraph(document, "Name")));
            headerRow.Cells.Add(new TableCell(document, new Paragraph(document, "Description")));
            headerRow.Cells.Add(new TableCell(document, new Paragraph(document, "Price")));
            table.Rows.Add(headerRow);

            foreach (var food in menu)
            {
                var row = new TableRow(document);
                row.Cells.Add(new TableCell(document, new Paragraph(document, food.Name)));
                row.Cells.Add(new TableCell(document, new Paragraph(document, food.Description ?? "N/A")));
                row.Cells.Add(new TableCell(document, new Paragraph(document, $"{food.Price:C}"))); 
                table.Rows.Add(row);
            }

            section.Blocks.Add(table);
            document.Sections.Add(section);

            using (var stream = new MemoryStream())
            {
                document.Save(stream, SaveOptions.PdfDefault);
                return File(stream.ToArray(), "application/pdf", $"{restaurant.Name}_Menu.pdf");
            }
        }

    }

}

