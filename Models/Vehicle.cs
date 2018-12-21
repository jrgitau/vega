using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace vega.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        public CarModel CarModel { get; set; }

        public int CarModelId { get; set; }

        [Required]
        [StringLength(255)]
        public string ContactPhone { get; set; }

        [Required]
        [StringLength(255)]
        public string ContactName { get; set; }

        //public string ContactEmail { get; set; }

        public DateTime LastUpdate { get; set; }

        public virtual ICollection<VehicleFeature> VehicleFeatures { get; set; }

    }
}