using System.ComponentModel.DataAnnotations;

namespace wot_stats.Domain.Entities;

public class RefreshToken
{
    [Key]
    public required Guid Token { get; set; }
    public AppUser? User { get; set; }
    public required string UserId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ToLife { get; set; }
    public bool IsExpired { get; set; }
    public string? IpAddress { get; set; }
}
