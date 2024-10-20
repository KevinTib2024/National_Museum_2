using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using National_Museum_2.Model;
using National_Museum_2.Service;
using System.ComponentModel.DataAnnotations;

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

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<bool>>AutenticationAsync(string email, string password)
        {
            var login = await _loginService.AutenticationAsync(email, password);
            return Ok(login); 
        }

        
    }
}
    