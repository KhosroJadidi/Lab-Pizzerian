﻿using Lab_3_Pizzerian.Controller;
using Lab_3_Pizzerian.Controller.Decorators;
using Lab_3_Pizzerian.Controller.Factories;
using Lab_3_Pizzerian.DataStorageClasses;
using Lab_3_Pizzerian.Models.Orders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;

namespace PizzerianTests
{
    [TestClass]
    public class OrderDecoratorTest
    {
        [TestMethod]
        public void DeleteOrderRowByRowTest()
        {
            var sut = OrderDecorator.Decorator;
            OrderFactory.Factory
                .CreateOrder(firstOrderRows);
            Orders.OrdersList.ForEach(order =>
                {
                    Trace.WriteLine(order.Id);
                    order.OrderRows.ForEach(orderRow =>
                        {
                            Trace.WriteLine(orderRow.RowId);
                            Trace.WriteLine(orderRow.Pizza.Name);
                            Trace.WriteLine(orderRow.Soda.Name);
                        });
                });
            var targetOrder = Orders.OrdersList[0];
            var targetOrderRow = targetOrder.OrderRows[0];
            sut.DeleteOrderRow(targetOrder, targetOrderRow);
            var targetOrderRowIsDeleted = !Orders.OrdersList[0]
                .OrderRows.Contains(targetOrderRow);
            Assert.IsTrue(targetOrderRowIsDeleted);
        }

        [TestMethod]
        public void DeleteOrderRowByIdTest()
        {
            var sut = OrderDecorator.Decorator;
            OrderFactory.Factory
                .CreateOrder(firstOrderRows);
            Orders.OrdersList.ForEach(order =>
            {
                Trace.WriteLine(order.Id);
                order.OrderRows.ForEach(orderRow =>
                {
                    Trace.WriteLine(orderRow.RowId);
                    Trace.WriteLine(orderRow.Pizza.Name);
                    Trace.WriteLine(orderRow.Soda.Name);
                });
            });
            var targetOrder = Orders.OrdersList[0];
            var targetOrderRow = targetOrder.OrderRows[0];
            sut.DeleteOrderRow(targetOrder.Id, targetOrderRow);
            var targetOrderRowIsDeleted = !Orders.OrdersList[0]
                .OrderRows.Contains(targetOrderRow);
            Assert.IsTrue(targetOrderRowIsDeleted);
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

        #endregion Test Data Repository
    }
}