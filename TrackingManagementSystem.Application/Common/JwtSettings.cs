namespace TrackingManagementSystem.Application.Common;

public class JwtSettings
{
    public string Issuer { get; set; } = string.Empty;
    public string Audience { get; set; } = string.Empty;
    public string Secret { get; set; } = string.Empty;
    // token lifetime in minutes
    public int TokenLifetimeMinutes { get; set; } = 60;
    // refresh token lifetime in days
    public int RefreshTokenTTLInDays { get; set; } = 7;
}
