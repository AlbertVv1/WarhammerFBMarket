using Microsoft.EntityFrameworkCore;
using WarhammerFBMarket.BL.Implementations;
using WarhammerFBMarket.BL.Interfaces;
using WarhammerFBMarket.DAL;
using WarhammerFBMarket.DAL.Interfaces;
using WarhammerFBMarket.DAL.Repositories;

var builder = WebApplication.CreateBuilder(args);
var connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
	options.UseNpgsql(connection));

builder.Services.AddScoped<MiniatureRepository, MiniatureRepository>();
builder.Services.AddScoped<MiniatureBL, MiniatureBL>();

// Add services to the container.
builder.Services.AddControllersWithViews();


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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
