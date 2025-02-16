using Microsoft.AspNetCore.Mvc;
using OrderProcessingApp.Models;

namespace OrderProcessingApp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProcessOrder(decimal orderAmount, string customerType)
        {
            var order = new Order
            {
                OrderAmount = orderAmount,
                CustomerType = customerType
            };

            order.CalculateDiscount();

            return View("Result", order);
        }
    }
}
