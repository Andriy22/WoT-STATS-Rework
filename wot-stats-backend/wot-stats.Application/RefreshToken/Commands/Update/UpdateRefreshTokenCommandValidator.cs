using FluentValidation;

namespace wot_stats.Application.RefreshToken.Commands.Update;

public class UpdateRefreshTokenCommandValidator : AbstractValidator<UpdateRefreshTokenCommand>
{
    public UpdateRefreshTokenCommandValidator()
    {
        RuleFor(x => x.Token).NotEmpty().NotNull();
    }
}
