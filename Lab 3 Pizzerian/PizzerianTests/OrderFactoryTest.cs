using Lab_3_Pizzerian.Controller;
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
    public class OrderFactoryTest
    {
        [TestMethod]
        public void CreateOrderTest()
        {
            var sut = OrderFactory.Factory;
            var actual = sut.CreateOrder(firstOrderRows);
            var ordersContainsOrder = Orders.OrdersList
                .Contains(actual);
            Assert.IsTrue(ordersContainsOrder);
            var orderIdIsUnique = Orders.OrdersList
                .FindAll(orders => orders.Id == actual.Id)
                .Count == 1;
            Assert.IsTrue(orderIdIsUnique);
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

        #endregion
    }
}
