using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Railway_Group01.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("AppDbContextConnection") ?? throw new InvalidOperationException("Connection string 'AppDbContextConnection' not found.");

builder.Services.AddDbContext<RailwayDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedEmail = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<RailwayDbContext>();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;

});

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDistributedMemoryCache();
//Adding the IHttpContextAccessor servive to the Dependency Injection IOC Container
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(100);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseSession();
app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Railway}/{action=Index}/{id?}");

app.MapControllerRoute(
     name: "TrainScheduleByMonth",
     pattern: "{controller=ScheduleMaster}/{action=TrainScheduleByMonth}/{month?}");
app.MapControllerRoute(
    name: "TrainScheduleByYear",
    pattern: "{controller=ScheduleMaster}/{action=TrainScheduleByYear}/{year?}");
app.MapRazorPages();

using (var scope = app.Services.CreateScope())
{
    var roleManager = 
        scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

    var roles = new[] { "Admin", "Passenger" };

    foreach (var role in roles)
    {
        if (!await roleManager.RoleExistsAsync(role))
            await roleManager.CreateAsync(new IdentityRole(role));
    }
}

using (var scope = app.Services.CreateScope())
{
    var userManager =
        scope.ServiceProvider.GetRequiredService<UserManager<User>>();

    string username = "admin";
    string password = "admin123";

    if (await userManager.FindByNameAsync(username) == null)
    {
        var user = new User();
        user.UserName = username;

        var result = await userManager.CreateAsync(user, password);
        
        await userManager.AddToRoleAsync(user, "Admin");
    }
}

app.Run();
