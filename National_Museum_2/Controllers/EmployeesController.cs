using Microsoft.AspNetCore.Mvc;
using National_Museum_2.DTO.Employees;
using National_Museum_2.Model;
using National_Museum_2.Service;

namespace National_Museum_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesService _employeesService;

        public EmployeesController(IEmployeesService employeesService)
        {
            _employeesService = employeesService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<Employees>>> GetAllEmployees()
        {
            var employees = await _employeesService.GetAllEmployeesAsync();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Employees>> GetEmployeesById(int id)
        {
            var employees = await _employeesService.GetEmployeesByIdAsync(id);
            if (employees == null)
                return NotFound();

            return Ok(employees);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateEmployees([FromBody] CreateEmployeesRequest employees)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _employeesService.CreateEmployeesAsync(employees);
            return CreatedAtAction(nameof(GetEmployeesById), new { id = employees }, employees);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateEmployees(int id, [FromBody] UpdateEmployeesRequest employees)
        {
           

            var existingEmployees = await _employeesService.GetEmployeesByIdAsync(id);
            if (existingEmployees == null)
                return NotFound();

            await _employeesService.UpdateEmployeesAsync(employees);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SoftDeleteEmployees(int id)
        {
            var employees = await _employeesService.GetEmployeesByIdAsync(id);
            if (employees == null)
                return NotFound();

            await _employeesService.SoftDeleteEmployeesAsync(id);
            return NoContent();
        }
    }
}