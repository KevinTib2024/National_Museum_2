using Microsoft.AspNetCore.Mvc;
using National_Museum_2.DTO.ArtRoom;
using National_Museum_2.Model;
using National_Museum_2.Service;

namespace National_Museum_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtRoomController : ControllerBase
    {
        private readonly IArtRoomService _artRoomService;

        public ArtRoomController(IArtRoomService artRoomService)
        {

            _artRoomService = artRoomService;

        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<ArtRoom>>> GetAllArtRoom()
        {
            var ArtRoom = await _artRoomService.GetAllArtRoomAsync();
            return Ok(ArtRoom);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ArtRoom>> GetArtRoomById(int id)
        {
            var artRoom = await _artRoomService.GetArtRoomByIdAsync(id);
            if (artRoom == null)
                return NotFound();

            return Ok(artRoom);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateArtRoom([FromBody] CreateArtRoomRequest artRoom)
        {
            
            await _artRoomService.CreateArtRoomAsync(artRoom);
            return CreatedAtAction(nameof(GetArtRoomById), new { id = artRoom}, artRoom);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateArtRoom(int id, [FromBody] ArtRoom artRoom)
        {
            if (id != artRoom.artRoomId)
                return BadRequest();

            var existingArtRoom = await _artRoomService.GetArtRoomByIdAsync(id);
            if (existingArtRoom == null)
                return NotFound();

            await _artRoomService.UpdateArtRoomAsync(artRoom);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SoftDeleteArtRoom(int id)
        {
            var artRoom = await _artRoomService.GetArtRoomByIdAsync(id);
            if (artRoom == null)
                return NotFound();

            await _artRoomService.SoftDeleteArtRoomAsync(id);
            return NoContent();
        }
    }
}