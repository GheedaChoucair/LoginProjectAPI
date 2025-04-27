using BusinessLayer.DTOs;
using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiLoginProject.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserAuthenticationService _userAuthenticationService;

        public AuthenticationController(IUserAuthenticationService userAuthenticationService)
        {
            _userAuthenticationService = userAuthenticationService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginModel model)
        {
            var authResult = await _userAuthenticationService.AuthenticateLogin(model);

            if (authResult.IsSuccess)
            {
                return Ok(new
                {
                    Message = "Login successful",
                    Token = authResult.Token
                });
            }

            return Unauthorized(new { Error = authResult.ErrorMessage });
        }
    }
}