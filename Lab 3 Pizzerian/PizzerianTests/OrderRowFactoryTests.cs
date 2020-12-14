using Lab_3_Pizzerian.Controller.Factories;
using Lab_3_Pizzerian.DataStorageClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace PizzerianTests
{
    [TestClass]
    public class OrderRowFactoryTests
    {
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
    }
}