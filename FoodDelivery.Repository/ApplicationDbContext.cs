using FoodDelivery.Domain.Domain;
using FoodDelivery.Domain.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static System.Net.Mime.MediaTypeNames;

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
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<FavoriteRestaurants> FavoriteRestaurants { get; set; }


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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedCategories(modelBuilder);
            SeedFoodCategories(modelBuilder);
        }

        private void SeedCategories(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = Guid.NewGuid(), Name = "Italian", Image = "../Images/italian.png" },
                new Category { Id = Guid.NewGuid(), Name = "Chinese", Image = "../Images/chinese.png" },
                new Category { Id = Guid.NewGuid(), Name = "Mexican", Image = "../Images/mexican.png" },
                new Category { Id = Guid.NewGuid(), Name = "Indian", Image = "../Images/indian.png" },
                new Category { Id = Guid.NewGuid(), Name = "American", Image = "../Images/american.png" },
                new Category { Id = Guid.NewGuid(), Name = "Greek", Image = "../Images/greek.jfif" },
                new Category { Id = Guid.NewGuid(), Name = "Vegan", Image = "../Images/vegan.png" },
                new Category { Id = Guid.NewGuid(), Name = "Vegetarian", Image = "../Images/vegetarian.png" },
                new Category { Id = Guid.NewGuid(), Name = "Healthy", Image = "../Images/healthy.png" },
                new Category { Id = Guid.NewGuid(), Name = "Asian", Image = "../Images/asian.png" },
                new Category { Id = Guid.NewGuid(), Name = "Breakfast", Image = "../Images/breakfast.png" },
                new Category { Id = Guid.NewGuid(), Name = "Desserts", Image = "../Images/desserts.png" }
            );
        }

        private void SeedFoodCategories(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodCategory>().HasData(
                new FoodCategory { Id = Guid.NewGuid(), Name = "Breakfast"},
                new FoodCategory { Id = Guid.NewGuid(), Name = "Salads" },
                new FoodCategory { Id = Guid.NewGuid(), Name = "Pasta"},
                new FoodCategory { Id = Guid.NewGuid(), Name = "Pizza" },
                new FoodCategory { Id = Guid.NewGuid(), Name = "Desserts" },
                new FoodCategory { Id = Guid.NewGuid(), Name = "Alcoholic Beverages" },
                new FoodCategory { Id = Guid.NewGuid(), Name = "Soft Drinks" },
                new FoodCategory { Id = Guid.NewGuid(), Name = "Hot Drinks" },
                new FoodCategory { Id = Guid.NewGuid(), Name = "Coffee"},
                new FoodCategory { Id = Guid.NewGuid(), Name = "Main Course" },
                new FoodCategory { Id = Guid.NewGuid(), Name = "Starters" },
                new FoodCategory { Id = Guid.NewGuid(), Name = "Brunch" },
                new FoodCategory { Id = Guid.NewGuid(), Name = "Burgers" },
                new FoodCategory { Id = Guid.NewGuid(), Name = "Sandwiches" },
                new FoodCategory { Id = Guid.NewGuid(), Name = "Juices" }
            );
        }
    }
}
