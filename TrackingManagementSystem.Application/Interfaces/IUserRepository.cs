using TrackingManagementSystem.Domain.Entities;
namespace TrackingManagementSystem.Application.Interfaces;

public interface IUserRepository
{
    Task<Users?> GetByEmailAsync(string email);
    Task<Users?> GetByIdAsync(int id);
    Task AddAsync(Users user);
    Task UpdateAsync(Users user);
    Task SaveChangesAsync();
}
