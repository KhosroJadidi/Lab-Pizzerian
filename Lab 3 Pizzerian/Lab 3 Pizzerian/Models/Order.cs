using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Pizzerian.Models
{
    public class Order
    {
        //TODO:Id,Name and Date might not be necessary.
        public int Id { get; set; }
        public DateTime Date { get;} = DateTime.Now;
        public string CustomersName { get; set; }
        public Pizza Pizza { get; init; }


    }
}
