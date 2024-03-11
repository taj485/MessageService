using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MessageService.Server.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpPost(Name = "Login")]
        public async Task<IActionResult> Login()
        {
            //Triger Cookie Handler and returns cookie from the handler
            await HttpContext.SignInAsync("default", new ClaimsPrincipal(
                new ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.NameIdentifier, Guid.NewGuid().ToString()),
                        new Claim(ClaimTypes.Country, "England")
                    },
                    "default"
                    )
                ));

            return Ok();
        }
    }
}
