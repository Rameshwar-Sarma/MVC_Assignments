namespace OrdersWebApplication.Models
{
    public interface ICustomerOrders
    {
        Dictionary<int, List<Order>> GetOrdersOfCustomer();
    }
}
