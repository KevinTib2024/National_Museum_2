using Microsoft.AspNetCore.Mvc;
using National_Museum_2.Model;
using National_Museum_2.Service;

namespace National_Museum_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoricUserController : ControllerBase
    {
        private readonly IHistoricUserService _historicUserService;

        public HistoricUserController(IHistoricUserService historicUserService)
        {

            _historicUserService = historicUserService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<HistoricUser>>> GetAllHistoricUser()
        {
            var historicUser = await _historicUserService.GetAllHistoricUserAsync();
            return Ok(historicUser);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<HistoricUser>> GetHistoricUserById(int id)
        {
            var historicUser = await _historicUserService.GetHistoricUserByIdAsync(id);
            if (historicUser == null)
                return NotFound();

            return Ok(historicUser);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateHistoricUser([FromBody] HistoricUser historicUser)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _historicUserService.CreateHistoricUserAsync(historicUser);
            return CreatedAtAction(nameof(GetHistoricUserById), new { id = historicUser.historicUserId }, historicUser);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateHistoricUser(int id, [FromBody] HistoricUser historicUser)
        {
            if (id != historicUser.historicUserId)
                return BadRequest();

            var existingHistoricUser = await _historicUserService.GetHistoricUserByIdAsync(id);
            if (existingHistoricUser == null)
                return NotFound();

            await _historicUserService.UpdateHistoricUserAsync(historicUser);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SoftDeleteHistoricUser(int id)
        {
            var historicUser = await _historicUserService.GetHistoricUserByIdAsync(id);
            if (historicUser == null)
                return NotFound();

            await _historicUserService.SoftDeleteHistoricUserAsync(id);
            return NoContent();
        }
    }
}
