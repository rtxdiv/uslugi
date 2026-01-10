using Microsoft.EntityFrameworkCore;
using services.Entity;
using services.Services.Interfaces;

namespace services.Services
{
    class AuthService(AppDbContext db) : IAuthService
    {
        public async Task<bool> ValidateUserId(string userId)
        {
            int requestsCount = await db.Requests.Where(e => e.UserId == userId).CountAsync();
            if (requestsCount == 0) return false;
            return true;
        }
    }
}