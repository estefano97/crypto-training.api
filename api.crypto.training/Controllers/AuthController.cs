using api.crypto.training.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.crypto.training.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody]LoginDTO model)
        {
            try
            {
                if(model.Password == "12345" && model.Email == "dianita@gmail.com")
                {
                    return Ok("logeado con exito!");
                }
                return BadRequest("correo o contrasenia invalidos!");
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
