using MediatR;

namespace wot_stats.Application.RefreshToken.Commands.Update;

public record UpdateRefreshTokenCommand: IRequest<Guid>
{
    public required Guid Token { get; set; }

    public bool IsExpired { get; set; }
}
