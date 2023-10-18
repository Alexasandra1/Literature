using Literature.WebApi.Commands.Users;
using Literature.WebApi.DTO;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Literature.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController: ControllerBase
    {
        private readonly IMediator mediator;

        public UserController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost()]
        public async Task CreateUser(RegistrationDTO registrationDTO)
        {
            await mediator.Send(new CreateUserCommand(registrationDTO));
        }
    }
}
