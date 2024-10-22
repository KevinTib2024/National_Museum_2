using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using National_Museum_2.DTO.Games;
using National_Museum_2.Model;
using National_Museum_2.Service;

namespace National_Museum_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IGamesService _gamesService;

        public GamesController(IGamesService gamesService)
        {

            _gamesService = gamesService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<Games>>> GetAllGames()
        {
            var games = await _gamesService.GetAllGamesAsync();
            return Ok(games);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Games>> GetGamesById(int id)
        {
            var games = await _gamesService.GetGamesByIdAsync(id);
            if (games == null)
                return NotFound();

            return Ok(games);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateGames([FromBody] CreateGamesRequest games)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _gamesService.CreateGamesAsync(games);
            return CreatedAtAction(nameof(GetGamesById), new { id = games}, games);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateGames(int id, [FromBody] Games games)
        {
            if (id != games.gameId)
                return BadRequest();

            var existingGames = await _gamesService.GetGamesByIdAsync(id);
            if (existingGames == null)
                return NotFound();

            await _gamesService.UpdateGamesAsync(games);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SoftDeleteGames(int id)
        {
            var games = await _gamesService.GetGamesByIdAsync(id);
            if (games == null)
                return NotFound();

            await _gamesService.SoftDeleteGamesAsync(id);
            return NoContent();
        }
    }
}
