using Lab_3_Pizzerian.DataStorageClasses;
using Lab_3_Pizzerian.Models.Orders;
using System.Collections.Generic;

namespace Lab_3_Pizzerian.Controller
{
    public sealed class OrderFactory
    {
        private readonly List<Order> placedOrders = new List<Order>();
        private int orderId = 1;

        private OrderFactory()
        {
        }

        public static OrderFactory Factory { get; } = new OrderFactory();

        public Order CreateOrder(List<OrderRow> OrderRows)
        {
            var order = new Order
            {
                Id = orderId,
                OrderRows = OrderRows
            };
            Orders.OrdersList.Add(order);
            orderId++;
            return order;
        }
    }
}