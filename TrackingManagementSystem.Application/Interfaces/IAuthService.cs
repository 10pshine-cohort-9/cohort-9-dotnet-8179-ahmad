using TrackingManagementSystem.Application.DTOs;

namespace TrackingManagementSystem.Application.Interfaces;

public interface IAuthService
{
    Task<AuthResponseDto> RegisterAsync(RegisterDto registerDto);
    Task<AuthResponseDto?> LoginAsync(LoginDto loginDto);
    Task<AuthResponseDto?> RefreshTokenAsync(RefreshTokenRequestDto request);
    Task<bool> RevokeTokenAsync(int userId);
}
