using Microsoft.AspNetCore.Mvc;
using National_Museum_2.DTO.State;
using National_Museum_2.Model;
using National_Museum_2.Service;

namespace National_Museum_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly IStateService _stateService;

        public StateController(IStateService stateService)
        {

            _stateService = stateService;

        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<State>>> GetAllState()
        {
            var State = await _stateService.GetAllStateAsync();
            return Ok(State);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<State>> GetStateById(int id)
        {
            var state = await _stateService.GetStateByIdAsync(id);
            if (state == null)
                return NotFound();

            return Ok(state);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateState([FromBody] CreateStateRequest state)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _stateService.CreateStateAsync(state);
            return CreatedAtAction(nameof(GetStateById), new { id = state }, state);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateArtObject(int id, [FromBody] State state)
        {
            if (id != state.stateId)
                return BadRequest();

            var existingState = await _stateService.GetStateByIdAsync(id);
            if (existingState == null)
                return NotFound();

            await _stateService.UpdateStateAsync(state);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SoftDeleteState(int id)
        {
            var state = await _stateService.GetStateByIdAsync(id);
            if (state == null)
                return NotFound();

            await _stateService.SoftDeleteStateAsync(id);
            return NoContent();
        }
    }
}