using MediatR;
using Microsoft.AspNetCore.Identity;
using wot_stats.Application.Interfaces;
using wot_stats.Domain.Entities;

namespace wot_stats.Application.User.Commands.LoginCommand;

public class LoginCommandHandler(IJwtService jwtService, UserManager<AppUser> userManager)
    : IRequestHandler<LoginCommand, string>
{
    public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var user = await userManager.FindByEmailAsync(request.Email);
        if (user == null)
        {
            throw new Exception("User not found.");
        }
        var result = await userManager.CheckPasswordAsync(user, request.Password);
        if (!result)
        {
            throw new Exception("Invalid password.");
        }
        return jwtService.GenerateToken(user);
    }
}