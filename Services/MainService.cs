using aspnet1.Entity;
using aspnet1.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace aspnet1.Services
{
    public class MainService(AppDbContext db) : IMainService
    {
        public async Task<List<Service>> GetServices()
        {
            return await db.Services.ToListAsync();
        }
    }
}