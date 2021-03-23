using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class CalculatorCoreTest
    {
        [TestMethod]
        public void CalculatorMethodTest()
        {
            int number1 = 10;
            int number2 = 5;
            int expectedAdd = 15;
            int expectedSubtract = 5;
            int expectedMultiply = 50;
            int expectedDivide = 2;

            Calculator.Core.CalculatorMethods methods = new Calculator.Core.CalculatorMethods();
            int actualAdd = methods.Add(number1, number2);

            Assert.AreEqual(expectedAdd, actualAdd);
        }
    }
}
