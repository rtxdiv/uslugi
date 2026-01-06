using aspnet1.Entity;
using Microsoft.EntityFrameworkCore;

public class MainService(AppDbContext db) : IMainService
{
    public async Task<int> Test()
    {
        List<Service> resp = await db.Services.ToListAsync();
        Console.WriteLine(resp);
        return 0;
    }
}