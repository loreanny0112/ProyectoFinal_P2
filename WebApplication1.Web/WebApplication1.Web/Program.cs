using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using WebApplication1.Web.BL.Interfaces;
using WebApplication1.Web.BL.Services;
using WebApplication1.Web.Data.Context;
using WebApplication1.Web.Data.DBObjects;
using WebApplication1.Web.Data.Interfaces;
using WebApplication1.Web.Data.Models.Cliente;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<RestauranteContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("RestauranteContext")));

builder.Services.AddScoped<IClienteDb, ClienteDb>();

builder.Services.AddScoped<IEmpleadoDb, EmpleadoDb>();

//agregar las dependencias del BL//
builder.Services.AddTransient<IClienteService, ClienteService>();
builder.Services.AddTransient<IEmpleadoService, EmpleadoService>();

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
