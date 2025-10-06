using GardenHelper.Server;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<PlantDbContext>(options =>
options.UseSqlite(@"DataSource=./Garden.db"));

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "_Localhost",
                      policy =>
                      {

                          policy.WithOrigins("https://localhost:61897")
                                .AllowAnyHeader()
                                .AllowAnyMethod();
                      });
});

var app = builder.Build();


app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.

app.UseCors("_Localhost");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
