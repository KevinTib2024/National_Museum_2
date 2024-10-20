using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using National_Museum_2.Model;
using National_Museum_2.Service;

namespace National_Museum_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {

            _loginService = loginService;

        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<Boolean> Autentication()
        {
            var Login = await _loginService.AutenticationAsync();
            return Ok();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        
    }
}
    