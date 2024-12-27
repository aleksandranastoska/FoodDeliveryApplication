using FoodDelivery.Domain.Domain;
using FoodDelivery.Domain.Identity;

namespace FoodDelivery.Service.Interface
{
    public interface IUserService
    {
        List<FoodDeliveryAppUser> GetAllUsers();
        FoodDeliveryAppUser GetDetailsForUser(string? id);
        List<Address> GetAllAddressesForUser(string? id);
        void AddAddress(Address address);
        Task<bool> AddToFavorites(string userId, Guid restaurantId);
        void UpdateExistingUser(FoodDeliveryAppUser user);
        List<Order> GetAllOrdersForUser(string? id);
    }
}
