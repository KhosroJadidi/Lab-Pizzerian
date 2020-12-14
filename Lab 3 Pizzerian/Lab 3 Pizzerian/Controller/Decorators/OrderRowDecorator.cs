using Lab_3_Pizzerian.DataStorageClasses;
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

        public  OrderRow UpdateOrderRow(OrderRow initialOrderRow, OrderRow replacementOrderRow)
        {
            initialOrderRow.Pizza = replacementOrderRow.Pizza;
            initialOrderRow.Soda = replacementOrderRow.Soda;
            initialOrderRow.TotalPrice = replacementOrderRow.TotalPrice;
            return initialOrderRow;
        }
        public  OrderRow UpdateOrderRow(int orderRowId, OrderRow replacementOrderRow)
        {
            var initialOrderRow = OrderRows.Rows
                .SingleOrDefault(orderRow => orderRow.RowId == orderRowId);
            initialOrderRow.Pizza = replacementOrderRow.Pizza;
            initialOrderRow.Soda = replacementOrderRow.Soda;
            initialOrderRow.TotalPrice = replacementOrderRow.TotalPrice;
            return initialOrderRow;
        }
    }
}
