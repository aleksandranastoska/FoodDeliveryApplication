using FoodDelivery.Domain.Domain;
using FoodDelivery.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace FoodDelivery.Repository.Implementation
{
    public class FoodCategoryRepository : IFoodCategoryRepository
    {
        private readonly ApplicationDbContext _context;
        private DbSet<FoodCategory> entities;

        public FoodCategoryRepository(ApplicationDbContext context)
        {
            _context = context;
            entities = context.Set<FoodCategory>();
        }
        public IEnumerable<FoodCategory> GetAllFoodCategories()
        {
            return entities.AsEnumerable();
        }

        public FoodCategory GetFoodCategoryById(Guid? id)
        {
            return entities
                .SingleOrDefault(f => f.Id == id);
        }
    }
}
