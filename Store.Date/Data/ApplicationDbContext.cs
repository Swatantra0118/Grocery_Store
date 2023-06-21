using Microsoft.EntityFrameworkCore;
using Store.Models;

namespace Store.Data.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)//Configurations For setting up the dB context of entity core framework
        {
                
        }

        public DbSet<Category> Categories { get; set; } //Table Creation
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //Seed Data Into The Table
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Fruits & Vegetables", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Dairy & Breakfast", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Instant & Frozen Food", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Bakery & Biscuits", DisplayOrder = 4 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Tomatos",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ListPrice = 99,
                    Price = 90,
                    Price10 = 85,
                    Price20 = 80,
                    CategoryId = 3,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 2,
                    Name = "Potatos",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",                 
                    ListPrice = 40,
                    Price = 30,
                    Price10 = 25,
                    Price20 = 20,
                    CategoryId = 3,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 3,
                    Name = "Aashirvaad Whole Grain Wheet Flour",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ListPrice = 55,
                    Price = 50,
                    Price10 = 40,
                    Price20 = 35,
                    CategoryId = 3,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 4,
                    Name = "Amul Fresh Cream Milk",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ListPrice = 70,
                    Price = 65,
                    Price10 = 60,
                    Price20 = 55,
                    CategoryId = 3,
                    ImageUrl=""
                }
                );
        }
    }
}
