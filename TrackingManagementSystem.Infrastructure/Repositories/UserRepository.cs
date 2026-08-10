using Microsoft.EntityFrameworkCore;
using TrackingManagementSystem.Application.Interfaces;
using TrackingManagementSystem.Domain.Entities;
using TrackingManagementSystem.Infrastructure.Data;

namespace TrackingManagementSystem.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _db;

    public UserRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task AddAsync(Users user)
    {
        await _db.Users.AddAsync(user);
    }

    public async Task<Users?> GetByEmailAsync(string email)
    {
        return await _db.Users.FirstOrDefaultAsync(u => u.Email == email);
    }

    public async Task<Users?> GetByIdAsync(int id)
    {
        return await _db.Users.FindAsync(id);
    }

    public Task UpdateAsync(Users user)
    {
        _db.Users.Update(user);
        return Task.CompletedTask;
    }

    public async Task SaveChangesAsync()
    {
        await _db.SaveChangesAsync();
    }
}
