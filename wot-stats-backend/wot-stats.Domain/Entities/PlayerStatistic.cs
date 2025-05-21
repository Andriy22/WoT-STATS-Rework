using System.ComponentModel.DataAnnotations.Schema;

namespace wot_stats.Domain.Entities;

public class PlayerStatistic
{
    public required string Id { get; set; }

    [ForeignKey("Player")]
    public required string PlayerId { get; set; }

    public required Player Player { get; set; }
    
    public required DateTime Date { get; set; }
    
    public required double Wn8 { get; set; }
    
    public double? Wn8Delta { get; set; }
    
    public required double EfficientRating { get; set; }
    
    public double? EfficientRatingDelta { get; set; }
    
    public required double WinRate { get; set; }
    
    public long? StrongholdDefenseBattles { get; set; }
    
    public long? StrongholdDefenseAverageDamage { get; set; }
    
    public long? StrongholdAttackBattles { get; set; }
    
    public long? StrongholdAttackAverageDamage { get; set; }
}
