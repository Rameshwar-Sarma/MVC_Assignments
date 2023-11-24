using OrdersWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using OrdersWebApplication.ViewModels;

namespace OrdersWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult GetOrders()
        {
            CustomerOrder orderObj = new CustomerOrder();
            Dictionary<int, List<Order>> result = orderObj.GetOrdersOfCustomer();

            OrdersByCustomer ordersObj = new OrdersByCustomer();
            ordersObj.CustomersList = result;
            return View(ordersObj);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}