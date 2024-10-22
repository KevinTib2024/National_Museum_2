using Microsoft.AspNetCore.Mvc;
using National_Museum_2.DTO.PaymentMethod;
using National_Museum_2.Model;
using National_Museum_2.Service;

namespace National_Museum_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentMethodController : ControllerBase
    {
        private readonly IPaymentMethodService _paymentMethodService;

        public PaymentMethodController(IPaymentMethodService paymentMethodService)
        {
            _paymentMethodService = paymentMethodService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<PaymentMethod>>> GetAllPaymentMethod()
        {
            var paymentMethod = await _paymentMethodService.GetAllPaymentMethodAsync();
            return Ok(paymentMethod);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PaymentMethod>> GetPaymentMethodById(int id)
        {
            var paymentMethod = await _paymentMethodService.GetPaymentMethodByIdAsync(id);
            if (paymentMethod == null)
                return NotFound();

            return Ok(paymentMethod);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreatePaymentMethod([FromBody] CreatePaymentMetodRequest paymentMethod)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _paymentMethodService.CreatePaymentMethodAsync(paymentMethod);
            return CreatedAtAction(nameof(GetPaymentMethodById), new { id = paymentMethod }, paymentMethod);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdatePaymentMethod(int id, [FromBody] PaymentMethod paymentMethod)
        {
            if (id != paymentMethod.paymentMethodId)
                return BadRequest();

            var existingPaymentMethod = await _paymentMethodService.GetPaymentMethodByIdAsync(id);
            if (existingPaymentMethod == null)
                return NotFound();

            await _paymentMethodService.UpdatePaymentMethodAsync(paymentMethod);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SoftDeletePaymentMethod(int id)
        {
            var paymentMethod = await _paymentMethodService.GetPaymentMethodByIdAsync(id);
            if (paymentMethod == null)
                return NotFound();

            await _paymentMethodService.SoftDeletePaymentMethodAsync(id);
            return NoContent();
        }
    }
}
