using CORE.Entities;
using CORE.Interfaces;
using INFRASTRUCTURE;
using INFRASTRUCTURE.Data;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericsRepository<>));
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BurgerDbContext>(options =>
{
options.UseSqlite(builder.Configuration.GetConnectionString("defaultConnection") ?? throw new InvalidOperationException("connection string not found"));
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseAuthorization();

app.MapControllers();

using var scope = app.Services.CreateScope();
var service = scope.ServiceProvider;
var context = service.GetRequiredService<BurgerDbContext>();
var logger = service.GetRequiredService<ILogger<Program>>();
try
{
    await context.Database.MigrateAsync();
    await SeedingService.Seed(context);
}
catch (Exception e)
{

    logger.LogError(e, "an error occured during migration");
}


app.Run();
