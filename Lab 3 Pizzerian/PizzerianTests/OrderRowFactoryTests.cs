using Lab_3_Pizzerian.Controller.Factories;
using Lab_3_Pizzerian.DataStorageClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

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

        [TestMethod]
        public void CreateOrderRowTest()
        {
            var sut = OrderRowFactory.RowFactory;
            var pizza = Pizzas.Hawaii;
            var soda = Sodas.CocaCola;
            var actual = sut.CreateOrderRow(pizza, soda);
            var orderRowsContainsOrder = OrderRows.Rows
                .Contains(actual);
            Assert.IsTrue(orderRowsContainsOrder);
            var orderRowIdIsUnique = OrderRows.Rows
                .FindAll(orderRows => orderRows.RowId == actual.RowId)
                .Count == 1;
            Assert.IsTrue(orderRowIdIsUnique);
        }

        //TODO: The functionality of this test is contained within the above test. Remove it.
        [TestMethod]
        public void OrderRowsTest()
        {
            var sut = OrderRowFactory.RowFactory;
            var pizza = Pizzas.Hawaii;
            var soda = Sodas.Fanta;
            var createdOrderRow = sut.CreateOrderRow(pizza, soda);
            var orderRowIsSubmitted = OrderRows.Rows.Contains(createdOrderRow);
            OrderRows.Rows.ForEach(orderRow =>
            {
                Trace.WriteLine(orderRow.RowId);
                Trace.WriteLine(orderRow.Pizza.Name);
                Trace.WriteLine(orderRow.Soda.Name);
            });
            Assert.IsTrue(orderRowIsSubmitted);
        }

        
    }
}