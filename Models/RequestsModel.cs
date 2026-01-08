using aspnet1.Entity;

namespace aspnet1.Models
{
    public class RequestsModel : BaseLayoutModel {
        public List<Request> Requests { get; set; } = [];
        public bool Admin { get; set; } = false;
    }
}