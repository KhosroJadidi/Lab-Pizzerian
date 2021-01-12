using Lab_3_Pizzerian.Controller.Decorators;
using Lab_3_Pizzerian.Data_Storage_Classes;
using Lab_3_Pizzerian.DataStorageClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace PizzerianTests
{
    [TestClass]
    public class PizzaDecoratorTests
    {
        [TestMethod]
        public void AddExtrasTest()
        {
            var sut = PizzaDecorator.Decorator;
            var margerita = Pizzas.Margerita;
            var actual = sut.AddExtras(margerita, 0);
            var firstExtraHasBeenAdded = actual.ExtraIngredients
                .Contains(Ingredients.Ham);
            Assert.IsTrue(firstExtraHasBeenAdded);
            actual = sut.AddExtras(margerita, 1);
            var secondExtraHasBeenAdded = actual.ExtraIngredients
                .Contains(Ingredients.Pineapple);
            Assert.IsTrue(secondExtraHasBeenAdded);
            actual = sut.AddExtras(margerita, 1);
            var duplicateExtraWasNotAdded = actual.ExtraIngredients
                .Count(ex => ex.Name == Ingredients.Pineapple.Name)
                == 1;
            Assert.IsTrue(duplicateExtraWasNotAdded);
        }
    }
}