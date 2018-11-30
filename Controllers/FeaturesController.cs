using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using vega.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using AutoMapper;
using System.Web.Http;
using vega.Mappings;
using vega.DTOs;


namespace vega.Controllers
{
    public class FeaturesController
    {

        private readonly VegaDbContext _context;
        private readonly IMapper _mapper = null;

        public FeaturesController(VegaDbContext context,IMapper mapper )
        {
            _context = context;
            _mapper = mapper;
        }
        
        [HttpGet("/api/features")]
        public IEnumerable<FeatureDto> GetMakes(){
            
           var features =  _context.Features.ToList();
            

            var featureDtos = new List<FeatureDto>();

            foreach (var feature in features)
            {
                featureDtos.Add(_mapper.Map<FeatureDto>(feature));
            }

          return featureDtos;
        }

    }
}