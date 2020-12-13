using Lab_3_Pizzerian.Data_Storage_Classes;
using Lab_3_Pizzerian.DataStorageClasses;
using Lab_3_Pizzerian.Viewer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace PizzerianTests
{
    [TestClass]
    public class MessageHandlersTests
    {
        [TestMethod]
        public void PrintWelcomeTest()
        {
            using var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            MessageHandlers.PrintWelcome();
            var expected = "Hello!" +
                "\nWelcome to our pizzeria!";
            var actual = stringWriter.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShowAvailableOptionsTest()
        {
            using var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            MessageHandlers.ShowAvailableOptions();
            var expected = "\n\nPlease enter the corresponding number." +
                "\n\nPizza(0)" +
                "\nDrink(1)" +
                "\n\nFinalize all orders(Y)" +
                "\nCancel all orders(N)";
            var actual = stringWriter.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AskForPizzaTest()
        {
            using var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            MessageHandlers.AskForPizza();
            var expected = "\n\nWhich pizza would u like to order?";
            foreach (var pizza in Pizzas.PizzaNames)
            {
                expected += $"\n{pizza}";
            }
            expected += "\n";
            var actual = stringWriter.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AskForExtrasTest()
        {
            using var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            MessageHandlers.AskForExtras();
            var expected = "\n\nWould you like to add extra ingredients to your pizza?";
            var extras = Ingredients.GetExtra();
            foreach (var extra in extras)
            {
                expected += $"\n{extra}";
            }
            expected += "\n";
            var actual = stringWriter.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AskForDrinksTest()
        {
            using var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            MessageHandlers.AskForDrinks();
            var expected = "\n\nWould you like to add a drink to your order?";
            var sodas = Sodas.SodaNames;
            foreach (var soda in sodas)
            {
                expected += $"\n{soda}";
            }
            expected += "\n";
            var actual = stringWriter.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AskForNextStepTest()
        {
            using var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            MessageHandlers.AskForNextStep();
            var expected = "\n\nWhat would you like to do next?";
            var actual = stringWriter.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}