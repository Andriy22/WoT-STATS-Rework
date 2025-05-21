using wot_stats.Domain.Enums;

namespace wot_stats.Domain.Entities;
public class Player
{
    public required string Id { get; set; }
    
    public required long AccountId { get; set; }

    public required string Nickname { get; set; }

    public string? ClanTag { get; set; }

    public long? ClanId { get; set; }
    
    public required DateTime CreatedAt { get; set; }
    
    public required DateTime UpdatedAt { get; set; }
    
    public DateTime? LastBattleTime { get; set; }
    
    public long? AverageNumberOfBattles { get; set; }
    
    public required GameServers GameServer { get; set; }
    
    public ICollection<PlayerStatistic>? Statistics { get; set; }
}

