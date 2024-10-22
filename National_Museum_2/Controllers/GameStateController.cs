using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using National_Museum_2.DTO.GameState;
using National_Museum_2.Model;
using National_Museum_2.Service;

namespace National_Museum_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameStateController : ControllerBase
    {
        private readonly IGameStateService _gameStateService;

        public GameStateController(IGameStateService gameStateService)
        {

            _gameStateService = gameStateService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<GameState>>> GetAllGameState()
        {
            var gameState = await _gameStateService.GetAllGameStateAsync();
            return Ok(gameState);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GameState>> GetGameStateById(int id)
        {
            var gameState = await _gameStateService.GetGameStateByIdAsync(id);
            if (gameState == null)
                return NotFound();

            return Ok(gameState);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateGameState([FromBody] CreateGameStateRequest gameState)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _gameStateService.CreateGameStateAsync(gameState);
            return CreatedAtAction(nameof(GetGameStateById), new { id = gameState }, gameState);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateGameState(int id, [FromBody] GameState gameState)
        {
            if (id != gameState.gameStateId)
                return BadRequest();

            var existingGameState = await _gameStateService.GetGameStateByIdAsync(id);
            if (existingGameState == null)
                return NotFound();

            await _gameStateService.UpdateGameStateAsync(gameState);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SoftDeleteGameState(int id)
        {
            var gameState = await _gameStateService.GetGameStateByIdAsync(id);
            if (gameState == null)
                return NotFound();

            await _gameStateService.SoftDeleteGameStateAsync(id);
            return NoContent();
        }
    }
}
