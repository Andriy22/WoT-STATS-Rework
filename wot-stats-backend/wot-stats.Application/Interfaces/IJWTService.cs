
using wot_stats.Domain.Entities;

namespace wot_stats.Application.Interfaces;

public interface IJwtService
{
    string GenerateToken(AppUser user);
}
