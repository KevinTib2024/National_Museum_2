using Microsoft.AspNetCore.Mvc;
using National_Museum_2.Model;
using National_Museum_2.Service;

namespace National_Museum_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TicketsController : ControllerBase
    {
        private readonly ITicketsService _ticketsService;

        public TicketsController(ITicketsService ticketsService)
        {
            _ticketsService = ticketsService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<Tickets>>> GetAllTickets()
        {
            var tickets = await _ticketsService.GetAllTicketsAsync();
            return Ok(tickets);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Tickets>> GetTicketsById(int id)
        {
            var tickets = await _ticketsService.GetTicketsByIdAsync(id);
            if (tickets == null)
                return NotFound();

            return Ok(tickets);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateTickets([FromBody] Tickets tickets)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _ticketsService.CreateTicketsAsync(tickets);
            return CreatedAtAction(nameof(GetTicketsById), new { id = tickets.ticketId }, tickets);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateTickets(int id, [FromBody] Tickets tickets)
        {
            if (id != tickets.ticketId)
                return BadRequest();

            var existingTickets = await _ticketsService.GetTicketsByIdAsync(id);
            if (existingTickets == null)
                return NotFound();

            await _ticketsService.UpdateTicketsAsync(tickets);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SoftDeleteTickets(int id)
        {
            var tickets = await _ticketsService.GetTicketsByIdAsync(id);
            if (tickets == null)
                return NotFound();

            await _ticketsService.SoftDeleteTicketsAsync(id);
            return NoContent();
        }
    }
}
