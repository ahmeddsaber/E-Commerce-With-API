using APIGenerationProject.Context;
using APIGenerationProject.GenericRepository;
using APIGenerationProject.Repository.Model;
using APIGenerationProject.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;

namespace APIGenerationProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // ? Register the database context
            builder.Services.AddDbContext<ProjectContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // ? Register all Generic Repositories
            builder.Services.AddScoped<GenericRepository<Catogery>>();
            builder.Services.AddScoped<GenericRepository<Product>>();
            builder.Services.AddScoped<GenericRepository<Order>>();
            builder.Services.AddScoped<GenericRepository<OrderItem>>();
            builder.Services.AddScoped<GenericRepository<Cart>>();
            builder.Services.AddScoped<GenericRepository<CartItem>>();

            // ? Register UnitOfWork
            builder.Services.AddScoped<UnitOfWork>();

            // ? Configure controllers and handle JSON circular references
            builder.Services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                });

            // ? Add and configure Swagger (OpenAPI)
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "?? E-Commerce API",
                    Version = "v1",
                    Description = "API for managing Categories, Products, Orders, and Carts using ASP.NET Core and Entity Framework.",
                    Contact = new OpenApiContact
                    {
                        Name = "Ahmed Saber",
                        Email = "AhmedSaber@example.com",
                        Url = new Uri("https://github.com/ahmedsaber")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "MIT License",
                        Url = new Uri("https://opensource.org/licenses/MIT")
                    }
                });
            });

            var app = builder.Build();

            // ? Configure HTTP request pipeline
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "E-Commerce API v1");
                    c.DocumentTitle = "E-Commerce Swagger UI";
                });
            }

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
