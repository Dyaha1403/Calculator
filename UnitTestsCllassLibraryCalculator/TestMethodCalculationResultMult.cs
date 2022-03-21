using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryCalculator;

namespace UnitTestsCllassLibraryCalculator
{
    [TestClass]
    public class TestMethodCalculationResultMult
    {
        private Calculator calculator = new Calculator();

        [TestInitialize]
        public void InputOperation()
        {
            calculator.operation = "*";
        }

        [TestMethod]
        public void CalculationResult_8mult7_56Returned()
        {
            //Arrange
            calculator.num_1 = "8";
            calculator.num_2 = "7";
            string expected = "56";

            //Act
            string actual = calculator.CalculationResult();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculationResult_56mult10_560Returned()
        {
            //Arrange
            calculator.num_1 = "56";
            calculator.num_2 = "10";
            string expected = "560";

            //Act
            string actual = calculator.CalculationResult();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
