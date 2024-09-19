using FoodDelivery.Domain.Domain;
using FoodDelivery.Domain.DTO;
using FoodDelivery.Domain.Identity;
using FoodDelivery.Service.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FoodDeliveryApplication.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<FoodDeliveryAppUser> _userManager;
        private readonly IUserService _userService;

        public ProfileController(UserManager<FoodDeliveryAppUser> userManager, IUserService userService)
        {
            _userManager = userManager;
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            var loggedInUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (loggedInUserId == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var loggedInUser = await _userManager.FindByIdAsync(loggedInUserId);

            if (loggedInUser == null)
            {
                return NotFound("User not found");
            }

            return View(loggedInUser);
        }
        public async Task<IActionResult> Addresses(string? email)
        {
            var loggedInUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (loggedInUserId == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var loggedInUser = await _userManager.FindByIdAsync(loggedInUserId);

            if (loggedInUser == null)
            {
                return NotFound("User not found");
            }

            if (string.IsNullOrEmpty(email))
            {
                email = loggedInUser.Email; 
            }

            var addresses = _userService.GetAllAddressesForUser(loggedInUserId);

            if (addresses == null || !addresses.Any())
            {
                addresses = new List<Address>();
            }

            ViewBag.User = loggedInUser;
            ViewBag.Addresses = addresses;

            return View();
        }
        public IActionResult AddAddress()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddAddress(AddressDTO model)
        {
            var loggedInUser = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var address = new Address
            {
                Id = new Guid(),
                Title = model.Title,
                Street = model.Street,
                Number = model.Number,
                Flat = model.Flat,
                OwnerId = loggedInUser,
                Owner = await _userManager.FindByIdAsync(loggedInUser)
            };

            if (ModelState.IsValid)
            {   
                _userService.AddAddress(address);

                return RedirectToAction("Addresses");
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddToFavorites(Guid restaurantId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); 
            if (userId == null)
            {
                return Unauthorized(); 
            }

            var result = await _userService.AddToFavorites(userId, restaurantId);

            if (!result)
            {
                return StatusCode(500, "Unable to add to favorites"); 
            }

            return Ok();
        }

    }
}
