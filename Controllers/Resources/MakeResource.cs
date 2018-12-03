using System.Collections.Generic;
using vega.Models;

namespace vega.Controllers.Resources
{
    public class MakeResource
    {
         public MakeResource() 
        {
            CarModels = new List<CarModelResource>();  
        }
        
        public int Id { get; set; }

      
        public string Name { get; set; }

        public List<CarModelResource> CarModels { get; set; }

    }
}
