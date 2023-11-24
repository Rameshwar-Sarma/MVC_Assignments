namespace OrdersWebApplication.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int CustomerId { get; set; }
    }
}
