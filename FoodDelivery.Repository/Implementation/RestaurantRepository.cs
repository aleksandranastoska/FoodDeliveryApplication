using FoodDelivery.Domain.Domain;
using FoodDelivery.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace FoodDelivery.Repository.Implementation
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly ApplicationDbContext _context;
        private DbSet<Restaurant> entities;
        private DbSet<CategoryInRestaurant> categoryInRestaurants;
        

        public RestaurantRepository(ApplicationDbContext context)
        {
            _context = context;
            entities = context.Set<Restaurant>();
            categoryInRestaurants = context.Set<CategoryInRestaurant>();
        }

        public void Delete(Restaurant restaurant)
        {
            CheckIfEntityIsNull(restaurant);
            entities.Remove(restaurant);
            _context.SaveChanges();
        }

        public IEnumerable<Restaurant> GetAllRestaurantFromOwner(string ownerId)
        {
            if (string.IsNullOrEmpty(ownerId))
            {
                throw new ArgumentNullException(nameof(ownerId));
            }

            var entities = _context.Restaurants.AsQueryable();

            if (entities == null)
            {
                return new List<Restaurant>();
            }

            return entities
                .Where(r => r.OwnerId == ownerId);
        }

        public IEnumerable<Restaurant> GetAllRestaurants()
        {
            return entities.AsEnumerable();
        }

        public IEnumerable<Category> GetCategoriesForRestaurant(Guid restaurantId)
        {
            var selectedCategories =  categoryInRestaurants
                .Where(u => u.RestaurantId == restaurantId)
                .AsEnumerable();

            var categoriesIds = new List<Guid>();

            foreach (var category in selectedCategories) {
                categoriesIds.Add(category.CategoryId);
            }

            var categories = new List<Category>();

            foreach (var categoryId in categoriesIds) {
                var category = _context.Categories
                    .SingleOrDefault(c => c.Id == categoryId);

                categories.Add(category);
            }

            return categories.AsEnumerable();
        }

        public Restaurant GetRestaurantById(Guid? id)
        {
            return entities
                .Include(r=>r.Owner)
                .Include(r=>r.Menu)
                .ThenInclude(f => f.FoodCategory)
                .SingleOrDefault(r => r.Id == id);
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
