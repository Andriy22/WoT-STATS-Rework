using AutoMapper;
using wot_stats.Application.Common.Mappings;

namespace wot_stats.Application.RefreshToken.DTOs;

public class RefreshTokenDto : IMapWith<Domain.Entities.RefreshToken>
{
    public Guid Token { get; set; }
    
    public Guid UserId { get; set; }
    
    public required string IpAddress { get; set; }
    
    public DateTime ToLife { get; set; }
    
    public bool IsExpired { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Domain.Entities.RefreshToken, RefreshTokenDto>()
            .ForMember(d => d.Token, opt => opt.MapFrom(s => s.Token))
            .ForMember(d => d.UserId, opt => opt.MapFrom(s => s.UserId))
            .ForMember(d => d.IpAddress, opt => opt.MapFrom(s => s.IpAddress))
            .ForMember(d => d.ToLife, opt => opt.MapFrom(s => s.ToLife))
            .ForMember(d => d.IsExpired, opt => opt.MapFrom(s => s.IsExpired));
    }
}
