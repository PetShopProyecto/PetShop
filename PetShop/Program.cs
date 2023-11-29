using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using PetShop.Data;
using PetShop.Models;
using Microsoft.EntityFrameworkCore;
using PetShop.Data.Acceso;
using PetShop.Data.Productos;
using PetShop.Data.Ventas;
using PetShop.Data.Usuarios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<IIngresar,Ingresar>();
builder.Services.AddScoped<ICProductos,CProductos>();
builder.Services.AddScoped<ICUsuarios, CUsuarios>();

builder.Services.AddDbContext<TiendapetshopContext>(op => { 
    op.UseSqlServer(builder.Configuration.GetConnectionString("cadenaSQL"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
