using Microsoft.EntityFrameworkCore;

namespace vega.Models
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder){
            
           

         
        }
        
        public DbSet<Feature> Features { get; set; }
        public DbSet<CarModel> CarModels {get; set;}
        public DbSet<Make> Makes { get; set; }
        
   
    }
}
