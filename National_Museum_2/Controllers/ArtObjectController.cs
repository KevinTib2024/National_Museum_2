using Microsoft.AspNetCore.Mvc;
using National_Museum_2.Model;
using National_Museum_2.Service;

namespace National_Museum_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtObjectController : ControllerBase
    {
        private readonly IArtObjectService _artObjectService;

        public ArtObjectController(IArtObjectService artObjectService)
        {

            _artObjectService = artObjectService;

        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<ArtObject>>> GetAllArtObject()
        {
            var ArtObject = await _artObjectService.GetAllArtObjectAsync();
            return Ok(ArtObject);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ArtObject>> GetArtObjectById(int id)
        {
            var artObject = await _artObjectService.GetArtObjectByIdAsync(id);
            if (artObject == null)
                return NotFound();

            return Ok(artObject);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateArtObjet([FromBody] ArtObject artObject)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _artObjectService.CreateArtObjectAsync(artObject);
            return CreatedAtAction(nameof(GetArtObjectById), new { id = artObject.artObjectId}, artObject);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateArtObject(int id, [FromBody] ArtObject artObject)
        {
            if (id != artObject.artObjectId)
                return BadRequest();

            var existingArtObject = await _artObjectService.GetArtObjectByIdAsync(id);
            if (existingArtObject == null)
                return NotFound();

            await _artObjectService.UpdateArtObjectAsync(artObject);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SoftDeleteArtObject(int id)
        {
            var artObject = await _artObjectService.GetArtObjectByIdAsync(id);
            if (artObject == null)
                return NotFound();

            await _artObjectService.SoftDeleteArtObjectAsync(id);
            return NoContent();
        }
    }
}