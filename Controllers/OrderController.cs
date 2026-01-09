using Microsoft.AspNetCore.Mvc;
using aspnet1.Models.Dto;
using aspnet1.Entity;
using aspnet1.Services.Interfaces;
using aspnet1.Models.ViewModels;

namespace aspnet1.Controllers
{
    [Route("order")]
    public class OrderController(IOrderService orderService) : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Order(OrderDto dto)
        {
            OrderModel model = new()
            {
                Service = await orderService.GetService(dto.Id)
            };

            return View(model);
        }
    }
}