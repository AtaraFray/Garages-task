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
        private IGovApiService govApiService;

        public GarageController(IGarageBLL _garageBLL , IGovApiService _govApiService)
        {
            this.garageBLL = _garageBLL;
            // הממשלתי  api הוספת השירות של ה 
            this.govApiService = _govApiService;

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

        //חיצוני api של שימוש בפונקצית התממשקות ל controller הוספת 

        // GET: api/<GarageController>
        [HttpGet("gov")]
        public async Task<ActionResult<List<GarageDTO>>> GetGovGarages()
        {
            var garages = await govApiService.GetGovGaragesAsync();
            if (garages == null)
                return NotFound();

            return Ok(garages);
        }

    }
}
