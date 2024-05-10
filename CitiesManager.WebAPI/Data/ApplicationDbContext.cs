using CitiesManager.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CitiesManager.WebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            
        }

        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {
        }

        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>().HasData(
                new City() { CityID = Guid.Parse("B64DCFEF-2D34-4D20-B030-70B4F44F5405"), CityName = "New York" },
                new City() { CityID = Guid.Parse("F41E12B4-2F11-4AB0-B32F-032E3AA92C8A"), CityName = "Houston" },
                new City() { CityID = Guid.Parse("DCFBE5D0-74CE-4777-8C51-B0B471B781FB"), CityName = "Seattle" });
        }
    }
}
