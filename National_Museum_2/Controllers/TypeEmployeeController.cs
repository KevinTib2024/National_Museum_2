using Microsoft.AspNetCore.Mvc;
using National_Museum_2.Model;
using National_Museum_2.Service;

namespace National_Museum_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeEmployeeController : ControllerBase
    {
        private readonly ITypeEmployeeService _typeEmployeeService;

        public TypeEmployeeController(ITypeEmployeeService typeEmployeeService)
        {
            _typeEmployeeService = typeEmployeeService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<TypeEmployee>>> GetAllTypeEmployee()
        {
            var typeEmployee = await _typeEmployeeService.GetAllTypeEmployeeAsync();
            return Ok(typeEmployee);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TypeEmployee>> GetTypeEmployeeById(int id)
        {
            var typeEmployee = await _typeEmployeeService.GetTypeEmployeeByIdAsync(id);
            if (typeEmployee == null)
                return NotFound();

            return Ok(typeEmployee);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateTypeEmployee([FromBody] TypeEmployee typeEmployee)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _typeEmployeeService.CreateTypeEmployeeAsync(typeEmployee);
            return CreatedAtAction(nameof(GetTypeEmployeeById), new { id = typeEmployee.typeEmployeeId }, typeEmployee);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateTypeEmployee(int id, [FromBody] TypeEmployee typeEmployee)
        {
            if (id != typeEmployee.typeEmployeeId)
                return BadRequest();

            var existingTypeEmployee = await _typeEmployeeService.GetTypeEmployeeByIdAsync(id);
            if (existingTypeEmployee == null)
                return NotFound();

            await _typeEmployeeService.UpdateTypeEmployeeAsync(typeEmployee);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SoftDeleteTypeEmployee(int id)
        {
            var typeEmployee = await _typeEmployeeService.GetTypeEmployeeByIdAsync(id);
            if (typeEmployee == null)
                return NotFound();

            await _typeEmployeeService.SoftDeleteTypeEmployeeAsync(id);
            return NoContent();
        }
    }
}