using System;
using System.Collections.Generic;

namespace Lab_3_Pizzerian.Models.Orders
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; } = DateTime.Now;
        public List<OrderRow> OrderRows { get; set; }
    }
}