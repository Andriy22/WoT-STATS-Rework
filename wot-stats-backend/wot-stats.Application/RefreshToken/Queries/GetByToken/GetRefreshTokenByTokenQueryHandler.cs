using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using wot_stats.Application.Interfaces;
using wot_stats.Application.RefreshToken.DTOs;

namespace wot_stats.Application.RefreshToken.Queries.GetByToken;

public class GetRefreshTokenByTokenQueryHandler(IDataContext context, IMapper mapper) : IRequestHandler<GetRefreshTokenByTokenQuery, RefreshTokenDto>
{
    public async Task<RefreshTokenDto> Handle(GetRefreshTokenByTokenQuery request, CancellationToken cancellationToken)
    {
        var refreshToken = await context.RefreshTokens.SingleOrDefaultAsync(x => x.Token == request.Token, cancellationToken);

        if (refreshToken == null)
        {
            throw new NullReferenceException("Refresh token not found");
        }

        return mapper.Map<RefreshTokenDto>(refreshToken);
    }
}
