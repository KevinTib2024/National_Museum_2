using Microsoft.AspNetCore.Mvc;
using National_Museum_2.DTO.Scenary;
using National_Museum_2.Model;
using National_Museum_2.Service;

namespace National_Museum_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScenaryController : ControllerBase
    {
        private readonly IScenaryService _scenaryService;

        public ScenaryController(IScenaryService scenaryService)
        {

            _scenaryService = scenaryService;

        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<Scenary>>> GetAllScenary()
        {
            var scenary = await _scenaryService.GetAllScenaryAsync();
            return Ok(scenary);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Scenary>> GetScenaryById(int id)
        {
            var scenary = await _scenaryService.GetScenaryByIdAsync(id);
            if (scenary == null)
                return NotFound();

            return Ok(scenary);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateScenary([FromBody] CreateScenaryRequest scenary)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _scenaryService.CreateScenaryAsync(scenary);
            return CreatedAtAction(nameof(GetScenaryById), new { id = scenary }, scenary);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateScenary(int id, [FromBody] UpdateScenaryRequest scenary)
        {
            if (id != scenary.scenaryId)
                return BadRequest();

            var existingScenary = await _scenaryService.GetScenaryByIdAsync(id);
            if (existingScenary == null)
                return NotFound();

            await _scenaryService.UpdateScenaryAsync(scenary);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SoftDeleteScenary(int id)
        {
            var scenary = await _scenaryService.GetScenaryByIdAsync(id);
            if (scenary == null)
                return NotFound();

            await _scenaryService.SoftDeleteScenaryAsync(id);
            return NoContent();
        }
    }
}
    