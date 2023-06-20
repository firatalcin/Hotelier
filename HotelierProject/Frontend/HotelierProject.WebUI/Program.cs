using HotelierProject.DataAccess.Concrete.Contexts;
using HotelierProject.Entities.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ProjectContext>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<ProjectContext>();
builder.Services.AddHttpClient();
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
