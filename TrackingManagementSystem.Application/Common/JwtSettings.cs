using System.ComponentModel.DataAnnotations;

namespace TrackingManagementSystem.Application.Common;

public class JwtSettings
{
    [Required(AllowEmptyStrings = false)]
    public string Issuer { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = false)]
    public string Audience { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = false)]
    public string Secret { get; set; } = string.Empty;

    // token lifetime in minutes
    [Range(1, int.MaxValue)]
    public int TokenLifetimeMinutes { get; set; } = 60;

    // refresh token lifetime in days
    [Range(1, int.MaxValue)]
    public int RefreshTokenTTLInDays { get; set; } = 7;
}
