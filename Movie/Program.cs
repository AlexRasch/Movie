using Movie.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddTransient<MoviesService>();



var app = builder.Build();

app.UseRouting();

app.UseEndpoints(o => o.MapControllers());

app.UseStaticFiles();

app.Run();