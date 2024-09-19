using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FoodDelivery.Domain.Domain;
using FoodDelivery.Service.Interface;
using FoodDelivery.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using FoodDelivery.Repository.Interface;

namespace FoodDeliveryApplication.Controllers
{
    public class WishlistsController : Controller
    {
        private readonly IWishlistService _wishlistService;
        private readonly IUserService _userService;
        private readonly UserManager<FoodDeliveryAppUser> _userManager;
        private readonly IOrderRepository _orderRepository;

        public WishlistsController(IWishlistService wishlistService, IUserService userService, UserManager<FoodDeliveryAppUser> userManager, IOrderRepository orderRepository)
        {
            _wishlistService = wishlistService;
            _userService = userService;
            _userManager = userManager;
            _orderRepository = orderRepository;
        }

        public IActionResult Index()
        {
            var loggedInUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var wishlist = _wishlistService.GetWishlistInfo(loggedInUserId);

            return View(wishlist);
        }

        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wishlist = _wishlistService.GetDetailsForWishlist(id);

            if (wishlist == null)
            {
                return NotFound();
            }

            return View(wishlist);
        }

        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_userService.GetAllUsers(), "Id", "Id");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("UserId,Id")] Wishlist wishlist)
        {
            if (ModelState.IsValid)
            {
                wishlist.Id = Guid.NewGuid();
                _wishlistService.CreateNewWishlist(wishlist);
                return RedirectToAction(nameof(Index));
            }

            ViewData["UserId"] = new SelectList(_userService.GetAllUsers(), "Id", "Id", wishlist.UserId);

            return View(wishlist);
        }

        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wishlist = _wishlistService.GetDetailsForWishlist(id);

            if (wishlist == null)
            {
                return NotFound();
            }

            ViewData["UserId"] = new SelectList(_userService.GetAllUsers(), "Id", "Id", wishlist.UserId);

            return View(wishlist);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("UserId,Id")] Wishlist wishlist)
        {
            if (id != wishlist.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _wishlistService.UpdateExistingWishlist(wishlist);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WishlistExists(wishlist.Id))
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

            ViewData["UserId"] = new SelectList(_userService.GetAllUsers(), "Id", "Id", wishlist.UserId);

            return View(wishlist);
        }

        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wishlist = _wishlistService.GetDetailsForWishlist(id);

            if (wishlist == null)
            {
                return NotFound();
            }

            return View(wishlist);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _wishlistService.DeleteExistingWishlist(id);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeleteFromWishlist(Guid id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _wishlistService.deleteFoodFromWishlist(userId, id);

            return RedirectToAction("Index");
        }

        private bool WishlistExists(Guid id)
        {
            return _wishlistService.GetDetailsForWishlist(id) != null;
        }

        [HttpPost]
        public async Task<IActionResult> PlaceOrder()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId == null)
            {
                return Unauthorized();
            }

            var wishlist = _wishlistService.GetUserWishlist(userId);

            if (wishlist == null || !wishlist.FoodInWishlists.Any())
            {
                return BadRequest("No items in wishlist.");
            }

            var newOrder = new Order
            {
                UserId = userId,
                Owner = _userManager.FindByIdAsync(userId).Result,
                FoodsInOrder = wishlist.FoodInWishlists.Select(w => new FoodInOrder
                {
                    FoodId = w.FoodId,
                    Quantity = w.Quantity,
                    Price = w.Food.Price??0.0,
                    OrderId = Guid.NewGuid() 
                }).ToList()
            };

            _orderRepository.Insert(newOrder);

            wishlist.FoodInWishlists.Clear();
            _wishlistService.UpdateExistingWishlist(wishlist);

            return RedirectToAction("Index", "Orders", new { orderId = newOrder.Id });
        }
    }
}
