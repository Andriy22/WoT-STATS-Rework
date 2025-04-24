using MediatR;

namespace wot_stats.Application.User.Commands.LoginCommand;

public record LoginCommand : IRequest<string>
{
    public string Email { get; set; }
    public string Password { get; set; }
}