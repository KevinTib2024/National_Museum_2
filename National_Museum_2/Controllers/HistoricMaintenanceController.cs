using Microsoft.AspNetCore.Mvc;
using National_Museum_2.Model;
using National_Museum_2.Service;

namespace National_Museum_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoricMaintenanceController : ControllerBase
    {
        private readonly IHistoricMaintenanceService _historicMaintenanceService;

        public HistoricMaintenanceController(IHistoricMaintenanceService historicMaintenanceService)
        {

            _historicMaintenanceService = historicMaintenanceService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<HistoricMaintenance>>> GetAllHistoricMaintenance()
        {
            var historicMaintenance = await _historicMaintenanceService.GetAllHistoricMaintenanceAsync();
            return Ok(historicMaintenance);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<HistoricMaintenance>> GetHistoricMaintenanceById(int id)
        {
            var historicMaintenance = await _historicMaintenanceService.GetHistoricMaintenanceByIdAsync(id);
            if (historicMaintenance == null)
                return NotFound();

            return Ok(historicMaintenance);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateHistoricMaintenance([FromBody] HistoricMaintenance historicMaintenance)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _historicMaintenanceService.CreateHistoricMaintenanceAsync(historicMaintenance);
            return CreatedAtAction(nameof(GetHistoricMaintenanceById), new { id = historicMaintenance.historicMaintenanceId }, historicMaintenance);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateHistoricMaintenance(int id, [FromBody] HistoricMaintenance historicMaintenance)
        {
            if (id != historicMaintenance.historicMaintenanceId)
                return BadRequest();

            var existingHistoricMaintenance = await _historicMaintenanceService.GetHistoricMaintenanceByIdAsync(id);
            if (existingHistoricMaintenance == null)
                return NotFound();

            await _historicMaintenanceService.UpdateHistoricMaintenanceAsync(historicMaintenance);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SoftDeleteHistoricMaintenance(int id)
        {
            var historicMaintenance = await _historicMaintenanceService.GetHistoricMaintenanceByIdAsync(id);
            if (historicMaintenance == null)
                return NotFound();

            await _historicMaintenanceService.SoftDeleteHistoricMaintenanceAsync(id);
            return NoContent();
        }
    }
}
