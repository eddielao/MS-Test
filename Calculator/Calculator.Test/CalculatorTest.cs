using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Test_Divide()
        {
            // Arrange
            int expected = 3;
            int numerator = 18;
            int denominator = 6;

            // Act
            int actual = Calculator.Library.Calculator.Divide(numerator, denominator);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
