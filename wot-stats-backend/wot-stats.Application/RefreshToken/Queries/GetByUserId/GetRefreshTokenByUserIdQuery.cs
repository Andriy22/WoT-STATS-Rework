using MediatR;
using wot_stats.Application.RefreshToken.DTOs;

namespace wot_stats.Application.RefreshToken.Queries.GetByUserId
{
    public class GetRefreshTokenByUserIdQuery : IRequest<RefreshTokenDto?>
    {
        public required string UserId { get; set; }
    }
}
