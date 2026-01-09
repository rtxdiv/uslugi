using Microsoft.AspNetCore.Mvc;
using aspnet1.Models.ViewModels;
using aspnet1.Services.Interfaces;

namespace aspnet1.Controllers
{
    [Route("requests")]
    public class RequestsController(IRequestsService requestsService) : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Requests()
        {
            /* string? userId = HttpContext.Request.Cookies["user_id"]; */
            string? userId = "id1";
            bool isAdmin = true;

            RequestsModel model = new()
            {
                Requests = await requestsService.GetRequests(userId, isAdmin),
                Admin = isAdmin
            };

            return View(model);
        }
    }
}