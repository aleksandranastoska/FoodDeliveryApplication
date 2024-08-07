using FoodDelivery.Domain.Domain;
using FoodDelivery.Domain.Identity;
using FoodDelivery.Repository.Interface;
using FoodDelivery.Service.Interface;

namespace FoodDelivery.Service.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IAddressRepository _addressRepository;

        public UserService(IUserRepository userRepository, IAddressRepository addressRepository)
        {
            _userRepository = userRepository;
            _addressRepository = addressRepository;
        }

        public void AddAddress(Address address)
        {
            _addressRepository.Insert(address);
        }

        public List<Address> GetAllAddressesForUser(string? id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return new List<Address>();
            }

            var addresses = _addressRepository.GetAllAddressesForUser(id);
            return addresses ?? new List<Address>();
        }

        public List<FoodDeliveryAppUser> GetAllUsers()
        {
            return _userRepository.GetAll().ToList();
        }

        public FoodDeliveryAppUser GetDetailsForUser(string? id)
        {
            return _userRepository.Get(id);
        }
    }
}
