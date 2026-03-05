using Akses.App.Configuration;
using Akses.App.Models.Repositories;
using Akses.DataModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

builder.Services.AddAutoMapper(typeof(MapperConfig));

builder.Services.AddScoped<IMedicineInventoryRepo, MedicineInventoryRepo>();
builder.Services.AddScoped<IPurchaseOrderRepo, PurchaseOrderRepo>();

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 3;

    options.SignIn.RequireConfirmedPhoneNumber = false;
    options.SignIn.RequireConfirmedEmail = false;


}).AddEntityFrameworkStores<AppDbContext>();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/SignIn";
    options.LogoutPath = "/Account/SignOut";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(15);
    options.SlidingExpiration = true;
});


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();

app.UseRouting();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
