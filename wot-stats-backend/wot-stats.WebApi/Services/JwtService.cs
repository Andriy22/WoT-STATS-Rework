using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using wot_stats.Application.Interfaces;
using wot_stats.Domain.Entities;
using wot_stats.WebApi.Options;

namespace wot_stats.WebApi.Services;

public class JwtService : IJwtService
{
    private readonly UserManager<AppUser> _userManager;
    private readonly JwtOptions _jwtOptions;

    public JwtService(UserManager<AppUser> userManager, IOptions<JwtOptions> jwtOptions)
    {
        _userManager = userManager;
        _jwtOptions = jwtOptions.Value;
    }

    public string GenerateToken(AppUser user)
    {
        if (_jwtOptions == null)
        {
            throw new ArgumentNullException(nameof(_jwtOptions));
        }
 
        var claimsList = new List<Claim>()
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id),
        };
 
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.Key));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
        var token = new JwtSecurityToken(_jwtOptions.Issuer,
            _jwtOptions.Audience,
            claimsList,
            expires: DateTime.Now.AddHours(_jwtOptions.AccessTokenExpiration),
            signingCredentials: credentials);
        var tokenHandler = new JwtSecurityTokenHandler();
 
        return tokenHandler.WriteToken(token);
    }
}