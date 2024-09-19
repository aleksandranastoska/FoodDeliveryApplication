using FoodDelivery.Domain.Domain;
using FoodDelivery.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace FoodDelivery.Repository.Implementation
{
    public class WishlistRepository : IWishlistRepository
    {
        private readonly ApplicationDbContext _context;
        private DbSet<Wishlist> entities;

        public WishlistRepository(ApplicationDbContext context)
        {
            _context = context;
            entities = context.Set<Wishlist>();
        }

        public void Delete(Wishlist wishlist)
        {
            CheckIfEntityIsNull(wishlist);
            entities.Remove(wishlist);
            _context.SaveChanges();
        }

        public IEnumerable<Wishlist> GetAllWishlists()
        {
            return entities
                .Include(w=>w.FoodInWishlists)
                .AsEnumerable();
        }

        public Wishlist GetWishlistById(Guid? id)
        {
            return entities
                .Include(w => w.FoodInWishlists)
                .SingleOrDefault(w => w.Id == id);
        }

        public Wishlist GetWishlistByUserId(string userId)
        {
            return entities
                .Include(w => w.FoodInWishlists)
                    .ThenInclude(fiw => fiw.Food) 
                .SingleOrDefault(w => w.UserId == userId);
        }

        public void Insert(Wishlist wishlist)
        {
            CheckIfEntityIsNull(wishlist);
            entities.Add(wishlist);
            _context.SaveChanges();
        }

        public void Update(Wishlist wishlist)
        {
            CheckIfEntityIsNull(wishlist);
            entities.Update(wishlist);
            _context.SaveChanges();
        }

        private void CheckIfEntityIsNull(Wishlist entity)
        {
            if (entity == null) 
            {
                throw new ArgumentNullException("entity"); 
            }
        }
    }
}
