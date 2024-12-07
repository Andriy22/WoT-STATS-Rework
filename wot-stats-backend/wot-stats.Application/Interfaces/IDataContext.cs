using Microsoft.EntityFrameworkCore;
using wot_stats.Domain;

namespace wot_stats.Application.Interfaces;

public interface IDataContext
{
    DbSet<AppUser> Users { get; set; }

    DbSet<Domain.RefreshToken> RefreshTokens { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
