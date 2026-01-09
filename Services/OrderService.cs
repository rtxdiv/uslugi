using aspnet1.Entity;
using aspnet1.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace aspnet1.Services
{
    public class OrderService(AppDbContext db) : IOrderService
    {
        public async Task<Service> GetService(int id)
        {
            return await db.Services.Where(e => e.Id == id).FirstAsync();
        }

        public async Task SaveOrder(Request request)
        {
            throw new Exception();
        }
    }
}