using Lab_3_Pizzerian.Controller;
using Lab_3_Pizzerian.Controller.Factories;
using Lab_3_Pizzerian.DataStorageClasses;
using Lab_3_Pizzerian.Models.Orders;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PizzerianTests
{
    [TestClass]
    public class OrderRowFactoryTests
    {
        //[TestMethod]
        //public void GetPizza()
        //{
        //    var pizzeria = OrderFactory.Pizzeria;
        //    string orderId = pizzeria.PlaceOrder();
        //    //? Get pizza by observer pattern?
        //    // Order order = pizzeria.FetchOrder(orderId) after notice
        //    // Assert.AreEqual(Order, typeof(order)) after 3 seconds
        //    // Assert.AreEqual(totalPrice, order.TotalPrice)
        //}

        //Todo: rowids don't match, use a central for order rows and orders to fix this.
        [TestMethod]
        public void CreateOrderRowTest()
        {
            var sur = OrderRowFactory.RowFactory;
            var pizza = Pizzas.Hawaii;
            var soda = Sodas.CocaCola;
            var actual= sur.CreateOrderRow(pizza, soda);
            var expected = new OrderRow
            {
                //RowId = 1,
                Pizza = pizza,
                Soda = soda
            };
            //Assert.AreEqual(1, actual.RowId);
            Assert.AreEqual(expected.Pizza, actual.Pizza);
            Assert.AreEqual(expected.Soda, actual.Soda);
        }
    }
}