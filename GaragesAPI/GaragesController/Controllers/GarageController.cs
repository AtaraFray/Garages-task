using GaragesBLL;
using GaragesDTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GaragesController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GarageController : ControllerBase
    {
        IGarageBLL garageBLL;
        public GarageController(IGarageBLL _garageBLL)
        {
            this.garageBLL = _garageBLL;
        }

        // GET: api/<GarageController>
        [HttpGet]
        public async Task<ActionResult<List<GarageDTO>>> GetAllGarages()
        {
            var garages = await garageBLL.GetAllGarages();
            if (garages == null)
                return NotFound();

            return Ok(garages);
        }


        // POST api/<GarageController>
        [HttpPost]
        public async Task<ActionResult> AddGarage([FromBody] GarageDTO newGarage)
        {
            try
            {
                await garageBLL.AddGarage(newGarage);
                return Ok("Garage added successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error adding garage");
            }

        }

    }
}
