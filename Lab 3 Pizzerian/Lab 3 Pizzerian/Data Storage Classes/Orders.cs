using Lab_3_Pizzerian.Models.Orders;
using System.Collections.Generic;

namespace Lab_3_Pizzerian.DataStorageClasses
{
    public sealed class Orders
    {
        private Orders()
        {
        }

        public static List<Order> OrdersList { get; set; } =
            new List<Order>();
    }
}