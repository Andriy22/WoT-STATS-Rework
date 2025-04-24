using Microsoft.EntityFrameworkCore;
using wot_stats.Domain;
using wot_stats.Domain.Entities;

namespace wot_stats.Application.Interfaces;

public interface IDataContext
{
    DbSet<AppUser> Users { get; set; }

    DbSet<Domain.Entities.RefreshToken> RefreshTokens { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
