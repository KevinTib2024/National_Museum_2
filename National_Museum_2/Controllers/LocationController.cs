using Microsoft.AspNetCore.Mvc;
using National_Museum_2.DTO.Location;
using National_Museum_2.Model;
using National_Museum_2.Service;

namespace National_Museum_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class locationController : ControllerBase
    {
        private readonly ILocationService _locationService;

        public locationController(ILocationService locationService)
        {

            _locationService = locationService;

        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<Location>>> GetAllLocation()
        {
            var Location = await _locationService.GetAllLocationAsync();
            return Ok(Location);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Location>> GetLocationById(int id)
        {
            var location = await _locationService.GetLocationByIdAsync(id);
            if (location == null)
                return NotFound();

            return Ok(location);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateLocation([FromBody] CreateLocationRequest location)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _locationService.CreateLocationAsync(location);
            return CreatedAtAction(nameof(GetLocationById), new { id = location }, location);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateLocation(int id, [FromBody] Location location)
        {
            if (id != location.locationId)
                return BadRequest();

            var existingLocation = await _locationService.GetLocationByIdAsync(id);
            if (existingLocation == null)
                return NotFound();

            await _locationService.UpdateLocationAsync(location);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SoftDeletelocation(int id)
        {
            var location = await _locationService.GetLocationByIdAsync(id);
            if (location == null)
                return NotFound();

            await _locationService.SoftDeleteLocationAsync(id);
            return NoContent();
        }
    }
}