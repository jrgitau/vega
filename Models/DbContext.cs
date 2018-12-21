using Microsoft.EntityFrameworkCore;


namespace vega.Models
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder){

            builder.Entity<VehicleFeature>()
                .HasKey(vf => new { vf.VehicleId , vf.FeatureId });

            builder.Entity<VehicleFeature>()
                .HasOne(vf => vf.Vehicle)
                .WithMany(v => v.VehicleFeatures)
                .HasForeignKey(vf => vf.VehicleId);
            
            builder.Entity<VehicleFeature>()
                .HasOne(vf => vf.Feature)
                .WithMany(v => v.VehicleFeatures)
                .HasForeignKey(vf => vf.FeatureId);
            
        }
        
        public DbSet<Feature> Features { get; set; }
        public DbSet<CarModel> CarModels {get; set;}
        public DbSet<Make> Makes { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<VehicleFeature> VehicleFeatures { get; set; }
   
    }
}
