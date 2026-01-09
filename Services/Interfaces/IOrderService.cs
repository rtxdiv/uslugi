using aspnet1.Entity;

namespace aspnet1.Services.Interfaces
{
    public interface IOrderService
    {
        Task<Service> GetService(int id);
        Task SaveOrder(Request request);
    }
}
