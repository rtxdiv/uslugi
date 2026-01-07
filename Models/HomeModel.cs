using aspnet1.Entity;

namespace aspnet1.Models
{

    public class HomeModel : BaseLayoutModel {
        public List<Service> Services { get; set; } = [];
        public bool Admin { get; set; } = false;
    }
    // создали МОДЕЛЬ (расширяющую модуль LAYOUT) для передачи в VIEW
}
