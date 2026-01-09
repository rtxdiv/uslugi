using Microsoft.AspNetCore.Mvc;
using aspnet1.Models.ViewModels;
using aspnet1.Services.Interfaces;

namespace aspnet1.Controllers
{
    [Route("/")]
    public class RootController(IRootService rootService) : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Home()
        {
            HomeModel model = new() {
                Services = await rootService.GetServices(),
                Admin = false,
                Layout = {
                    ShowRequests = true,
                }
            };

            return View(model);
        }
    }
}
