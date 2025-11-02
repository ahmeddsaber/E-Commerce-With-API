using APIGenerationProject.Models.Model;
using APIGenerationProject.Repository.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APIGenerationProject.Context
{
    public class ProjectContext : IdentityDbContext<ApplicationUser>
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) { }

        public ProjectContext() { }

        public DbSet<Catogery> Catogeries { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=DESKTOP-8F7PSID;Database=ApiGenerationDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Product ↔ Catogery
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Catogery)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CatogeryId);

            // Order ↔ OrderItem
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderId);

            // Product ↔ OrderItem
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Product)
                .WithMany()
                .HasForeignKey(oi => oi.ProductId);

            // Cart ↔ CartItem
            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Cart)
                .WithMany(c => c.CartItems)
                .HasForeignKey(ci => ci.CartId);

            // Product ↔ CartItem
            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Product)
                .WithMany()
                .HasForeignKey(ci => ci.ProductId);

            //Order
              modelBuilder.Entity<Order>()
    .Property(o => o.TotalAmount)
    .HasColumnType("decimal(18,2)");

            // ✅ Seed Data
            modelBuilder.Entity<Catogery>().HasData(
                new Catogery { Id = 1, Name = "Electronics", Description = "Devices and gadgets" },
                new Catogery { Id = 2, Name = "Clothes", Description = "Men and Women Clothes" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Description = "Gaming Laptop",
                    Price = 25000,
                    Stock = 5,
                    CatogeryId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "T-Shirt",
                    Description = "Cotton T-Shirt",
                    Price = 250,
                    Stock = 50,
                    CatogeryId = 2
                }
            );

            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 1, TotalAmount = 25250, OrderDate = DateTime.Now }
            );

            modelBuilder.Entity<OrderItem>().HasData(
                new OrderItem { Id = 1, OrderId = 1, ProductId = 1, Quantity = 1, UnitPrice = 25000 },
                new OrderItem { Id = 2, OrderId = 1, ProductId = 2, Quantity = 1, UnitPrice = 250 }
            );

            modelBuilder.Entity<Cart>().HasData(
                new Cart { Id = 1 }
            );

            modelBuilder.Entity<CartItem>().HasData(
                new CartItem { Id = 1, CartId = 1, ProductId = 2, Quantity = 2 , UnitPrice=300 }
            );
        }
    }
}
