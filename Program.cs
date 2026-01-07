using aspnet1.Entity;
using aspnet1.Services;
using aspnet1.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// DbContext
var connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(connection, ServerVersion.AutoDetect(connection)));

// сервисы
builder.Services.AddSingleton<IMainService, MainService>();

// контроллеры
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.Use(async (context, next) => {
    await next();
    if (context.Response.StatusCode == 404) {
        context.Response.Redirect("/");
    }
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Main}/{action=MainPage}"
);

app.Run();
