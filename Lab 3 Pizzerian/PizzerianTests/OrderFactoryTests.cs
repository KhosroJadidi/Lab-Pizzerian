using Lab_3_Pizzerian.Controller;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PizzerianTests
{
    [TestClass]
    public class OrderFactoryTests
    {
        [TestMethod]
        public void GetPizza()
        {
            var pizzeria = OrderFactory.Pizzeria;
            string orderId = pizzeria.PlaceOrder();
            //? Get pizza by observer pattern?
            // Order order = pizzeria.FetchOrder(orderId) after notice
            // Assert.AreEqual(Order, typeof(order)) after 3 seconds
            // Assert.AreEqual(totalPrice, order.TotalPrice)
        }
    }
}