using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using National_Museum_2.Model;
using National_Museum_2.Service;
using System.ComponentModel.DataAnnotations;

    public  interface LoginRequest
    {
        string email { get; set; }
        string password { get; set; }

    }
namespace National_Museum_2.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
        
    {
        private readonly LoginService _loginService;

        public LoginController(LoginService loginService)
        {

            _loginService = loginService;

        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<bool>> AutenticationAsync([FromBody] LoginRequest loginRequest)
        {
            Console.WriteLine("Hola");
            
            return Ok(); 
        }

        
    }
}
    