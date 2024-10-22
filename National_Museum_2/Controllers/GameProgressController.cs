using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using National_Museum_2.DTO.GameProgress;
using National_Museum_2.Model;
using National_Museum_2.Service;

namespace National_Museum_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameProgressController : ControllerBase
    {
        private readonly IGameProgressService _gameProgressService;

        public GameProgressController(IGameProgressService gameProgressService)
        {

            _gameProgressService = gameProgressService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<GameProgress>>> GetAllGameProgress()
        {
            var gameProgress = await _gameProgressService.GetAllGameProgressAsync();
            return Ok(gameProgress);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GameProgress>> GetGameProgressById(int id)
        {
            var gameProgress = await _gameProgressService.GetGameProgressByIdAsync(id);
            if (gameProgress == null)
                return NotFound();

            return Ok(gameProgress);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateGameProgress([FromBody] CreateGameProgressRequest gameProgress)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _gameProgressService.CreateGameProgressAsync(gameProgress);
            return CreatedAtAction(nameof(GetGameProgressById), new { id = gameProgress }, gameProgress);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateGameProgress(int id, [FromBody] GameProgress gameProgress)
        {
            if (id != gameProgress.gameProgressId)
                return BadRequest();

            var existingGameProgress = await _gameProgressService.GetGameProgressByIdAsync(id);
            if (existingGameProgress == null)
                return NotFound();

            await _gameProgressService.UpdateGameProgressAsync(gameProgress);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SoftDeleteGameProgress(int id)
        {
            var gameProgress = await _gameProgressService.GetGameProgressByIdAsync(id);
            if (gameProgress == null)
                return NotFound();

            await _gameProgressService.SoftDeleteGameProgressAsync(id);
            return NoContent();
        }
    }
}
