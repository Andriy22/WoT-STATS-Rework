using System.ComponentModel.DataAnnotations.Schema;

namespace wot_stats.Domain.Entities;

public class PlayerTank
{
    public required string Id { get; set; }
    
    public required long TankId { get; set; }
    
    public required string TankName { get; set; }
    
    public required int RandomBattles { get; set; }
    
    public required double RandomAvgDmg { get; set; }
    
    public required double Wn8 { get; set; }
    
    public required int StrongholdDefenseBattles { get; set; }
    
    public required double StrongholdDefenseAvgDmg { get; set; }
    
    public required int StrongholdAttackBattles { get; set; }
    
    public required double StrongholdAttackAvgDmg { get; set; }
    
    [ForeignKey("Player")]
    public required string PlayerId { get; set; }
    public Player? Player { get; set; } 
}