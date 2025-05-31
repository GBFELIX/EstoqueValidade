using InventarioValidade.Views.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;   

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.  
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
   options.UseMySql(
       builder.Configuration.GetConnectionString("DefaultConnection"),
       ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))));
   

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
   pattern: "{controller=Produtos}/{action=Index}/{id?}");

app.Run();
