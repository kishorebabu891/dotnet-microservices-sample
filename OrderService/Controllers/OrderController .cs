using Microsoft.AspNetCore.Mvc;
using OrderService.Models;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private static List<Order> orders = new List<Order>();

        [HttpPost]
        public IActionResult CreateOrder(Order order)
        {
            orders.Add(order);
            return Ok(order);
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            return Ok(orders);
        }
    }
}