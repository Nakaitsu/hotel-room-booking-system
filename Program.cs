using Microsoft.EntityFrameworkCore;
using Prototype.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddDbContext<MainDbContext>(opts => {
  opts.UseSqlServer(
    builder.Configuration["ConnectionStrings:HotelProjectConnection"]
  );
});
builder.Services.AddScoped<IHotelRepository, EFHotelRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler("/Error");
app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
  endpoints.MapDefaultControllerRoute();
});

RoomSeedData.EnsurePopulated(app);

app.Run();
