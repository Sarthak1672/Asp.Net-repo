using Microsoft.AspNetCore.Mvc;
using OrderProcessingApp.Models;

namespace OrderProcessingApp.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProcessOrder(Order order)
        {
            if (ModelState.IsValid)
            {
                order.CalculateDiscount();
                return View("Result", order);
            }
            return View("Index");
        }
    }
}
