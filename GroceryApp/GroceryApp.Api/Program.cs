
using GroceryApp.Api.Constants;
using GroceryApp.Api.Data;
using GroceryApp.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace GroceryApp.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<DataContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString(DatabaseConstants.GroceryConnectionStringKey)));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();


            var summaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

            app.MapGet("/weatherforecast", (HttpContext httpContext) =>
            {
                var forecast = Enumerable.Range(1, 5).Select(index =>
                    new WeatherForecast
                    {
                        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                        TemperatureC = Random.Shared.Next(-20, 55),
                        Summary = summaries[Random.Shared.Next(summaries.Length)]
                    })
                    .ToArray();
                return forecast;
            })
            .WithName("GetWeatherForecast")
            .WithOpenApi();


            var masterGroup = app.MapGroup("/master").AllowAnonymous();
            masterGroup.MapGet("/categories", async (DataContext context) =>
               TypedResults.Ok(await context.Categories 
                .AsNoTracking()
                .ToArrayAsync()
                )
             );
            masterGroup.MapGet("/offers", async (DataContext context) =>
                TypedResults.Ok(await context.Offers
                .AsNoTracking()
                .ToArrayAsync()
                )
             );

            app.MapGet("/popular-products", async (DataContext context, int? count) =>
            {
                if (!count.HasValue || count <= 0)
                    count = 6;

                var randomProducts = await context.Products.AsNoTracking()
                                        .OrderBy(p=> Guid.NewGuid())
                                        .Take(count.Value)
                                        .Select(Product.DtoSelector)
                                        .ToArrayAsync();

                return TypedResults.Ok(randomProducts);
            });

            app.Run("https://localhost:12345");
        }
    }
}
