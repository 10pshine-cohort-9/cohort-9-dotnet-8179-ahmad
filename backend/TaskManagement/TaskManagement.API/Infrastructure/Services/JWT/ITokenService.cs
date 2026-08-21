using TaskManagement.API.Domain.Entities;

namespace TaskManagement.API.Infrastructure.Services.JWT
{
    public interface ITokenService
    {
        string GenerateToken(Users user);
        string GenerateRefreshToken();
    }
}
