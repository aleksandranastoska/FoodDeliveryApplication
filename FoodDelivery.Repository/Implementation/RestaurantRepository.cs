using FoodDelivery.Domain.Domain;
using FoodDelivery.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace FoodDelivery.Repository.Implementation
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly ApplicationDbContext _context;
        private DbSet<Restaurant> entities;

        public RestaurantRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Delete(Restaurant restaurant)
        {
            CheckIfEntityIsNull(restaurant);
            entities.Remove(restaurant);
            _context.SaveChanges();
        }

        public IEnumerable<Restaurant> GetAllRestaurants()
        {
            return entities.AsEnumerable();
        }

        public Restaurant GetRestaurantById(Guid? id)
        {
            return entities.SingleOrDefault(r => r.Id == id);
        }

        public void Insert(Restaurant restaurant)
        {
            CheckIfEntityIsNull(restaurant);
            entities.Add(restaurant);
            _context.SaveChanges();
        }

        public void Update(Restaurant restaurant)
        {
            CheckIfEntityIsNull(restaurant);
            entities.Update(restaurant);
            _context.SaveChanges();
        }

        private void CheckIfEntityIsNull(Restaurant entity)
        {
            if (entity == null) 
            { 
                throw new ArgumentNullException("entity"); 
            }
        }
    }
}
