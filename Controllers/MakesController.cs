
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
     [Route("api/[controller]")]
     [ApiController]
    public class MakesController : Controller
    {
        private readonly VegaDbContext _context;
        private readonly IMapper _mapper = null;

        public MakesController(VegaDbContext context,IMapper mapper )
        {
            this._context = context;
            this._mapper = mapper;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes(){
            
           var makes = await _context.Makes.Include(m => m.CarModels).ToListAsync();
         

          return _mapper.Map<List<Make>, List<MakeResource>>(makes);
        }

         [HttpGet("/api/makes/carmodels/{id}")]
        public async Task<IEnumerable<CarModelResource>> GetCarModels(int id){
            
           var carModels = await _context.CarModels.Where(c => c.MakeId == id).ToListAsync();
         

          return _mapper.Map<List<CarModel>, List<CarModelResource>>(carModels);
        }

        


        
    }
}