using MediatR;
using Microsoft.EntityFrameworkCore;
using wot_stats.Application.Interfaces;

namespace wot_stats.Application.RefreshToken.Commands.Update;

public class UpdateRefreshTokenCommandHandler(IDataContext context) : IRequestHandler<UpdateRefreshTokenCommand, Guid>
{
    public async Task<Guid> Handle(UpdateRefreshTokenCommand request, CancellationToken cancellationToken)
    {
        var refreshToken = await context.RefreshTokens.SingleOrDefaultAsync(x => x.Token == request.Token, cancellationToken);

        if (refreshToken == null)
        {
            throw new NullReferenceException("Refresh token not found");
        }

        refreshToken.IsExpired = request.IsExpired;

        await context.SaveChangesAsync(cancellationToken);

        return refreshToken.Token;
    }
}
