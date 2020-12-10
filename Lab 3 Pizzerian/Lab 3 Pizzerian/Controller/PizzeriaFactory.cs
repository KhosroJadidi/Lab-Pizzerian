using Lab_3_Pizzerian.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Pizzerian.Controller
{
    //? Singleton pattern?
    public sealed class PizzeriaFactory
    {
        private List<Order> placedOrders;
        private PizzeriaFactory()
        {

        }

        public static PizzeriaFactory Pizzeria { get; } = new PizzeriaFactory();

        public string PlaceOrder()
        {
            Order order = new Order();
            // adding order rows to order by itterating user input, check if in stock

            // possibility to abort order or remove order rows...
            
            // Summary and total cost
            // Pay and continue?
            // Function for payment here

            placedOrders.Add(order); // order for baking
                                     // May order to screen for pizza makers be observer pattern?

            return order.Id.ToString();
            
            //? Observer pattern?
            // Set TimeOut for 2 seconds and set finished order to true
            // (if order isn't finished in 3 seconds, fail in test
        }


        public Order FetchOrder(string orderId)
        {
            var id = int.Parse(orderId);
            var order = placedOrders.First(order => order.Id == id);
            // return i.e. null if argumentnullexeption
            // log order to database
            placedOrders.Remove(order);
            return order;
        }
    }
}
