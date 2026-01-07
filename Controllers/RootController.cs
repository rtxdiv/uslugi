using aspnet1.Models;
using aspnet1.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace aspnet1.Controllers
{
    [Route("/")]
    public class RootController(IMainService mainService) : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Home() {

            var model = new HomeModel {
                Services = await mainService.GetServices(),
                Admin = false,
                Layout = {
                    ShowRequests = true,
                }
            };

            return View(model);
        }
    }
}
