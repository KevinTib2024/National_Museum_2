using Microsoft.AspNetCore.Mvc;
using National_Museum_2.DTO.WorkShedule;
using National_Museum_2.Model;
using National_Museum_2.Service;

namespace National_Museum_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkSheduleController : ControllerBase
    {
        private readonly IWorkSheduleService _workSheduleService;

        public WorkSheduleController(IWorkSheduleService workSheduleService)
        {
            _workSheduleService = workSheduleService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<WorkShedule>>> GetAllWorkShedule()
        {
            var workShedule = await _workSheduleService.GetAllWorkSheduleAsync();
            return Ok(workShedule);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<WorkShedule>> GetWorkSheduleById(int id)
        {
            var workShedule = await _workSheduleService.GetWorkSheduleByIdAsync(id);
            if (workShedule == null)
                return NotFound();

            return Ok(workShedule);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateWorkShedule([FromBody] CreateWorkSheduleRequest workShedule)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _workSheduleService.CreateWorkSheduleAsync(workShedule);
            return CreatedAtAction(nameof(GetWorkSheduleById), new { id = workShedule }, workShedule);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateWorkShedule(int id, [FromBody] WorkShedule workShedule)
        {
            if (id != workShedule.workSheduleId)
                return BadRequest();

            var existingWorkShedule = await _workSheduleService.GetWorkSheduleByIdAsync(id);
            if (existingWorkShedule == null)
                return NotFound();

            await _workSheduleService.UpdateWorkSheduleAsync(workShedule);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SoftDeleteWorkShedule(int id)
        {
            var workShedule = await _workSheduleService.GetWorkSheduleByIdAsync(id);
            if (workShedule == null)
                return NotFound();

            await _workSheduleService.SoftDeleteWorkSheduleAsync(id);
            return NoContent();
        }
    }
}