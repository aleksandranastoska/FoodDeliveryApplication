using FoodDelivery.Domain.Domain;
using FoodDelivery.Domain.Identity;
using FoodDelivery.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace FoodDelivery.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        private DbSet<FoodDeliveryAppUser> entities;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
            entities = context.Set<FoodDeliveryAppUser>();
        }

        public void Delete(FoodDeliveryAppUser user)
        {
            CheckIfUserIsNull(user);
            entities.Remove(user);
            _context.SaveChanges();
        }

        public FoodDeliveryAppUser Get(string? id)
        {
            return entities
                .Include(u=>u.FavoriteRestaurants)
                .Include(u=>u.Wishlist)
                .Include("Wishlist.FoodInWishlists")
                .Include("Wishlist.FoodInWishlists.Food")
                .SingleOrDefault(u => u.Id == id);
        }

        public IEnumerable<FoodDeliveryAppUser> GetAll()
        {
            return entities
                .Include(owner=>owner.FavoriteRestaurants)
                .AsEnumerable();
        }

        public void Insert(FoodDeliveryAppUser user)
        {
            CheckIfUserIsNull(user);
            entities.Add(user);
            _context.SaveChanges();
        }

        public void Update(FoodDeliveryAppUser user)
        {
            CheckIfUserIsNull(user);
            entities.Update(user);
            _context.SaveChanges();
        }
        private void CheckIfUserIsNull(FoodDeliveryAppUser user)
        {
            if (user == null) 
            { 
                throw new ArgumentNullException("user"); 
            }
        }
    }
}
