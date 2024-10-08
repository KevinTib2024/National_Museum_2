using Microsoft.AspNetCore.Mvc;
using National_Museum_2.Model;
using National_Museum_2.Service;

namespace National_Museum_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesXArtRoomController : ControllerBase
    {
        private readonly IEmployeesXArtRoomService _employeesXArtRoomService;

        public EmployeesXArtRoomController(IEmployeesXArtRoomService employeesXArtRoomService)
        {
            _employeesXArtRoomService = employeesXArtRoomService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<EmployeesXArtRoom>>> GetAllEmployeesXArtRoom()
        {
            var employeesXArtRoom = await _employeesXArtRoomService.GetAllEmployeesXArtRoomAsync();
            return Ok(employeesXArtRoom);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<EmployeesXArtRoom>> GetEmployeesXArtRoomById(int id)
        {
            var employeesXArtRoom = await _employeesXArtRoomService.GetEmployeesXArtRoomByIdAsync(id);
            if (employeesXArtRoom == null)
                return NotFound();

            return Ok(employeesXArtRoom);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateEmployeesXArtRoom([FromBody] EmployeesXArtRoom employeesXArtRoom)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _employeesXArtRoomService.CreateEmployeesXArtRoomAsync(employeesXArtRoom);
            return CreatedAtAction(nameof(GetEmployeesXArtRoomById), new { id = employeesXArtRoom.employeesXArtRoomId }, employeesXArtRoom);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateEmployeesXArtRoom(int id, [FromBody] EmployeesXArtRoom employeesXArtRoom)
        {
            if (id != employeesXArtRoom.employeesXArtRoomId)
                return BadRequest();

            var existingEmployeesXArtRoom = await _employeesXArtRoomService.GetEmployeesXArtRoomByIdAsync(id);
            if (existingEmployeesXArtRoom == null)
                return NotFound();

            await _employeesXArtRoomService.UpdateEmployeesXArtRoomAsync(employeesXArtRoom);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SoftDeleteEmployeesXArtRoom(int id)
        {
            var employeesXArtRoom = await _employeesXArtRoomService.GetEmployeesXArtRoomByIdAsync(id);
            if (employeesXArtRoom == null)
                return NotFound();

            await _employeesXArtRoomService.SoftDeleteEmployeesXArtRoomAsync(id);
            return NoContent();
        }
    }
}