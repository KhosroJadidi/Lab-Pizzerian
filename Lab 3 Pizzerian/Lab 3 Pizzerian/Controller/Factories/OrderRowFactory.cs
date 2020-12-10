using Lab_3_Pizzerian.Models.Orders;
using Lab_3_Pizzerian.Models.Products;
using Lab_3_Pizzerian.Models.StockItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Pizzerian.Controller.Factories
{
    public sealed class OrderRowFactory
    {
        private int rowId = 1;
        private OrderRowFactory()
        {
        }

        public static OrderRowFactory RowFactory { get; set; } =
                new OrderRowFactory();

        public OrderRow CreateOrderRow(Pizza pizza, Soda soda)
        {
            var orderRow = new OrderRow
            {
                RowId=rowId,
                Pizza = pizza,
                Soda = soda
            };
            rowId++;
            return orderRow;
        }
    }
}
