using System.Diagnostics;

namespace OrdersWebApplication.Models
{
    public class CustomerOrder : ICustomerOrders
    {
        public static List<Order> MyData()
        {
            IEnumerable<Order> ordersList = new List<Order>()
            {
                new Order {Id = 1, Name = "Pizza", CustomerId = 201, Location = "Madhapur"},
                new Order {Id = 2, Name = "Burger", CustomerId = 201, Location = "Madhapur"},
                new Order {Id = 3, Name = "Chips", CustomerId = 202, Location = "KPHB"},
                new Order {Id = 4, Name = "Pizza", CustomerId = 203, Location = "Madhapur"},
                new Order {Id = 5, Name = "Pastry", CustomerId = 203, Location = "KPHB" },
                new Order {Id = 6, Name = "CoolDrink", CustomerId = 204, Location = "Jublee Hills"},
                new Order {Id = 7, Name = "Samosa", CustomerId = 204, Location = "Jublee Hills"},
                new Order {Id = 8, Name = "PopCorn", CustomerId = 204, Location = "Jublee Hills"},
                new Order {Id = 9, Name = "Burger", CustomerId = 205, Location = "KPHB"},
                new Order {Id = 10, Name = "Sweets", CustomerId = 205, Location = "KPHB"}    
            };
            return ordersList.ToList();
        }
        public Dictionary<int,List<Order>> GetOrdersOfCustomer()
        {
            IEnumerable<Order> ordersList = new List<Order>();
            Dictionary<int, List<Order>> customers = new Dictionary<int, List<Order>>();
            ordersList = from order in MyData()
                         orderby order.CustomerId ascending
                         select order;
            foreach(Order o in ordersList)
            {
                if (!customers.ContainsKey(o.CustomerId))
                {
                    customers.Add(o.CustomerId, new List<Order>());    
                }
                customers[o.CustomerId].Add(o);
            }
          return customers;
        }
    }
}
