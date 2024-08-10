using FoodDelivery.Domain.Domain;
using FoodDelivery.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace FoodDelivery.Repository.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        private DbSet<Category> entities;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
            entities = context.Set<Category>();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return entities.AsEnumerable();
        }

        public Category GetCategoryById(Guid? id)
        {
            return entities
                .SingleOrDefault(c => c.Id == id);
        }
    }
}
