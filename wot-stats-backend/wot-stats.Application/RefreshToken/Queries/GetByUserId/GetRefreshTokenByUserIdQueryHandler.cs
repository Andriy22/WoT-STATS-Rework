using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using wot_stats.Application.Interfaces;
using wot_stats.Application.RefreshToken.DTOs;

namespace wot_stats.Application.RefreshToken.Queries.GetByUserId;

public class GetRefreshTokenByUserIdQueryHandler(IDataContext data, IMapper mapper) : IRequestHandler<GetRefreshTokenByUserIdQuery, RefreshTokenDto?>
{
    public async Task<RefreshTokenDto?> Handle(GetRefreshTokenByUserIdQuery request, CancellationToken cancellationToken)
    {
        var refreshToken = await data.RefreshTokens.SingleOrDefaultAsync(x => x.UserId == request.UserId, cancellationToken);

        if (refreshToken == null)
        {
            return null;
        }

        return mapper.Map<RefreshTokenDto>(refreshToken);
    }
}
