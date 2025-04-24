using FluentValidation;

namespace wot_stats.Application.RefreshToken.Commands.Create;

public class CreateRefreshTokenCommandValidator: AbstractValidator<CreateRefreshTokenCommand>
{
    public CreateRefreshTokenCommandValidator()
    {
        RuleFor(x => x.IpAddress).NotEmpty().NotNull();
        RuleFor(x => x.ToLife).NotNull();
        RuleFor(x => x.UserId).NotEmpty().NotNull();
    }
}
