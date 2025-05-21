using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using wot_stats.Application.Interfaces;
using wot_stats.Domain;
using wot_stats.Domain.Entities;

namespace wot_stats.Persistence;

public class DataContext(DbContextOptions<DataContext> options) : IdentityDbContext<AppUser>(options), IDataContext
{
    public new required DbSet<AppUser> Users { get; set; }

    public required DbSet<RefreshToken> RefreshTokens { get; set; }
    
    public required DbSet<Player> Players { get; set; }
    
    public required DbSet<PlayerStatistic> PayerStatistics { get; set; }
    
    public required DbSet<PlayerTank> PlayerTanks { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
