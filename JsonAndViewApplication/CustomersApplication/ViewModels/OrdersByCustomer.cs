using OrdersWebApplication.Models;

namespace OrdersWebApplication.ViewModels
{
    public class OrdersByCustomer
    {
        public Dictionary<int, List<Order>>? CustomersList { get; set; }
    }
}
