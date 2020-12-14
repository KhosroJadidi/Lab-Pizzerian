using Lab_3_Pizzerian.Controller.Decorators;
using Lab_3_Pizzerian.Data_Storage_Classes;
using Lab_3_Pizzerian.DataStorageClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzerianTests
{
    [TestClass]
    public class PizzaDecoratorTests
    {
        [TestMethod]
        public void AddExtrasTest()
        {
            var sut = PizzaDecorator.Decorator;
            var pizzaBefore = Pizzas.Margerita;
            var actual = sut.AddExtras(pizzaBefore, 0);
            var extraWasAdded = actual.ExtraIngredients.Contains(Ingredients.Ham);
            Assert.IsTrue(extraWasAdded);
        }
    }
}
