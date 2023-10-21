using Literature.Database.Models;
using Literature.WebApi.DTO;
using Literature.WebApi.Factories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Npgsql.Internal.TypeHandlers;

namespace Literature.WebApi.Controllers
{
    [Route("api/[controller]")]
    [AllowAnonymous]

    public class AuthController: ControllerBase
    {
        private readonly UserManager<User> userManager;
        private readonly JwtFactory jwtFactory;

        public AuthController(UserManager<User> userManager, JwtFactory jwtFactory)
        {
            this.userManager = userManager;
            this.jwtFactory = jwtFactory;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO loginDTO)
        {
            var user = await userManager.FindByNameAsync(loginDTO.Login);

            if (user == null)
            {
                return NotFound("Пользователь не найден");
            }

            if (!await userManager.CheckPasswordAsync(user, loginDTO.Password))
            {
                return BadRequest("Неверный пароль");
            }

            string jwt = jwtFactory.GenerateToken(user.Id);
            return Ok(jwt);
        }

    }
}
