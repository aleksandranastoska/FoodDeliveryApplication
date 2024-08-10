using FoodDelivery.Domain.Identity;
using FoodDelivery.Repository;
using FoodDelivery.Repository.Implementation;
using FoodDelivery.Repository.Interface;
using FoodDelivery.Service.Implementation;
using FoodDelivery.Service.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
builder.Services.AddScoped(typeof(IFoodRepository), typeof(FoodRepository));
builder.Services.AddScoped(typeof(IOrderRepository), typeof(OrderRepository));
builder.Services.AddScoped(typeof(IRestaurantRepository), typeof(RestaurantRepository));
builder.Services.AddScoped(typeof(IWishlistRepository), typeof(WishlistRepository));
builder.Services.AddScoped(typeof(IAddressRepository), typeof(AddressRepository));
builder.Services.AddScoped(typeof(ICategoryRepository), typeof(CategoryRepository));

builder.Services.AddTransient<IFoodService, FoodService>();
builder.Services.AddTransient<IRestaurantService, RestaurantService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<ICategoryService, CategoryService>();

builder.Services.AddDefaultIdentity<FoodDeliveryAppUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();

void SeedRoles(IApplicationBuilder app)
{
    using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
    {
        var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        var roles = new[] { "Owner", "Regular" };

        foreach (var role in roles)
        {
            if (!roleManager.RoleExistsAsync(role).Result)
            {
                roleManager.CreateAsync(new IdentityRole(role)).Wait();
            }
        }
    }
}