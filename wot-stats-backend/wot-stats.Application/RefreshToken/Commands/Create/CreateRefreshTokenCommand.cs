using MediatR;

namespace wot_stats.Application.RefreshToken.Commands.Create;

public record CreateRefreshTokenCommand: IRequest<Guid>
{
    public required string UserId { get; set; }
    public DateTime ToLife { get; set; }
    public bool IsExpired { get; set; }
    public required string IpAddress { get; set; }
}
