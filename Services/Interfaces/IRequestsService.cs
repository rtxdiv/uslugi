using aspnet1.Entity;

namespace aspnet1.Services.Interfaces
{
    public interface IRequestsService
    {
        Task<List<Request>> GetRequests(string? userId, bool isAdmin);
    }
}