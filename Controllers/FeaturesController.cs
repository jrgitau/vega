using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using vega.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using AutoMapper;
using System.Web.Http;
using vega.Mappings;
using vega.DTOs;
using vega.Controllers.Resources;


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
        public async Task<IEnumerable<FeatureResource>> GetFeatures(){
            
           var makes = await _context.Features.ToListAsync();
         

          return _mapper.Map<List<Feature>, List<FeatureResource>>(makes);
        } 
        
        
        }

    }
