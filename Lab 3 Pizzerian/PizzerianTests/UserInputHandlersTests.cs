using Lab_3_Pizzerian;
using Lab_3_Pizzerian.Handlers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;


namespace PizzerianTests
{
    [TestClass]
    public class UserInputHandlersTests
    {
        [TestMethod]
        public void GetUserInputTest()
        {
            using var stringReader
                = new StringReader("Hello");
            Console.SetIn(stringReader);
            var expected = "Hello";
            var actual = UserInputHandlers.GetUserInput();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidatePizzaChoiceTest()
        {
            var validationResult =
                UserInputHandlers.ValidatePizzaChoice("wrong");
            Assert.IsTrue(!validationResult.Item1);
            Assert.IsTrue(validationResult.Item2==-1);
            validationResult = UserInputHandlers.ValidatePizzaChoice("-10");
            Assert.IsTrue(!validationResult.Item1);
            Assert.IsTrue(validationResult.Item2 == -1);
            validationResult = UserInputHandlers.ValidatePizzaChoice("4");
            Assert.IsTrue(validationResult.Item1);
            Assert.IsTrue(validationResult.Item2 ==4);
        }
    }
}