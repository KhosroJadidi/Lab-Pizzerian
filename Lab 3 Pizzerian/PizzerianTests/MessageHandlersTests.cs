using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_3_Pizzerian.Viewer;
using System.Diagnostics;

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
        public static void AskForPizzaTest()
        {

        }

        [TestMethod]
        public static void AskForExtrasTest()
        {

        }

        [TestMethod]
        public static void AskForDrinksTest()
        {

        }

        [TestMethod]
        public static void AskForNextStepTest()
        {

        }
    }
}
