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
                "\nWhat would you like to order?";
            var actual = stringWriter.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AskForPizzaTest()
        {
            using var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            MessageHandlers.AskForPizza();
            var expected = "Which pizza would u like to order?";
            var actual = stringWriter.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AskForExtrasTest()
        {
            using var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            MessageHandlers.AskForExtras();
            var expected = "Would you like to add extra ingredients to your pizza?";
            var actual = stringWriter.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AskForDrinksTest()
        {
            using var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            MessageHandlers.AskForDrinks();
            var expected = "Would you like to add a drink to your order?";
            var actual = stringWriter.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AskForNextStepTest()
        {
            using var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            MessageHandlers.AskForNextStep();
            var expected = "What would you like to do next?";
            var actual = stringWriter.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}