using Microsoft.EntityFrameworkCore;

namespace vega.Models
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder){
            
            builder.Entity<CarModel>().HasData(
                new CarModel{Id = 1, Name = "Prado"},
                new CarModel{Id = 2, Name = "Auris"},
                new CarModel{Id = 3, Name = "Camry"},
                new CarModel{Id = 4, Name = "X6"},
                new CarModel{Id = 5, Name = "CRV"}

            );

                builder.Entity<Feature>().HasData(
                new { Id = 1,Name = "4 wheel drive"},
                new { Id = 2,Name = "ABS"},
                new { Id = 3,Name = "Central locking"},
                new { Id = 4,Name = "Reverse Camera"}
            );

                builder.Entity<Make>().HasData(
                new { Id = 1,Name = "Toyota", CarModelId = 1},
                new { Id = 2,Name = "BMW", CarModelId = 4},
                new { Id = 3,Name = "Honda", CarModelId = 5},
                new { Id = 4,Name = "Toyota", CarModelId = 2}
            );

         
        }
        
        public DbSet<Feature> Features { get; set; }
        public DbSet<CarModel> CarModels {get; set;}
        public DbSet<Make> Makes { get; set; }
        
   
    }
}
