using aspnet1.Entity;

namespace aspnet1.Services.Interfaces
{
    public interface IMainService
    {
        Task<List<Service>> GetServices();
    }
}