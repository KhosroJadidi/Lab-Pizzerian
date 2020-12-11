using Lab_3_Pizzerian.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
