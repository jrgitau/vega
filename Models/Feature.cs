using System.Collections.Generic;


namespace vega.Models
{
    public class Feature
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<VehicleFeature> VehicleFeatures { get;set; }
        
    }
}