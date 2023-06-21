using Microsoft.EntityFrameworkCore;
using StoreRazor.Model;

namespace StoreRazor.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)//Configurations For setting up the dB context of entity core framework
        {

        }
        public DbSet<Category> Categories_R { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Beverages", DisplayOrder = 1 },
                new Category { Id =2, Name ="Snaks", DisplayOrder = 2},
                new Category { Id = 3, Name = "Fruits", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Vegetables", DisplayOrder = 4 }
                );
        }

    }
}
