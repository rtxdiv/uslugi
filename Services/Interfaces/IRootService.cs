using aspnet1.Entity;

namespace aspnet1.Services.Interfaces
{
    public interface IRootService
    {
        Task<List<Service>> GetServices();
    }
}