using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FoodDelivery.Domain.Domain;
using FoodDelivery.Repository;
using FoodDelivery.Service.Interface;
using Microsoft.AspNetCore.Identity;
using FoodDelivery.Domain.Identity;
using System.Security.Claims;
using FoodDelivery.Repository.Interface;
using FoodDelivery.Domain.DTO;
using FoodDelivery.Repository.Implementation;

namespace FoodDeliveryApplication.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;
        private readonly UserManager<FoodDeliveryAppUser> _userManager;
        private readonly IAddressRepository _addressRepository;

        public OrdersController(IOrderService orderService, IUserService userService, UserManager<FoodDeliveryAppUser> userManager, IAddressRepository addressRepository)
        {
            _orderService = orderService;
            _userService = userService;
            _userManager = userManager;
            _addressRepository = addressRepository;
        }

        public IActionResult Index(Guid orderId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId == null)
            {
                return Unauthorized();
            }

            var order = _orderService.GetDetailsForOrder(orderId);

            if (order == null || order.UserId != userId)
            {
                return NotFound();
            }

            var addresses = _addressRepository.GetAllAddressesForUser(userId);

            var model = new OrderDTO
            {
                Order = order,
                Addresses = addresses
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult ConfirmOrder(Guid orderId, Guid addressId)
        {
            var order = _orderService.GetDetailsForOrder(orderId);

            if (order == null)
            {
                return NotFound();
            }

            order.AddressId = addressId;
            _orderService.UpdateExistingOrder(order);

            return RedirectToAction("Index", "Profile");

        }
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = _orderService.GetDetailsForOrder(id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("UserId,Id")] Order order)
        {
            if (ModelState.IsValid)
            {
                order.Id = Guid.NewGuid();
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = _orderService.GetDetailsForOrder(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("UserId,Id")] Order order)
        {
            if (id != order.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.Id))
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
            return View(order);
        }

        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = _orderService.GetDetailsForOrder(id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var order = _orderService.GetDetailsForOrder(id);
            if (order != null)
            {
                
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> AllOrders(string? email)
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

            var orders = _userService.GetAllOrdersForUser(loggedInUserId);

            if (orders == null || !orders.Any())
            {
                orders = new List<Order>();
            }

            ViewBag.User = loggedInUser;
            ViewBag.Orders = orders;

            return View();
        }

        private bool OrderExists(Guid id)
        {
            return _orderService.GetDetailsForOrder(id) != null;
        }
    }
}
