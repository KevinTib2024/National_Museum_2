using Microsoft.AspNetCore.Mvc;
using National_Museum_2.Model;
using National_Museum_2.Service;

namespace National_Museum_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketXCollectionController : ControllerBase
    {
        private readonly ITicketXCollectionService _ticketXCollectionService;

        public TicketXCollectionController(ITicketXCollectionService ticketXCollectionService)
        {

            _ticketXCollectionService = ticketXCollectionService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<TicketXCollection>>> GetAllTicketXCollection()
        {
            var ticketXCollection = await _ticketXCollectionService.GetAllTicketXCollectionAsync();
            return Ok(ticketXCollection);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TicketXCollection>> GetTicketXCollectionById(int id)
        {
            var ticketXCollection = await _ticketXCollectionService.GetTicketXCollectionByIdAsync(id);
            if (ticketXCollection == null)
                return NotFound();

            return Ok(ticketXCollection);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateTicketXCollection([FromBody] TicketXCollection ticketXCollection)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _ticketXCollectionService.CreateTicketXCollectionAsync(ticketXCollection);
            return CreatedAtAction(nameof(GetTicketXCollectionById), new { id = ticketXCollection.ticketXCollectionId }, ticketXCollection);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateTicketXCollection(int id, [FromBody] TicketXCollection ticketXCollection)
        {
            if (id != ticketXCollection.ticketXCollectionId)
                return BadRequest();

            var existingTicketXCollection = await _ticketXCollectionService.GetTicketXCollectionByIdAsync(id);
            if (existingTicketXCollection == null)
                return NotFound();

            await _ticketXCollectionService.UpdateTicketXCollectionAsync(ticketXCollection);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SoftDeleteTicketXCollection(int id)
        {
            var ticketXCollection = await _ticketXCollectionService.GetTicketXCollectionByIdAsync(id);
            if (ticketXCollection == null)
                return NotFound();

            await _ticketXCollectionService.SoftDeleteTicketXCollectionAsync(id);
            return NoContent();
        }
    }
}
