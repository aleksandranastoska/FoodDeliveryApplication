using FoodDelivery.Domain.Domain;
using FoodDelivery.Domain.DTO;
using FoodDelivery.Domain.Identity;
using FoodDelivery.Repository.Interface;
using FoodDelivery.Service.Implementation;
using FoodDelivery.Service.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace FoodDeliveryApplication.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<FoodDeliveryAppUser> _userManager;
        private readonly IUserService _userService;
        private readonly IAddressRepository _addressRepository;
        public ProfileController(UserManager<FoodDeliveryAppUser> userManager, IUserService userService, IAddressRepository addressRepository)
        {
            _userManager = userManager;
            _userService = userService;
            _addressRepository = addressRepository;
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

                return RedirectToAction("Index");
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

        public IActionResult DeleteAddress(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var address = _addressRepository.GetAddressById(id);

            if (address == null)
            {
                return NotFound();
            }

            return View(address);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var address = _addressRepository.GetAddressById(id);
            _addressRepository.Delete(address);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit()
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

            var userDto = new UserDTO
            {
                Email = loggedInUser.Email,
                FirstName = loggedInUser.FirstName,
                LastName = loggedInUser.LastName,
                PhoneNumber = loggedInUser.PhoneNumber
            };

            return View(userDto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("Email,FirstName,LastName,PhoneNumber")] UserDTO editUser)
        {
            if (ModelState.IsValid)
            {
                var loggedInUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                try
                {
                    var user = await _userManager.FindByIdAsync(loggedInUserId);

                    if (user == null)
                    {
                        return NotFound();
                    }

                    user.FirstName = editUser.FirstName;
                    user.LastName = editUser.LastName;
                    user.PhoneNumber = editUser.PhoneNumber;

                    _userService.UpdateExistingUser(user);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(editUser.Email))
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
            return View(editUser);
        }

        private bool UserExists(String id)
        {
            return _userService.GetDetailsForUser(id) != null;
        }
    }
}
