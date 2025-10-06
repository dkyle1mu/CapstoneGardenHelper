using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System.Reflection.Metadata.Ecma335;

namespace GardenHelper.Server.Controllers
{

    [ApiController]
    [Route("api/GardenController")]
    public class GardenController : ControllerBase
    {
        private readonly PlantDbContext _GardenDbContext;

        public GardenController(PlantDbContext GardenDbContext)
        {
            this._GardenDbContext = GardenDbContext;
        }

        // GET
        [HttpGet]
        public async Task <ActionResult<IEnumerable<Plant>>> GetPlant()
        {
            return Ok(await _GardenDbContext.Garden.ToListAsync());
        }

        // GET api/<PlantController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Plant>> GetPlant(int id)
        {
            var plant = await _GardenDbContext.Garden.FindAsync(id);

            if (plant == null)
            {
                return NotFound();
            }

            return Ok(plant);
        }

        // POST api/<PlantController>
        [HttpPost]
        public async Task<IActionResult> PostPlant(Plant plant)
        {
            _GardenDbContext.Garden.Add(plant);
            await _GardenDbContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetPlant), new { id = plant.ID }, plant);
        }

        // PUT api/<PlantController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PlantController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
