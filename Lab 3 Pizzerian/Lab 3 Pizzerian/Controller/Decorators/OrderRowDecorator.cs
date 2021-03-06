﻿using Lab_3_Pizzerian.DataStorageClasses;
using Lab_3_Pizzerian.Models.Orders;
using System.Linq;

namespace Lab_3_Pizzerian.Controller.Decorators
{
    public sealed class OrderRowDecorator
    {
        private OrderRowDecorator()
        {
        }

        public static OrderRowDecorator RowDecorator { get; } =
            new OrderRowDecorator();

        public OrderRow UpdateOrderRow(OrderRow initialOrderRow, OrderRow replacementOrderRow)
        {
            initialOrderRow.Pizza = replacementOrderRow.Pizza;
            initialOrderRow.Soda = replacementOrderRow.Soda;
            initialOrderRow.TotalPrice = replacementOrderRow.TotalPrice;
            return initialOrderRow;
        }

        public OrderRow ReplaceOrderRow(int orderRowId, OrderRow replacementOrderRow)
        {
            var initialOrderRow = OrderRows.Rows
                .SingleOrDefault(orderRow => orderRow.RowId == orderRowId);
            OrderRows.Rows.Remove(initialOrderRow);
            return initialOrderRow;
        }
    }
}