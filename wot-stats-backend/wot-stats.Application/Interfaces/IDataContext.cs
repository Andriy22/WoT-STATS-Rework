using Microsoft.EntityFrameworkCore;
using wot_stats.Domain;
using wot_stats.Domain.Entities;

namespace wot_stats.Application.Interfaces;

public interface IDataContext
{
    DbSet<AppUser> Users { get; set; }

    DbSet<Domain.Entities.RefreshToken> RefreshTokens { get; set; }
    
    DbSet<Player> Players { get; set; }
    
    DbSet<PlayerStatistic> PayerStatistics { get; set; }

    DbSet<PlayerTank> PlayerTanks { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
