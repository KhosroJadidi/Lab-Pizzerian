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
        //TODO:fix this test in future.
        [Ignore]
        [TestMethod]
        public void GetUserInputTest()
        {
            using var stringReader
                = new StringReader("D0");
            Console.SetIn(stringReader);
            var expected = "D0";
            var actual = UserInputHandlers.GetUserInput()
                .ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}