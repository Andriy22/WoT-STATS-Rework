using MediatR;
using Microsoft.EntityFrameworkCore;
using wot_stats.Application.Interfaces;

namespace wot_stats.Application.RefreshToken.Commands.Create;

public class CreateRefreshTokenCommandHandler(IDataContext context) : IRequestHandler<CreateRefreshTokenCommand, Guid>
{
    public async Task<Guid> Handle(CreateRefreshTokenCommand request, CancellationToken cancellationToken)
    {
        var token = Guid.NewGuid();

        var existingToken = await context.RefreshTokens.SingleOrDefaultAsync(x => x.Token == token, cancellationToken);

        while (existingToken != null)
        {
            token = Guid.NewGuid();
            existingToken = await context.RefreshTokens.SingleOrDefaultAsync(x => x.Token == token, cancellationToken);
        }

        var refreshToken = new Domain.Entities.RefreshToken
        {
            CreatedAt = DateTime.UtcNow,
            IpAddress = request.IpAddress,
            Token = token,
            UserId = request.UserId,
            IsExpired = false,
            ToLife = DateTime.UtcNow,
        };

        await context.RefreshTokens.AddAsync(refreshToken, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);

        return refreshToken.Token;
    }
}
