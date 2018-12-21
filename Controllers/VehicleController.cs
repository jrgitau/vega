using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using vega.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using AutoMapper;
using System.Web.Http;
using vega.Mappings;
using vega.Controllers.Resources;


namespace vega.Controllers
{
    [Route("api/vehicle")]
    [ApiController]
    public class VehicleController : Controller
    {
        private readonly VegaDbContext _context;
        private readonly IMapper _mapper = null;

        public VehicleController(VegaDbContext context,IMapper mapper){

            this._context = context;
            this._mapper = mapper;

        }
        [HttpGet("{id}")]
        public ActionResult<VehicleResource> Get(int id)
        {
            var vehicle = _context.Vehicle.SingleOrDefault(v => v.Id == id);

            if(vehicle == null)
                return NotFound();

            return this._mapper.Map<Vehicle, VehicleResource>(vehicle);
        }


        [HttpGet]
        public async Task<IEnumerable<VehicleResource>> Get()
        {
            var vehicles = await this._context.Vehicle.Include(v => v.CarModel).ToListAsync();
            
            return _mapper.Map<List<Vehicle>, List<VehicleResource>>(vehicles);      
        }

 

        [HttpPost]
        [ProducesResponseType(201)]
        public ActionResult<VehicleResource> Post(VehicleResource vehicleResource){

            var vehicle = _mapper.Map<VehicleResource, Vehicle>(vehicleResource);

            this._context.Vehicle.Add(vehicle);

            this._context.SaveChanges();

            vehicleResource.Id = vehicle.Id;

            return CreatedAtAction(nameof(Get),new { id = vehicleResource.Id }, vehicleResource  );
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, VehicleResource vehicleResource){

            if(id != vehicleResource.Id)
            {
                return BadRequest();
            }

            var vehicle = _mapper.Map<VehicleResource, Vehicle>(vehicleResource);

            _context.Entry(vehicle).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<VehicleResource>> Delete(int id){

            var vehicle = await _context.Vehicle.FindAsync(id);

            if (vehicle == null)
            {
                return NotFound();
            }

            _context.Vehicle.Remove(vehicle);
            await _context.SaveChangesAsync();

            return _mapper.Map<Vehicle, VehicleResource>(vehicle);
        }


        



    }
}