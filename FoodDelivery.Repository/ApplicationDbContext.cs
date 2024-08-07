using FoodDelivery.Domain.Domain;
using FoodDelivery.Domain.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FoodDelivery.Repository
{
    public class ApplicationDbContext : IdentityDbContext<FoodDeliveryAppUser>
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Address> Addresses{ get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryInRestaurant> CategoryInRestaurants { get; set; }
        public DbSet<FoodInOrder> FoodInOrders { get; set; }
        public DbSet<FoodInWishlist> FoodInWishlists { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .Build();

                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString, b => b.MigrationsAssembly("FoodDelivery.Repository"));
            }
        }
    }
}
