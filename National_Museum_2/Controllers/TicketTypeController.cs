using Microsoft.AspNetCore.Mvc;
using National_Museum_2.Model;
using National_Museum_2.Service;

namespace National_Museum_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketTypeController : ControllerBase
    {
        private readonly ITicketTypeService _ticketTypeService;

        public TicketTypeController(ITicketTypeService ticketTypeService)
        {

            _ticketTypeService = ticketTypeService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<TicketType>>> GetAllTicketType()
        {
            var ticketType = await _ticketTypeService.GetAllTicketTypeAsync();
            return Ok(ticketType);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TicketType>> GetTicketTypeById(int id)
        {
            var ticketType = await _ticketTypeService.GetTicketTypeByIdAsync(id);
            if (ticketType == null)
                return NotFound();

            return Ok(ticketType);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateTicketType([FromBody] TicketType ticketType)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _ticketTypeService.CreateTicketTypeAsync(ticketType);
            return CreatedAtAction(nameof(GetTicketTypeById), new { id = ticketType.ticketTypeId }, ticketType);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateTicketType(int id, [FromBody] TicketType ticketType)
        {
            if (id != ticketType.ticketTypeId)
                return BadRequest();

            var existingTicketType = await _ticketTypeService.GetTicketTypeByIdAsync(id);
            if (existingTicketType == null)
                return NotFound();

            await _ticketTypeService.UpdateTicketTypeAsync(ticketType);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SoftDeleteTicketType(int id)
        {
            var ticketType = await _ticketTypeService.GetTicketTypeByIdAsync(id);
            if (ticketType == null)
                return NotFound();

            await _ticketTypeService.SoftDeleteTicketTypeAsync(id);
            return NoContent();
        }
    }
}
