

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
     [Route("api/[controller]")]
     [ApiController]
    public class MakesController : Controller
    {
        private readonly VegaDbContext _context;
        private readonly IMapper _mapper = null;

        public MakesController(VegaDbContext context,IMapper mapper )
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("/api/makes")]
        public IEnumerable<MakeDto> GetMakes(){
            
           var makes =  _context.Makes
           .Include(m => m.CarModel)
           .ToList();
            

            var makeDtos = new List<MakeDto>();

            foreach (var make in makes)
            {
                makeDtos.Add(_mapper.Map<MakeDto>(make));
            }

         

          return makeDtos;
        }

        
    }
}