using aspnet1.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnet1.Controllers
{
    [Route("/")]
    public class MainController(ILogger<MainController> logger) : Controller
    {

        [HttpGet]
        public IActionResult MainPage() {

            logger.LogInformation("ROUTE: " + HttpContext.Request.Path);

            var model = new MainPageViewModel {
                Time = DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy"),
                ShowRequests = true,
                ShowNotification = true
            };
            // создание экземпляра модели для VIEW

            return View(model);
            // создание View с моделью и возврат готового
        }
    }
}
