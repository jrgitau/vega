using System.ComponentModel.DataAnnotations;
using System;

namespace vega.Controllers.Resources
{
    public class VehicleResource
    {
        public int Id { get; set; }

        public CarModelResource CarModelResource { get; set; }

        public string ContactPhone { get; set; }

        public string ContactName { get; set; }

        public int CarModelId { get; set; }

        public DateTime LastUpdate { get; set; }

    }
}