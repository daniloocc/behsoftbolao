using BehSoft.DataAccess.Repository.IRepository;
using behsoftbolao.api.Data.Dto.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace behsoftbolao.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ITokenRepository _tokenRepository;

        public AuthController(UserManager<IdentityUser> userManager, ITokenRepository token)
        {
            _userManager = userManager;
            _tokenRepository = token;
        }


        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto registerRequestDto)
        {
            var identityUser = new IdentityUser
            {
                UserName = registerRequestDto.Username,
                Email = registerRequestDto.Username
            };

            var identityResult = await _userManager.CreateAsync(identityUser, registerRequestDto.Password);

            if (identityResult.Succeeded)
            {
                // add roles to this user
                if (registerRequestDto.Roles != null && registerRequestDto.Roles.Any())
                {
                    identityResult = await _userManager.AddToRolesAsync(identityUser, registerRequestDto.Roles);

                    if (identityResult.Succeeded)
                    {
                        return Ok("User was registered! Please Login.");
                    }
                }
            }
            return BadRequest("Something Went Wrong!");
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody]LoginRequestDto loginRequestDto)
        {

            var user = await _userManager.FindByEmailAsync(loginRequestDto.UserName);

            if(user != null)
            {
                var loginValid = await _userManager.CheckPasswordAsync(user, loginRequestDto.Password);

                if(loginValid)
                {
                    // get roles of this user
                    var roles = await _userManager.GetRolesAsync(user);

                    if (roles != null)
                    {
                        // create token
                        var jwtToken = _tokenRepository.CreateJwtToken(user, [.. roles]);
                        var response = new LoginResponseDto
                        {
                            JwtToken = jwtToken
                        };
                        return Ok(response);
                    }
                }
            }
            return BadRequest("User/Password incorrect");
        }
    }
}
