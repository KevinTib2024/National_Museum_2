using Microsoft.AspNetCore.Mvc;
using National_Museum_2.Model;
using National_Museum_2.Service;

namespace National_Museum_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExhibitionController : ControllerBase
    {
        private readonly IExhibitionService _exhibitionService;

        public ExhibitionController(IExhibitionService exhibitionService)
        {

            _exhibitionService = exhibitionService;

        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<Exhibition>>> GetAllExhibition()
        {
            var Exhibition = await _exhibitionService.GetAllExhibitionAsync();
            return Ok(Exhibition);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Exhibition>> GetExhibitionById(int id)
        {
            var exhibition = await _exhibitionService.GetExhibitionByIdAsync(id);
            if (exhibition == null)
                return NotFound();

            return Ok(exhibition);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateExhibition([FromBody] Exhibition exhibition)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _exhibitionService.CreateExhibitionAsync(exhibition);
            return CreatedAtAction(nameof(GetExhibitionById), new { id = exhibition.exhibitionId }, exhibition);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateExhibition(int id, [FromBody] Exhibition exhibition)
        {
            if (id != exhibition.exhibitionId)
                return BadRequest();

            var existingExhibition = await _exhibitionService.GetExhibitionByIdAsync(id);
            if (existingExhibition == null)
                return NotFound();

            await _exhibitionService.UpdateExhibitionAsync(exhibition);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SoftDeleteExhibition(int id)
        {
            var exhibition = await _exhibitionService.GetExhibitionByIdAsync(id);
            if (exhibition == null)
                return NotFound();

            await _exhibitionService.SoftDeleteExhibitionAsync(id);
            return NoContent();
        }
    }
}