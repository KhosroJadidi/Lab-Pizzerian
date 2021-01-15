using Lab_3_Pizzerian.Controller.Factories;
using Lab_3_Pizzerian.Data_Storage_Classes;
using Lab_3_Pizzerian.DataStorageClasses;
using Lab_3_Pizzerian.Handlers;
using Lab_3_Pizzerian.Models.Orders;
using Lab_3_Pizzerian.Models.StockItems;
using Lab_3_Pizzerian.Viewer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
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
                "\nWelcome to our pizzeria!" +
                "\nPlease enter the corresponding number and press ENTER.";
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
            var pizzas = Pizzas.PizzaNames;
            for (int i = 0; i < pizzas.Length; i++)
            {
                expected += $"\n{pizzas[i]} ({i})";
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
            for (int i = 0; i < extras.Length; i++)
            {
                expected += $"\n{extras[i]} ({i})";
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
            for (int i = 0; i < sodas.Length; i++)
            {
                expected += $"\n{sodas[i]} ({i})";
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

        [TestMethod]
        public void PrintWrongChoiceTest()
        {
            using var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            MessageHandlers.PrintWrongChoice();
            var expected = "Wrong input! Please try again." + Environment.NewLine;
            var actual = stringWriter.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AskForMoreTest()
        {
            using var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            MessageHandlers.AskForMoreIngredients();
            var expected = "Would you like to add more?" +
                "\nYes(0)" +
                "\nNo(1)" + Environment.NewLine;
            var actual = stringWriter.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AskForMoreOrderRowsTest()
        {
            using var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            MessageHandlers.AskForMoreOrderRows();
            var expected = "Would you like to add more order rows?" +
                "\nYes(0)" +
                "\nNo(1)";
            var actual = stringWriter.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrintSubmittedTest()
        {
            using var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            MessageHandlers.PrintSubmitted();
            var expected = "You Order Has Been Submitted." + Environment.NewLine;
            var actual = stringWriter.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DisplayOrderListTest()
        {
            using var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            var pizza = Pizzas.Hawaii;
            pizza.ExtraIngredients = new List<Ingredient>
            {
                Ingredients.Ham
            };
            var orderList = new List<OrderRow>
            {
                OrderRowFactory.RowFactory.CreateOrderRow
                (pizza,Sodas.CocaCola)
            };
            var ingredientsString = string.Empty;
            foreach (var ing in orderList[0].Pizza.Ingredients)
            {
                ingredientsString += ing.Name +
                    Environment.NewLine;
            }
            var extraIngredients = string.Empty;
            foreach (var ing in orderList[0].Pizza.ExtraIngredients)
            {
                extraIngredients += ing.Name +
                    Environment.NewLine;
            }
            var totalPrice = OrderRowHandlers.GetTotalPriceForOrderRow();
            MessageHandlers.DisplayOrderList(orderList);
            var expected = "\n\nYou have the following order rows:"
                + Environment.NewLine
                + $"Row ID:{orderList[0].RowId}"
                + Environment.NewLine
                + $"Pizza:{orderList[0].Pizza.Name}"
                + Environment.NewLine
                + "Ingredients:"
                + Environment.NewLine
                + ingredientsString
                + "Extra ingredients:"
                + Environment.NewLine
                + extraIngredients
                + $"Soda: {orderList[0].Soda.Name}"
                + Environment.NewLine
                + $"Total Price: {orderList[0].TotalPrice}"
                + Environment.NewLine
                + $"\n\nTotal price for the order row: {totalPrice}"
                + Environment.NewLine;

            var actual = stringWriter.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AskForConfirmationTest()
        {
            using var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            MessageHandlers.AskForConfirmation();
            var expected = "Are you happy with your order?"
                + Environment.NewLine
                + "Yes(0)" +
                Environment.NewLine
                + "No, I want to re-order the following ID:"
                + Environment.NewLine;
            var actual = stringWriter.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}