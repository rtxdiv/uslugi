using aspnet1.Entity;
using aspnet1.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace aspnet1.Services
{
    public class RequestsService(AppDbContext db) : IRequestsService
    {
        public async Task<List<Request>> GetRequests(string? userId, bool isAdmin)
        {
            if (isAdmin) {
                return await db.Requests.ToListAsync();

            } else {
                return await db.Requests.Where(e => e.UserId == userId).ToListAsync();
            }
        }
    }
}