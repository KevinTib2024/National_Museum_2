using Microsoft.AspNetCore.Mvc;
using National_Museum_2.DTO.Collection;
using National_Museum_2.Model;
using National_Museum_2.Service;

namespace National_Museum_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollectionController : ControllerBase
    {
        private readonly ICollectionService _collectionService;

        public CollectionController(ICollectionService collectionService)
        {
            _collectionService = collectionService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<Collection>>> GetAllCollection()
        {
            var collection = await _collectionService.GetAllCollectionAsync();
            return Ok(collection);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Collection>> GetCollectionById(int id)
        {
            var collection = await _collectionService.GetCollectionByIdAsync(id);
            if (collection == null)
                return NotFound();

            return Ok(collection);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateCollection([FromBody] CreateCollectionRequest collection)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _collectionService.CreateCollectionAsync(collection);
            return CreatedAtAction(nameof(GetCollectionById), new { id = collection }, collection);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateCollection(int id, [FromBody] Collection collection)
        {
            if (id != collection.collectionId)
                return BadRequest();

            var existingCollection = await _collectionService.GetCollectionByIdAsync(id);
            if (existingCollection == null)
                return NotFound();

            await _collectionService.UpdateCollectionAsync(collection);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SoftDeleteCollection(int id)
        {
            var collection = await _collectionService.GetCollectionByIdAsync(id);
            if (collection == null)
                return NotFound();

            await _collectionService.SoftDeleteCollectionAsync(id);
            return NoContent();
        }
    }
}
