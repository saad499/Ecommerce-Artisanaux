using Artisanaux.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Artisanaux.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) {}

        public DbSet<Productcs> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Productcs>().HasData(new Productcs
            {
                IdProduct = 1,
                ProductName = "ChaiseBoisMassive",
                Price=15,
                CategoryName="category1",
                ImageURL= "https://artisanans.blob.core.windows.net/artisanans/1.jpg"
            });

            modelBuilder.Entity<Productcs>().HasData(new Productcs
            {
                IdProduct = 2,
                ProductName = "Chaise",
                Price = 15,
                CategoryName = "category1",
                ImageURL = "https://artisanans.blob.core.windows.net/artisanans/2.jpg"
            });

            modelBuilder.Entity<Productcs>().HasData(new Productcs
            {
                IdProduct = 3,
                ProductName = "Bois",
                Price = 15,
                CategoryName = "category1",
                ImageURL = "https://artisanans.blob.core.windows.net/artisanans/3.jpg"
            });

            modelBuilder.Entity<Productcs>().HasData(new Productcs
            {
                IdProduct = 4,
                ProductName = "Massive",
                Price = 15,
                CategoryName = "category1",
                ImageURL = "https://artisanans.blob.core.windows.net/artisanans/4.jpg"
            });
        }

    }
}
