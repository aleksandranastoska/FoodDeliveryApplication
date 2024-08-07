using FoodDelivery.Domain.Identity;

namespace FoodDelivery.Repository.Interface
{
    public interface IUserRepository
    {
        IEnumerable<FoodDeliveryAppUser> GetAll();
        FoodDeliveryAppUser Get(string? id);
        void Insert(FoodDeliveryAppUser user);
        void Update(FoodDeliveryAppUser user);
        void Delete(FoodDeliveryAppUser user);
    }
}
