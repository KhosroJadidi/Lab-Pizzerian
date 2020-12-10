using Lab_3_Pizzerian.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Pizzerian.Controller.Decorators
{
    public sealed class OrderRowDecorator
    {
        private OrderRowDecorator()
        {
        }
        public static OrderRowDecorator RowDecorator { get; } =
            new OrderRowDecorator();

        /*TODO:It's possible to use the row id as well, if a list of
         all order rows is created inside this class.*/ 
        public OrderRow UpdateOrderRow(OrderRow initialOrderRow, OrderRow replacementOrderRow)
        {
            initialOrderRow.Pizza = replacementOrderRow.Pizza;
            initialOrderRow.Soda = replacementOrderRow.Soda;
            return initialOrderRow;
        }
    }
}
