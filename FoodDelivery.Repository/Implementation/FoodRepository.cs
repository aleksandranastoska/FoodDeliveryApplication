using FoodDelivery.Domain.Domain;
using FoodDelivery.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace FoodDelivery.Repository.Implementation
{
    public class FoodRepository : IFoodRepository
    {
        private readonly ApplicationDbContext _context;
        private DbSet<Food> entities;

        public FoodRepository(ApplicationDbContext context)
        {
            _context = context;
            entities = context.Set<Food>();
        }

        public void Delete(Food food)
        {
            CheckIfEntityIsNull(food);
            entities.Remove(food);
            _context.SaveChanges();
        }

        public IEnumerable<Food> GetAllFoods()
        {
            return entities.AsEnumerable();
        }

        public List<Food> GetAllFoodsForRestaurant(Guid? restaurantId)
        {
            return entities
                .Where(f => f.RestaurantId == restaurantId)
                .Include(f=>f.FoodCategory)
                .ToList();
        }

        public Food GetFoodById(Guid? id)
        {
            return entities.SingleOrDefault(f => f.Id == id);
        }

        public void Insert(Food food)
        {
            CheckIfEntityIsNull(food);
            entities.Add(food);
            _context.SaveChanges();
        }

        public void Update(Food food)
        {
            CheckIfEntityIsNull(food);
            entities.Update(food);
            _context.SaveChanges();
        }

        private void CheckIfEntityIsNull(Food entity)
        {
            if (entity == null) { 
                throw new ArgumentNullException("entity"); 
            }
        }
    }
}
