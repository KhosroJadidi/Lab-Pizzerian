using Lab_3_Pizzerian.Controller.Decorators;
using Lab_3_Pizzerian.Controller.Factories;
using Lab_3_Pizzerian.DataStorageClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PizzerianTests
{
    [TestClass]
    public class OrderRowDecoratorTests
    {
        [TestMethod]
        public void UpdateOrderRowByOrderTest()
        {
            var firstPizza = Pizzas.Hawaii;
            var secondPizza = Pizzas.Kebab_Pizza;
            var firstSoda = Sodas.CocaCola;
            var secondSoda = Sodas.Sprite;
            var initialOrderRow = OrderRowFactory.RowFactory.
                CreateOrderRow(firstPizza, firstSoda);
            var replacementOrderRow = OrderRowFactory.RowFactory.
                CreateOrderRow(secondPizza, secondSoda);
            var sut = OrderRowDecorator.RowDecorator;
            var actual = sut.UpdateOrderRow(initialOrderRow, replacementOrderRow);
            Assert.AreEqual(actual.Pizza, secondPizza);
            Assert.AreEqual(actual.Soda, secondSoda);
            var orderRowsHaveBeenUpdated = OrderRows.Rows
                .Contains(replacementOrderRow);
            Assert.IsTrue(orderRowsHaveBeenUpdated);
        }

        [TestMethod]
        public void UpdateOrderRowByIdTest()
        {
            var firstPizza = Pizzas.Hawaii;
            var secondPizza = Pizzas.Kebab_Pizza;
            var firstSoda = Sodas.CocaCola;
            var secondSoda = Sodas.Sprite;
            var initialOrderRow = OrderRowFactory.RowFactory.
                CreateOrderRow(firstPizza, firstSoda);
            var replacementOrderRow = OrderRowFactory.RowFactory.
                CreateOrderRow(secondPizza, secondSoda);
            var sut = OrderRowDecorator.RowDecorator;
            var actual = sut.ReplaceOrderRow(initialOrderRow.RowId, replacementOrderRow);
            Assert.AreEqual(actual.Pizza, secondPizza);
            Assert.AreEqual(actual.Soda, secondSoda);
            var orderRowsHaveBeenUpdated = OrderRows.Rows
                .Contains(replacementOrderRow);
            Assert.IsTrue(orderRowsHaveBeenUpdated);
        }
    }
}