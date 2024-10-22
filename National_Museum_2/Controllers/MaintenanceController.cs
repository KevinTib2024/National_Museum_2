using Microsoft.AspNetCore.Mvc;
using National_Museum_2.DTO.Maintenance;
using National_Museum_2.Model;
using National_Museum_2.Service;

namespace National_Museum_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenanceController : ControllerBase
    {
        private readonly IMaintenanceService _maintenanceService;

        public MaintenanceController(IMaintenanceService maintenanceService)
        {
            _maintenanceService = maintenanceService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<Maintenance>>> GetAllMaintenance()
        {
            var maintenance = await _maintenanceService.GetAllMaintenanceAsync();
            return Ok(maintenance);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Maintenance>> GetMaintenanceById(int id)
        {
            var maintenance = await _maintenanceService.GetMaintenanceByIdAsync(id);
            if (maintenance == null)
                return NotFound();

            return Ok(maintenance);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateMaintenance([FromBody] CreateMaintenanceRequest maintenance)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _maintenanceService.CreateMaintenanceAsync(maintenance);
            return CreatedAtAction(nameof(GetMaintenanceById), new { id = maintenance }, maintenance);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateMaintenance(int id, [FromBody] Maintenance maintenance)
        {
            if (id != maintenance.maintenanceId)
                return BadRequest();

            var existingMaintenance = await _maintenanceService.GetMaintenanceByIdAsync(id);
            if (existingMaintenance == null)
                return NotFound();

            await _maintenanceService.UpdateMaintenanceAsync(maintenance);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SoftDeleteMaintenance(int id)
        {
            var maintenance = await _maintenanceService.GetMaintenanceByIdAsync(id);
            if (maintenance == null)
                return NotFound();

            await _maintenanceService.SoftDeleteMaintenanceAsync(id);
            return NoContent();
        }
    }
}
