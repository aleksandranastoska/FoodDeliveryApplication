using FoodDelivery.Domain.Helpers;
using FoodDelivery.Domain.Identity;
using FoodDelivery.Domain.Payment;
using FoodDelivery.Repository;
using FoodDelivery.Repository.Implementation;
using FoodDelivery.Repository.Interface;
using FoodDelivery.Service.Implementation;
using FoodDelivery.Service.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<StripeSettings>(builder.Configuration.GetSection("StripeSettings"));
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
builder.Services.AddScoped(typeof(IFoodCategoryRepository), typeof(FoodCategoryRepository));

builder.Services.AddTransient<IFoodService, FoodService>();
builder.Services.AddTransient<IRestaurantService, RestaurantService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<IFoodCategoryService, FoodCategoryService>();
builder.Services.AddTransient<IWishlistService, WishlistService>();
builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddControllersWithViews().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

builder.Services.AddScoped<CreateRestaurantHelper>();
builder.Services.AddTransient<IsRestaurantAvailableHelper>();

builder.Services.AddDefaultIdentity<FoodDeliveryAppUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Define the images directory under wwwroot
var imagesPath = Path.Combine(app.Environment.WebRootPath, "Images");

// Ensure the directory exists
if (!Directory.Exists(imagesPath))
{
    Console.WriteLine($"Directory not found: {imagesPath}");
    Directory.CreateDirectory(imagesPath);
}

// Serve static files from the images directory
//app.UseStaticFiles(new StaticFileOptions
//{
//    FileProvider = new PhysicalFileProvider(imagesPath),
//    RequestPath = "/Images"
//});

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