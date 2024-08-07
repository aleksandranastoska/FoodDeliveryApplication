using FoodDelivery.Domain.Domain;

namespace FoodDelivery.Repository.Interface
{
    public interface IAddressRepository
    {
        IEnumerable<Address> GetAllAddresses();
        List<Address> GetAllAddressesForUser(string? userId);
        Address GetAddressById(Guid? id);
        void Insert(Address address);
        void Update(Address address);
        void Delete(Address address);
    }
}
