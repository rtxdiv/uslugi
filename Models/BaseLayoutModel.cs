namespace aspnet1.Models
{
    public abstract class BaseLayoutModel
    {
        public bool ShowRequests { get; set; } = false;
        public bool ShowNotification { get; set; } = false;
    }
}