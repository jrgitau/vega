using System.Collections.Generic;
using System.Collections;
using System.ComponentModel.DataAnnotations;


namespace vega.Models
{
    public class Make
    {
        public Make() 
        {
            CarModels = new List<CarModel>();  
        }
        
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public List<CarModel> CarModels { get; set; }
    }
}