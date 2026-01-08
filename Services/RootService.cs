using aspnet1.Entity;
using aspnet1.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace aspnet1.Services
{
    public class RootService(AppDbContext db) : IRootService
    {
        public async Task<List<Service>> GetServices()
        {
            return await db.Services.ToListAsync();
        }
    }
}