using FoodDelivery.Domain.Domain;
using FoodDelivery.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace FoodDelivery.Repository.Implementation
{
    public class AddressRepository : IAddressRepository
    {
        private readonly ApplicationDbContext _context;
        private DbSet<Address> entities;

        public AddressRepository(ApplicationDbContext context)
        {
            _context = context;
            entities = context.Set<Address>();
        }

        public void Delete(Address address)
        {
            CheckIfEntityIsNull(address);
            entities.Remove(address);
            _context.SaveChanges();
        }

        public Address GetAddressById(Guid? id)
        {
            return entities.SingleOrDefault(a => a.Id == id);
        }

        public IEnumerable<Address> GetAllAddresses()
        {
            return entities.AsEnumerable();
        }

        public List<Address> GetAllAddressesForUser(string? userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                throw new ArgumentNullException(nameof(userId));
            }

            var entities = _context.Addresses.AsQueryable();

            if (entities == null)
            {
                return new List<Address>();
            }

            return entities.Where(address => address.OwnerId == userId).ToList();
        }

        public void Insert(Address address)
        {
            CheckIfEntityIsNull(address);
            entities.Add(address);
            _context.SaveChanges();
        }

        public void Update(Address address)
        {
            CheckIfEntityIsNull(address);
            entities.Update(address);
            _context.SaveChanges();
        }

        private void CheckIfEntityIsNull(Address entity)
        {
            if (entity == null) { 
                throw new ArgumentNullException("entity"); 
            }
        }
    }
}
