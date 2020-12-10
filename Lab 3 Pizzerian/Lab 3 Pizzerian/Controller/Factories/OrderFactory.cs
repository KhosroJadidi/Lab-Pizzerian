using Lab_3_Pizzerian.Models.Orders;
using System.Collections.Generic;
using System.Linq;

namespace Lab_3_Pizzerian.Controller
{
    //? Singleton pattern?
    public sealed class OrderFactory
    {
        private readonly List<Order> placedOrders = new List<Order>();
        private int orderId = 1;
        private OrderFactory()
        {
        }

        public static OrderFactory Factory { get; } = new OrderFactory();

        public object CreateOrder(string v, object firstOrderRows)
        {
            throw new System.NotImplementedException();
        }

        public string PlaceOrder()
        {
            Order order = new Order();
            // adding order rows to order by itterating user input, check if in stock

            // possibility to abort order or remove order rows...

            // Summary and total cost
            // Pay and continue?
            // Function for payment here

            placedOrders.Add(order); // order for baking
                                     // May order to screen for pizza makers be observer pattern?

            return order.Id.ToString();

            //? Observer pattern?
            // Set TimeOut for 2 seconds and set finished order to true
            // (if order isn't finished in 3 seconds, fail in test
        }

        public Order FetchOrder(string orderId)
        {
            var id = int.Parse(orderId);
            var order = placedOrders.First(order => order.Id == id);
            // return i.e. null if argumentnullexeption
            // log order to database
            placedOrders.Remove(order);
            return order;
        }

        public Order CreateOrder(string customerName, List<OrderRow> OrderRows)
        {
            var order = new Order
            {
                Id = orderId,
                CustomersName = customerName,
                OrderRows = OrderRows
            };
            orderId++;
            return order;
        }
    }
}