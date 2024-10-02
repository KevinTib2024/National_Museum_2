using Microsoft.AspNetCore.Mvc;
using National_Museum_2.Model;
using National_Museum_2.Service;

namespace National_Museum_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class IdentificationTypeController : ControllerBase
    {
        private readonly IIdentificationTypeService _identificationTypeService;

        public IdentificationTypeController(IIdentificationTypeService identificationTypeService)
        {

            _identificationTypeService = identificationTypeService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<IdentificationType>>> GetAllIdentificationType()
        {
            var identificationType = await _identificationTypeService.GetAllIdentificationTypeAsync();
            return Ok(identificationType);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IdentificationType>> GetIdentificationTypeById(int id)
        {
            var identificationType = await _identificationTypeService.GetIdentificationTypeByIdAsync(id);
            if (identificationType == null)
                return NotFound();

            return Ok(identificationType);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateIdentificationType([FromBody] IdentificationType identificationType)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _identificationTypeService.CreateIdentificationTypeAsync(identificationType);
            return CreatedAtAction(nameof(GetIdentificationTypeById), new { id = identificationType.identificationTypeId }, identificationType);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateIdentificationType(int id, [FromBody] IdentificationType identificationType)
        {
            if (id != identificationType.identificationTypeId)
                return BadRequest();

            var existingIdentificationType = await _identificationTypeService.GetIdentificationTypeByIdAsync(id);
            if (existingIdentificationType == null)
                return NotFound();

            await _identificationTypeService.UpdateIdentificationTypeAsync(identificationType);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SoftDeleteUser(int id)
        {
            var identificationType = await _identificationTypeService.GetIdentificationTypeByIdAsync(id);
            if (identificationType == null)
                return NotFound();

            await _identificationTypeService.SoftDeleteIdentificationTypeAsync(id);
            return NoContent();
        }
    }
}
