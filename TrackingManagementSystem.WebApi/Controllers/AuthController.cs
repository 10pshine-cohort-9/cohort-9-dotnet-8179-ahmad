using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrackingManagementSystem.Application.DTOs;
using TrackingManagementSystem.Application.Interfaces;

namespace TrackingManagementSystem.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterDto dto)
    {
        try
        {
            var res = await _authService.RegisterAsync(dto);
            return Created("/api/auth/register", res);
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDto dto)
    {
        var res = await _authService.LoginAsync(dto);
        if (res == null) return Unauthorized(new { message = "Invalid credentials" });
        return Ok(res);
    }

    [HttpPost("refresh-token")]
    public async Task<IActionResult> Refresh([FromBody] RefreshTokenRequestDto dto)
    {
        var res = await _authService.RefreshTokenAsync(dto);
        if (res == null) return Unauthorized(new { message = "Invalid token" });
        return Ok(res);
    }

    [Authorize]
    [HttpPost("revoke-token")]
    public async Task<IActionResult> Revoke()
    {
        var userIdClaim = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        if (!int.TryParse(userIdClaim, out var userId)) return Unauthorized();

        var ok = await _authService.RevokeTokenAsync(userId);
        if (!ok) return NotFound();
        return NoContent();
    }
}
