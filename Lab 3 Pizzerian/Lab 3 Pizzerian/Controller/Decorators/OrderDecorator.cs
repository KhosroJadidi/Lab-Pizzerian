using Lab_3_Pizzerian.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Pizzerian.Controller.Decorators
{
    public sealed class OrderDecorator
    {
        private OrderDecorator()
        {
        }
        public static OrderDecorator Decorator { get; set; } =
            new OrderDecorator();

        //TODO: perhaps add the ability to delete on order row with only id. make a list of all orders here.
        public Order DeleteOrderRow(Order order, OrderRow rowToDelete)
        {
            order.OrderRows.Remove(rowToDelete);
            return order;                
        }
    }
}
