using Literature.Database.Models;
using Literature.WebApi.DTO;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Literature.WebApi.Commands.Users
{
    public class CreateUserCommand: IRequest
    {
        public CreateUserCommand(RegistrationDTO registrationDTO)
        {
            RegistrationDTO = registrationDTO;
        }

        public RegistrationDTO RegistrationDTO { get; }
    }

    public class CreateUserCommandHandler: IRequestHandler<CreateUserCommand>
    {
        private readonly UserManager<User> userManager;

        public CreateUserCommandHandler(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var registrationDTO = request.RegistrationDTO;

            var user = new User
            {
                FirstName = registrationDTO.Name,
                UserName = registrationDTO.Login
            };

            await userManager.CreateAsync(user);

            await userManager.AddPasswordAsync(user, registrationDTO.Password);


            return Unit.Value;
        }
    }
}
