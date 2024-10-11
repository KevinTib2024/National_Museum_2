using Microsoft.AspNetCore.Mvc;
using National_Museum_2.Model;
using National_Museum_2.Service;

namespace National_Museum_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoricTicketsController : ControllerBase
    {
        private readonly IHistoricTicketsService _historicTicketsService;

        public HistoricTicketsController(IHistoricTicketsService historicTicketsService)
        {

            _historicTicketsService = historicTicketsService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<HistoricTickets>>> GetAllHistoricTickets()
        {
            var historicTickets = await _historicTicketsService.GetAllHistoricTicketsAsync();
            return Ok(historicTickets);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<HistoricTickets>> GetHistoricTicketsById(int id)
        {
            var historicTickets = await _historicTicketsService.GetHistoricTicketsByIdAsync(id);
            if (historicTickets == null)
                return NotFound();

            return Ok(historicTickets);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateHistoricTickets([FromBody] HistoricTickets historicTickets)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _historicTicketsService.CreateHistoricTicketsAsync(historicTickets);
            return CreatedAtAction(nameof(GetHistoricTicketsById), new { id = historicTickets.historicTicketId }, historicTickets);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateHistoricTickets(int id, [FromBody] HistoricTickets historicTickets)
        {
            if (id != historicTickets.historicTicketId)
                return BadRequest();

            var existingHistoricTickets = await _historicTicketsService.GetHistoricTicketsByIdAsync(id);
            if (existingHistoricTickets == null)
                return NotFound();

            await _historicTicketsService.UpdateHistoricTicketsAsync(historicTickets);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SoftDeleteHistoricTickets(int id)
        {
            var historicTickets = await _historicTicketsService.GetHistoricTicketsByIdAsync(id);
            if (historicTickets == null)
                return NotFound();

            await _historicTicketsService.SoftDeleteHistoricTicketsAsync(id);
            return NoContent();
        }
    }
}
