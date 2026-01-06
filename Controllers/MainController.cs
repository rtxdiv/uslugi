using aspnet1.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnet1.Controllers
{
    [Route("/")]
    public class MainController(
        ILogger<MainController> logger,
        IMainService mainService
    ) : Controller
    {
        [HttpGet]
        public async Task<IActionResult> MainPage() {

            logger.LogInformation("ROUTE: " + HttpContext.Request.Path);

            await mainService.Test();

            var model = new MainPageViewModel {
                Time = DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy"),
                Layout = {
                    ShowRequests = true,
                    ShowNotification = true
                }
            };

            return View(model);
        }
    }
}
