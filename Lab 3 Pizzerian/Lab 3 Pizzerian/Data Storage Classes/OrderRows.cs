using Lab_3_Pizzerian.Models.Orders;
using System.Collections.Generic;

namespace Lab_3_Pizzerian.DataStorageClasses
{
    public sealed class OrderRows
    {
        private OrderRows()
        {
        }

        public static List<OrderRow> Rows { get; set; } =
            new List<OrderRow>();
    }
}