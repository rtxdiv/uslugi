namespace aspnet1.Models
{

    public class MainPageViewModel : BaseLayoutModel {
        public string Time {  get; set; } = String.Empty;
    }
    // создали МОДЕЛЬ (расширяющую модуль LAYOUT) для передачи в VIEW
}
