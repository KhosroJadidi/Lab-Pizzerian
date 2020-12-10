using System;
using System.Collections.Generic;

namespace Lab_3_Pizzerian.Models.Orders
{
    public class Order
    {
        //TODO:Id,Name and Date might not be necessary. ---  I think that some id for database and name for customer communication is needed. Date is important for "Skatteverket".
        public int Id { get; set; }
        public DateTime Date { get; } = DateTime.Now;
        public string CustomersName { get; set; }
        public List<OrderRow> OrderRows { get; set; }
    }
}
