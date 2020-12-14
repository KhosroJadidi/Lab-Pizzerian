using Lab_3_Pizzerian.DataStorageClasses;
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

        public void DeleteOrderRow(Order givenOrder, OrderRow rowToDelete)
        {
            Orders.OrdersList.Find(order => order == givenOrder)
                .OrderRows.Remove(rowToDelete);                    
        }
        public void DeleteOrderRow(int givenOrder, OrderRow rowToDelete)
        {
            Orders.OrdersList.Find(order => order.Id == givenOrder)
                .OrderRows.Remove(rowToDelete);
        }
    }
}
