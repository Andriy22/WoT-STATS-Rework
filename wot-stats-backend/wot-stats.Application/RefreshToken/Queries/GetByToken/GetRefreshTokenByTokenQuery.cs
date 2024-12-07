using MediatR;
using wot_stats.Application.RefreshToken.DTOs;

namespace wot_stats.Application.RefreshToken.Queries.GetByToken;

public record GetRefreshTokenByTokenQuery : IRequest<RefreshTokenDto>
{
    public required Guid Token { get; set; }
}
