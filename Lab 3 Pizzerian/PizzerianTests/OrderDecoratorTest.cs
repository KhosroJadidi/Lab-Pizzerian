using Lab_3_Pizzerian.Controller;
using Lab_3_Pizzerian.Controller.Decorators;
using Lab_3_Pizzerian.Controller.Factories;
using Lab_3_Pizzerian.DataStorageClasses;
using Lab_3_Pizzerian.Models.Orders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzerianTests
{
    [TestClass]
    public class OrderDecoratorTest
    {
        [TestMethod]
        public void DeleteOrderRowTest()
        {
            var order = OrderFactory.Factory
                .CreateOrder("Anders", firstOrderRows);
            var rowToDelete = firstOrderRows
                .Single(row => row.RowId == firstOrderRows[0].RowId);
            var sut = OrderDecorator.Decorator;
            var actual= sut.DeleteOrderRow(order,rowToDelete);
            var expected = OrderFactory.Factory
                .CreateOrder("Anders", secondOrderRows);
            Assert.AreEqual
                (
                    expected.OrderRows[0].Pizza,
                    actual.OrderRows[0].Pizza
                );
            Assert.AreEqual
                (
                    expected.OrderRows[0].Soda,
                    actual.OrderRows[0].Soda
                );

            //TODO:rowIds change. either ignore theme or add a central list for both orders and order rows in order to prevent this from happening. Adding a central list is recommended.
            //Assert.AreEqual
            //    (
            //        expected.OrderRows[0].RowId,
            //        actual.OrderRows[0].RowId
            //    );
        }

        #region Test Data Repository

        private readonly List<OrderRow> firstOrderRows = new List<OrderRow>
        {
            OrderRowFactory.RowFactory
                .CreateOrderRow(Pizzas.Hawaii,Sodas.CocaCola),
            OrderRowFactory.RowFactory
                .CreateOrderRow(Pizzas.Kebab_Pizza,Sodas.Fanta),
            OrderRowFactory.RowFactory
                .CreateOrderRow(Pizzas.Margerita,Sodas.Sprite)
        };

        private readonly List<OrderRow> secondOrderRows = new List<OrderRow>
        {
            OrderRowFactory.RowFactory
                .CreateOrderRow(Pizzas.Kebab_Pizza,Sodas.Fanta),
            OrderRowFactory.RowFactory
                .CreateOrderRow(Pizzas.Margerita,Sodas.Sprite)
        };

        #endregion
    }
}
